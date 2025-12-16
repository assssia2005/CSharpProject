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

            // Set display members for list boxes to use the new DisplayName property
            foodListBox.DisplayMember = "FoodName";
            dailyLogListBox.DisplayMember = "DisplayName";
            historyListBox.DisplayMember = "DisplayName";

            // Load today's log on startup
            LoadDailyLog(DateTime.Today);

            // Wire up history page event handler and load initial data
            historyDateTimePicker.ValueChanged += HistoryDateTimePicker_ValueChanged;
            LoadHistoryLog(DateTime.Today);
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
            if (selectedFood == null) return;

            // Create a small form on the fly to ask for the weight
            Form prompt = new Form()
            {
                Width = 250,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Enter Weight",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 20, Top = 20, Text = "Weight (g):" };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 200 };
            Button confirmationButton = new Button() { Text = "Ok", Left = 120, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmationButton.Click += (s, ev) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmationButton);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmationButton;

            // If the user clicks OK and the weight is a valid number, add it to the log
            if (prompt.ShowDialog() == DialogResult.OK)
            {
                if (double.TryParse(textBox.Text, out double weight) && weight > 0)
                {
                    Database.AddFoodToLog(selectedFood, DateTime.Today, weight);
                    LoadDailyLog(DateTime.Today);
                }
                else
                {
                    MessageBox.Show("Please enter a valid weight.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selectedLoggedFood = (LoggedFood)dailyLogListBox.SelectedItem;
            if (selectedLoggedFood != null)
            {
                Database.RemoveFoodFromLog(selectedLoggedFood.Id);
                LoadDailyLog(DateTime.Today);
            }
        }

        private void LoadDailyLog(DateTime date)
        {
            var dailyLog = Database.GetLogForDate(date);
            dailyLogListBox.DataSource = null;
            dailyLogListBox.DataSource = dailyLog;
            dailyLogListBox.DisplayMember = "DisplayName";
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

            if (dailyLogListBox.DataSource is List<LoggedFood> dailyLog)
            {
                foreach (var food in dailyLog)
                {
                    // Nutrition values are per 100g, so adjust for weight
                    double weightFactor = food.Weight / 100.0;
                    totalCalories += food.Calories * weightFactor;
                    totalProtein += food.Protein * weightFactor;
                    totalCarbs += food.Carbs * weightFactor;
                    totalFat += food.Fat * weightFactor;
                    totalIron += food.Iron * weightFactor;
                    totalVitaminC += food.VitaminC * weightFactor;
                }
            }

            totalCaloriesLabel.Text = $"Total Calories: {totalCalories:F2}";
            totalProteinLabel.Text = $"Total Protein: {totalProtein:F2}";
            totalCarbsLabel.Text = $"Total Carbs: {totalCarbs:F2}";
            totalFatLabel.Text = $"Total Fat: {totalFat:F2}";
            totalIronLabel.Text = $"Total Iron: {totalIron:F2}";
            totalVitaminCLabel.Text = $"Total Vitamin C: {totalVitaminC:F2}";
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
            historyListBox.DisplayMember = "DisplayName";
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

            if (historyListBox.DataSource is List<LoggedFood> historyLog)
            {
                foreach (var food in historyLog)
                {
                    // Adjust nutrition values for the logged weight
                    double weightFactor = food.Weight / 100.0;
                    totalCalories += food.Calories * weightFactor;
                    totalProtein += food.Protein * weightFactor;
                    totalCarbs += food.Carbs * weightFactor;
                    totalFat += food.Fat * weightFactor;
                    totalIron += food.Iron * weightFactor;
                    totalVitaminC += food.VitaminC * weightFactor;
                }
            }

            historyTotalCaloriesLabel.Text = $"Total Calories: {totalCalories:F2}";
            historyTotalProteinLabel.Text = $"Total Protein: {totalProtein:F2}";
            historyTotalCarbsLabel.Text = $"Total Carbs: {totalCarbs:F2}";
            historyTotalFatLabel.Text = $"Total Fat: {totalFat:F2}";
            historyTotalIronLabel.Text = $"Total Iron: {totalIron:F2}";
            historyTotalVitaminCLabel.Text = $"Total Vitamin C: {totalVitaminC:F2}";
        }
    }
}
