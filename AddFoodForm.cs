using System;
using System.Windows.Forms;

namespace CSharpProject
{
    public partial class AddFoodForm : Form
    {
        public AddFoodForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Basic validation to ensure all fields are filled
            if (string.IsNullOrWhiteSpace(foodNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(categoryTextBox.Text) ||
                string.IsNullOrWhiteSpace(caloriesTextBox.Text) ||
                string.IsNullOrWhiteSpace(proteinTextBox.Text) ||
                string.IsNullOrWhiteSpace(carbsTextBox.Text) ||
                string.IsNullOrWhiteSpace(fatTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var food = new Food
                {
                    FoodName = foodNameTextBox.Text,
                    Category = categoryTextBox.Text,
                    Calories = double.Parse(caloriesTextBox.Text),
                    Protein = double.Parse(proteinTextBox.Text),
                    Carbs = double.Parse(carbsTextBox.Text),
                    Fat = double.Parse(fatTextBox.Text),
                    Iron = !string.IsNullOrWhiteSpace(ironTextBox.Text) ? double.Parse(ironTextBox.Text) : 0,
                    VitaminC = !string.IsNullOrWhiteSpace(vitaminCTextBox.Text) ? double.Parse(vitaminCTextBox.Text) : 0
                };

                Database.AddFood(food);
                MessageBox.Show("Food item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for nutritional values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
