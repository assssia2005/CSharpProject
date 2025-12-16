using Microsoft.Data.Sqlite;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CSharpProject;

public class Database
{
    private const string ConnectionString = "Data Source=nutrition.db";

    public static void InitializeDatabase()
    {
        using (var connection = new SqliteConnection(ConnectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText =
            @"
                CREATE TABLE IF NOT EXISTS food (
                    food_name TEXT PRIMARY KEY,
                    category TEXT,
                    calories REAL,
                    protein REAL,
                    carbs REAL,
                    fat REAL,
                    iron REAL,
                    vitamin_c REAL
                );

                CREATE TABLE IF NOT EXISTS daily_log (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    log_date TEXT NOT NULL,
                    food_name TEXT NOT NULL,
                    weight REAL NOT NULL,
                    FOREIGN KEY (food_name) REFERENCES food(food_name)
                );
            ";
            command.ExecuteNonQuery();
        }
    }

    public static void ImportDataFromCsv(string csvFilePath)
    {
        using (var connection = new SqliteConnection(ConnectionString))
        {
            connection.Open();

            using (var transaction = connection.BeginTransaction())
            {
                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    INSERT OR IGNORE INTO food (food_name, category, calories, protein, carbs, fat, iron, vitamin_c)
                    VALUES ($food_name, $category, $calories, $protein, $carbs, $fat, $iron, $vitamin_c)
                ";

                command.Parameters.Add("$food_name", SqliteType.Text);
                command.Parameters.Add("$category", SqliteType.Text);
                command.Parameters.Add("$calories", SqliteType.Real);
                command.Parameters.Add("$protein", SqliteType.Real);
                command.Parameters.Add("$carbs", SqliteType.Real);
                command.Parameters.Add("$fat", SqliteType.Real);
                command.Parameters.Add("$iron", SqliteType.Real);
                command.Parameters.Add("$vitamin_c", SqliteType.Real);

                using (var reader = new StreamReader(csvFilePath))
                {
                    reader.ReadLine(); // Skip header
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        var values = Regex.Split(line, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                        for (int i = 0; i < values.Length; i++)
                        {
                            values[i] = values[i].Trim('\"');
                        }

                        command.Parameters["$food_name"].Value = values[0];
                        command.Parameters["$category"].Value = values[1];
                        command.Parameters["$calories"].Value = double.TryParse(values[2], NumberStyles.Any, CultureInfo.InvariantCulture, out var calories) ? calories : (object)DBNull.Value;
                        command.Parameters["$protein"].Value = double.TryParse(values[3], NumberStyles.Any, CultureInfo.InvariantCulture, out var protein) ? protein : (object)DBNull.Value;
                        command.Parameters["$carbs"].Value = double.TryParse(values[4], NumberStyles.Any, CultureInfo.InvariantCulture, out var carbs) ? carbs : (object)DBNull.Value;
                        command.Parameters["$fat"].Value = double.TryParse(values[5], NumberStyles.Any, CultureInfo.InvariantCulture, out var fat) ? fat : (object)DBNull.Value;
                        command.Parameters["$iron"].Value = values.Length > 6 && double.TryParse(values[6], NumberStyles.Any, CultureInfo.InvariantCulture, out var iron) ? iron : (object)DBNull.Value;
                        command.Parameters["$vitamin_c"].Value = values.Length > 7 && double.TryParse(values[7], NumberStyles.Any, CultureInfo.InvariantCulture, out var vitC) ? vitC : (object)DBNull.Value;
                        command.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
            }
        }
    }

     public static List<Food> SearchFood(string query)
    {
        var foods = new List<Food>();
        using (var connection = new SqliteConnection(ConnectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText =
            @"
                SELECT food_name, category, calories, protein, carbs, fat, iron, vitamin_c
                FROM food
                WHERE food_name LIKE $query
            ";
            command.Parameters.AddWithValue("$query", $"%{query}%");

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var food = new Food
                    {
                        FoodName = reader.GetString(0),
                        Category = reader.GetString(1),
                        Calories = reader.IsDBNull(2) ? 0 : reader.GetDouble(2),
                        Protein = reader.IsDBNull(3) ? 0 : reader.GetDouble(3),
                        Carbs = reader.IsDBNull(4) ? 0 : reader.GetDouble(4),
                        Fat = reader.IsDBNull(5) ? 0 : reader.GetDouble(5),
                        Iron = reader.IsDBNull(6) ? 0 : reader.GetDouble(6),
                        VitaminC = reader.IsDBNull(7) ? 0 : reader.GetDouble(7)
                    };
                    foods.Add(food);
                }
            }
        }
        return foods;
    }

    public static bool IsDatabaseEmpty()
    {
        using (var connection = new SqliteConnection(ConnectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM food";
            var count = (long)command.ExecuteScalar();
            return count == 0;
        }
    }

    public static void AddFoodToLog(Food food, DateTime date, double weight)
    {
        using (var connection = new SqliteConnection(ConnectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO daily_log (log_date, food_name, weight) VALUES ($log_date, $food_name, $weight)";
            command.Parameters.AddWithValue("$log_date", date.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("$food_name", food.FoodName);
            command.Parameters.AddWithValue("$weight", weight);
            command.ExecuteNonQuery();
        }
    }

    public static void RemoveFoodFromLog(int logId)
    {
        using (var connection = new SqliteConnection(ConnectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM daily_log WHERE id = $id";
            command.Parameters.AddWithValue("$id", logId);
            command.ExecuteNonQuery();
        }
    }

    public static void UpdateLogEntryWeight(int logId, double newWeight)
    {
        using (var connection = new SqliteConnection(ConnectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "UPDATE daily_log SET weight = $weight WHERE id = $id";
            command.Parameters.AddWithValue("$weight", newWeight);
            command.Parameters.AddWithValue("$id", logId);
            command.ExecuteNonQuery();
        }
    }

    public static List<LoggedFood> GetLogForDate(DateTime date)
    {
        var foods = new List<LoggedFood>();
        using (var connection = new SqliteConnection(ConnectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                SELECT dl.id, f.food_name, f.category, f.calories, f.protein, f.carbs, f.fat, f.iron, f.vitamin_c, dl.weight
                FROM daily_log dl
                JOIN food f ON dl.food_name = f.food_name
                WHERE dl.log_date = $log_date
            ";
            command.Parameters.AddWithValue("$log_date", date.ToString("yyyy-MM-dd"));

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var food = new LoggedFood
                    {
                        Id = reader.GetInt32(0),
                        FoodName = reader.GetString(1),
                        Category = reader.GetString(2),
                        Calories = reader.IsDBNull(3) ? 0 : reader.GetDouble(3),
                        Protein = reader.IsDBNull(4) ? 0 : reader.GetDouble(4),
                        Carbs = reader.IsDBNull(5) ? 0 : reader.GetDouble(5),
                        Fat = reader.IsDBNull(6) ? 0 : reader.GetDouble(6),
                        Iron = reader.IsDBNull(7) ? 0 : reader.GetDouble(7),
                        VitaminC = reader.IsDBNull(8) ? 0 : reader.GetDouble(8),
                        Weight = reader.GetDouble(9)
                    };
                    foods.Add(food);
                }
            }
        }
        return foods;
    }
}
