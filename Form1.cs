using System.Diagnostics;

namespace CSharpProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Wire up event handlers
            searchButton.Click += SearchButton_Click;
            addButton.Click += AddButton_Click;
            removeButton.Click += RemoveButton_Click;

            // Set display members for list boxes
            foodListBox.DisplayMember = "FoodName";
            dailyLogListBox.DisplayMember = "FoodName";

            // Load today's log on startup
            LoadDailyLog(DateTime.Today);

            // Wire up history page event handler
            historyDateTimePicker.ValueChanged += HistoryDateTimePicker_ValueChanged;
            // Load history for today on startup
            LoadHistoryLog(DateTime.Today);
        }

        private void HistoryDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadHistoryLog(historyDateTimePicker.Value);
        }

        private void LoadHistoryLog(DateTime date)
        {
            var historyLog = Database.GetLogForDate(date);
            historyListBox.DataSource = null;
            historyListBox.DataSource = historyLog;
            historyListBox.DisplayMember = "FoodName";
            UpdateHistoryTotals();
        }

        private void UpdateHistoryTotals()
        {
            double totalCalories = 0;
            double totalProtein = 0;
            double totalCarbs = 0;
            double totalFat = 0;
            double totalIron = 0;
            double totalVitaminC = 0;

            if (historyListBox.DataSource is List<Food> historyLog)
            {
                foreach (var food in historyLog)
                {
                    totalCalories += food.Calories;
                    totalProtein += food.Protein;
                    totalCarbs += food.Carbs;
                    totalFat += food.Fat;
                    totalIron += food.Iron;
                    totalVitaminC += food.VitaminC;
                }
            }

            historyTotalCaloriesLabel.Text = $"Total Calories: {totalCalories:F2}";
            historyTotalProteinLabel.Text = $"Total Protein: {totalProtein:F2}";
            historyTotalCarbsLabel.Text = $"Total Carbs: {totalCarbs:F2}";
            historyTotalFatLabel.Text = $"Total Fat: {totalFat:F2}";
            historyTotalIronLabel.Text = $"Total Iron: {totalIron:F2}";
            historyTotalVitaminCLabel.Text = $"Total Vitamin C: {totalVitaminC:F2}";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var query = searchTextBox.Text;
            if (!string.IsNullOrWhiteSpace(query))
            {
                var foods = Database.SearchFood(query);
                foodListBox.DataSource = foods;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var selectedFood = (Food)foodListBox.SelectedItem;
            if (selectedFood != null)
            {
                Database.AddFoodToLog(selectedFood, DateTime.Today);
                LoadDailyLog(DateTime.Today);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selectedFood = (Food)dailyLogListBox.SelectedItem;
            if (selectedFood != null)
            {
                Database.RemoveFoodFromLog(selectedFood, DateTime.Today);
                LoadDailyLog(DateTime.Today);
            }
        }

        private void LoadDailyLog(DateTime date)
        {
            var dailyLog = Database.GetLogForDate(date);
            dailyLogListBox.DataSource = null; // Clear existing data source
            dailyLogListBox.DataSource = dailyLog; // Set new data source
            dailyLogListBox.DisplayMember = "FoodName";
            UpdateTotals();
        }

        private void UpdateTotals()
        {
            double totalCalories = 0;
            double totalProtein = 0;
            double totalCarbs = 0;
            double totalFat = 0;
            double totalIron = 0;
            double totalVitaminC = 0;

            if (dailyLogListBox.DataSource is List<Food> dailyLog)
            {
                foreach (var food in dailyLog)
                {
                    totalCalories += food.Calories;
                    totalProtein += food.Protein;
                    totalCarbs += food.Carbs;
                    totalFat += food.Fat;
                    totalIron += food.Iron;
                    totalVitaminC += food.VitaminC;
                }
            }

            totalCaloriesLabel.Text = $"Total Calories: {totalCalories:F2}";
            totalProteinLabel.Text = $"Total Protein: {totalProtein:F2}";
            totalCarbsLabel.Text = $"Total Carbs: {totalCarbs:F2}";
            totalFatLabel.Text = $"Total Fat: {totalFat:F2}";
            totalIronLabel.Text = $"Total Iron: {totalIron:F2}";
            totalVitaminCLabel.Text = $"Total Vitamin C: {totalVitaminC:F2}";
        }
    }
}
