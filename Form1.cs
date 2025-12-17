using System.Diagnostics;

namespace CSharpProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Set the button icon from embedded resources
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            string[] resources = assembly.GetManifestResourceNames();
            System.IO.File.WriteAllLines("resource_names.txt", resources);

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
            editButton.Click += EditButton_Click;
            LoadHistoryLog(DateTime.Today);

            // Initialize the Calorie Calculator tab
            InitializeCalculator();
        }

        private void InitializeCalculator()
        {
            // Populate ComboBoxes
            formulaComboBox.Items.AddRange(new string[] { "Mifflin-St Jeor", "Revised Harris-Benedict", "Katch-McArdle" });
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
            activityLevelComboBox.DataSource = Enum.GetValues(typeof(ActivityLevel));

            // Set default selections
            formulaComboBox.SelectedIndex = 0;
            genderComboBox.SelectedIndex = 0;
            activityLevelComboBox.SelectedIndex = 0;

            // Wire up event handlers
            formulaComboBox.SelectedIndexChanged += FormulaComboBox_SelectedIndexChanged;
            calculateButton.Click += CalculateButton_Click;

            // Set the button icon from embedded resources
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            string[] resources = assembly.GetManifestResourceNames();
            System.IO.File.WriteAllLines("resource_names.txt", resources);
            using (var stream = assembly.GetManifestResourceStream("CSharpProject.calculator.png"))
            {
                if (stream != null)
                {
                    calculateButton.Image = Image.FromStream(stream);
                }
            }
        }

        private void FormulaComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Show body fat panel only for Katch-McArdle formula
            bodyFatPanel.Visible = (formulaComboBox.SelectedItem?.ToString() == "Katch-McArdle");
        }

        private void CalculateButton_Click(object? sender, EventArgs e)
        {
            try
            {
                // Gather inputs
                if (genderComboBox.SelectedItem is not Gender gender) return;
                double weight = (double)weightNumericUpDown.Value;
                double height = (double)heightNumericUpDown.Value;
                int age = (int)ageNumericUpDown.Value;
                if (activityLevelComboBox.SelectedItem is not ActivityLevel activity) return;
                string? formula = formulaComboBox.SelectedItem?.ToString();

                // Basic validation
                if (weight <= 0 || height <= 0 || age <= 0)
                {
                    MessageBox.Show("Please enter valid age, weight, and height.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double bmr = 0;

                // Calculate BMR based on the selected formula
                switch (formula)
                {
                    case "Mifflin-St Jeor":
                        bmr = CalorieCalculator.CalculateMifflinStJeorBMR(gender, weight, height, age);
                        break;
                    case "Revised Harris-Benedict":
                        bmr = CalorieCalculator.CalculateRevisedHarrisBenedictBMR(gender, weight, height, age);
                        break;
                    case "Katch-McArdle":
                        double bodyFat = (double)bodyFatNumericUpDown.Value;
                        if (bodyFat <= 0)
                        {
                            MessageBox.Show("Please enter a valid body fat percentage for the Katch-McArdle formula.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        bmr = CalorieCalculator.CalculateKatchMcArdleBMR(weight, bodyFat);
                        break;
                }

                // Calculate TDEE
                double tdee = CalorieCalculator.CalculateTDEE(bmr, activity);

                // Display results
                bmrResultLabel.Text = $"BMR: {bmr:F2} calories/day";
                tdeeResultLabel.Text = $"TDEE: {tdee:F2} calories/day";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during calculation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditButton_Click(object? sender, EventArgs e)
        {
            if (historyListBox.SelectedItem is not LoggedFood selectedLoggedFood) return;

            // Create a prompt form similar to the add functionality
            Form prompt = new Form()
            {
                Width = 250,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Edit Weight",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 20, Top = 20, Text = "Weight (g):" };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 200, Text = selectedLoggedFood.Weight.ToString() };
            Button confirmationButton = new Button() { Text = "Ok", Left = 120, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmationButton.Click += (s, ev) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmationButton);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmationButton;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                if (double.TryParse(textBox.Text, out double newWeight) && newWeight > 0)
                {
                    Database.UpdateLogEntryWeight(selectedLoggedFood.Id, newWeight);
                    // Reload the log for the currently selected date in the picker
                    LoadHistoryLog(historyDateTimePicker.Value);
                }
                else
                {
                    MessageBox.Show("Please enter a valid weight.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SearchButton_Click(object? sender, EventArgs e)
        {
            var query = searchTextBox.Text;
            if (!string.IsNullOrWhiteSpace(query))
            {
                var foods = Database.SearchFood(query);
                foodListBox.DataSource = foods;
            }
        }

        private void AddButton_Click(object? sender, EventArgs e)
        {
            if (foodListBox.SelectedItem is not Food selectedFood) return;

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

        private void RemoveButton_Click(object? sender, EventArgs e)
        {
            if (dailyLogListBox.SelectedItem is not LoggedFood selectedLoggedFood) return;

            Database.RemoveFoodFromLog(selectedLoggedFood.Id);
            LoadDailyLog(DateTime.Today);
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

        private void HistoryDateTimePicker_ValueChanged(object? sender, EventArgs e)
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
