using System.Diagnostics;

namespace CSharpProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            searchButton.Click += SearchButton_Click;
            addButton.Click += AddButton_Click;
            removeButton.Click += RemoveButton_Click;
            dailyLogListBox.DisplayMember = "FoodName";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var query = searchTextBox.Text;
            var foods = Database.SearchFood(query);
            foodListBox.DataSource = foods;
            foodListBox.DisplayMember = "FoodName";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var selectedFood = (Food)foodListBox.SelectedItem;
            if (selectedFood != null)
            {
                dailyLogListBox.Items.Add(selectedFood);
                UpdateTotals();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selectedFood = (Food)dailyLogListBox.SelectedItem;
            if (selectedFood != null)
            {
                dailyLogListBox.Items.Remove(selectedFood);
                UpdateTotals();
            }
        }

        private void UpdateTotals()
        {
            double totalCalories = 0;
            double totalProtein = 0;
            double totalCarbs = 0;
            double totalFat = 0;
            double totalIron = 0;
            double totalVitaminC = 0;

            foreach (Food food in dailyLogListBox.Items)
            {
                totalCalories += food.Calories;
                totalProtein += food.Protein;
                totalCarbs += food.Carbs;
                totalFat += food.Fat;
                totalIron += food.Iron;
                totalVitaminC += food.VitaminC;
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
