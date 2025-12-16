namespace CSharpProject
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();

            // Controls for TabPage1 (Nutrition Diary)
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.foodListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.dailyLogListBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.totalCaloriesLabel = new System.Windows.Forms.Label();
            this.totalProteinLabel = new System.Windows.Forms.Label();
            this.totalCarbsLabel = new System.Windows.Forms.Label();
            this.totalFatLabel = new System.Windows.Forms.Label();
            this.totalIronLabel = new System.Windows.Forms.Label();
            this.totalVitaminCLabel = new System.Windows.Forms.Label();

            // Controls for TabPage2 (History)
            this.historyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.historyTotalCaloriesLabel = new System.Windows.Forms.Label();
            this.historyTotalProteinLabel = new System.Windows.Forms.Label();
            this.historyTotalCarbsLabel = new System.Windows.Forms.Label();
            this.historyTotalFatLabel = new System.Windows.Forms.Label();
            this.historyTotalIronLabel = new System.Windows.Forms.Label();
            this.historyTotalVitaminCLabel = new System.Windows.Forms.Label();

            // Controls for TabPage3 (Calorie Calculator)
            this.formulaComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.weightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.activityLevelComboBox = new System.Windows.Forms.ComboBox();
            this.bodyFatPanel = new System.Windows.Forms.Panel();
            this.bodyFatNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bodyFatLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.bmrResultLabel = new System.Windows.Forms.Label();
            this.tdeeResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();

            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            this.bodyFatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bodyFatNumericUpDown)).BeginInit();
            this.SuspendLayout();

            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            //
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.searchTextBox);
            this.tabPage1.Controls.Add(this.searchButton);
            this.tabPage1.Controls.Add(this.foodListBox);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Controls.Add(this.dailyLogListBox);
            this.tabPage1.Controls.Add(this.removeButton);
            this.tabPage1.Controls.Add(this.totalCaloriesLabel);
            this.tabPage1.Controls.Add(this.totalProteinLabel);
            this.tabPage1.Controls.Add(this.totalCarbsLabel);
            this.tabPage1.Controls.Add(this.totalFatLabel);
            this.tabPage1.Controls.Add(this.totalIronLabel);
            this.tabPage1.Controls.Add(this.totalVitaminCLabel);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Text = "Nutrition Diary";
            // ... (rest of tabPage1 properties)
            //
            // All other controls for tabPage1...
            //
            this.searchTextBox.Location = new System.Drawing.Point(8, 6); this.searchTextBox.Name = "searchTextBox";
            this.searchButton.Location = new System.Drawing.Point(214, 6); this.searchButton.Name = "searchButton"; this.searchButton.Text = "Search";
            this.foodListBox.Location = new System.Drawing.Point(8, 35); this.foodListBox.Name = "foodListBox";
            this.addButton.Location = new System.Drawing.Point(8, 240); this.addButton.Name = "addButton"; this.addButton.Text = "Add to Daily Log";
            this.dailyLogListBox.Location = new System.Drawing.Point(314, 35); this.dailyLogListBox.Name = "dailyLogListBox";
            this.removeButton.Location = new System.Drawing.Point(314, 240); this.removeButton.Name = "removeButton"; this.removeButton.Text = "Remove from Daily Log";
            this.totalCaloriesLabel.Location = new System.Drawing.Point(314, 277); this.totalCaloriesLabel.Name = "totalCaloriesLabel"; this.totalCaloriesLabel.Text = "Total Calories: 0"; this.totalCaloriesLabel.AutoSize = true;
            this.totalProteinLabel.Location = new System.Drawing.Point(314, 301); this.totalProteinLabel.Name = "totalProteinLabel"; this.totalProteinLabel.Text = "Total Protein: 0"; this.totalProteinLabel.AutoSize = true;
            this.totalCarbsLabel.Location = new System.Drawing.Point(314, 325); this.totalCarbsLabel.Name = "totalCarbsLabel"; this.totalCarbsLabel.Text = "Total Carbs: 0"; this.totalCarbsLabel.AutoSize = true;
            this.totalFatLabel.Location = new System.Drawing.Point(314, 349); this.totalFatLabel.Name = "totalFatLabel"; this.totalFatLabel.Text = "Total Fat: 0"; this.totalFatLabel.AutoSize = true;
            this.totalIronLabel.Location = new System.Drawing.Point(314, 373); this.totalIronLabel.Name = "totalIronLabel"; this.totalIronLabel.Text = "Total Iron: 0"; this.totalIronLabel.AutoSize = true;
            this.totalVitaminCLabel.Location = new System.Drawing.Point(314, 397); this.totalVitaminCLabel.Name = "totalVitaminCLabel"; this.totalVitaminCLabel.Text = "Total Vitamin C: 0"; this.totalVitaminCLabel.AutoSize = true;
            //
            // tabPage2
            //
            this.tabPage2.Controls.Add(this.historyDateTimePicker);
            this.tabPage2.Controls.Add(this.historyListBox);
            this.tabPage2.Controls.Add(this.editButton);
            this.tabPage2.Controls.Add(this.historyTotalCaloriesLabel);
            this.tabPage2.Controls.Add(this.historyTotalProteinLabel);
            this.tabPage2.Controls.Add(this.historyTotalCarbsLabel);
            this.tabPage2.Controls.Add(this.historyTotalFatLabel);
            this.tabPage2.Controls.Add(this.historyTotalIronLabel);
            this.tabPage2.Controls.Add(this.historyTotalVitaminCLabel);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Text = "History";
            //
            // All other controls for tabPage2...
            //
            this.historyDateTimePicker.Location = new System.Drawing.Point(8, 6); this.historyDateTimePicker.Name = "historyDateTimePicker";
            this.historyListBox.Location = new System.Drawing.Point(8, 35); this.historyListBox.Name = "historyListBox";
            this.editButton.Location = new System.Drawing.Point(490, 240); this.editButton.Name = "editButton"; this.editButton.Text = "Edit Selected";
            this.historyTotalCaloriesLabel.Location = new System.Drawing.Point(8, 248); this.historyTotalCaloriesLabel.Name = "historyTotalCaloriesLabel"; this.historyTotalCaloriesLabel.Text = "Total Calories: 0"; this.historyTotalCaloriesLabel.AutoSize = true;
            this.historyTotalProteinLabel.Location = new System.Drawing.Point(8, 272); this.historyTotalProteinLabel.Name = "historyTotalProteinLabel"; this.historyTotalProteinLabel.Text = "Total Protein: 0"; this.historyTotalProteinLabel.AutoSize = true;
            this.historyTotalCarbsLabel.Location = new System.Drawing.Point(8, 296); this.historyTotalCarbsLabel.Name = "historyTotalCarbsLabel"; this.historyTotalCarbsLabel.Text = "Total Carbs: 0"; this.historyTotalCarbsLabel.AutoSize = true;
            this.historyTotalFatLabel.Location = new System.Drawing.Point(8, 320); this.historyTotalFatLabel.Name = "historyTotalFatLabel"; this.historyTotalFatLabel.Text = "Total Fat: 0"; this.historyTotalFatLabel.AutoSize = true;
            this.historyTotalIronLabel.Location = new System.Drawing.Point(8, 344); this.historyTotalIronLabel.Name = "historyTotalIronLabel"; this.historyTotalIronLabel.Text = "Total Iron: 0"; this.historyTotalIronLabel.AutoSize = true;
            this.historyTotalVitaminCLabel.Location = new System.Drawing.Point(8, 368); this.historyTotalVitaminCLabel.Name = "historyTotalVitaminCLabel"; this.historyTotalVitaminCLabel.Text = "Total Vitamin C: 0"; this.historyTotalVitaminCLabel.AutoSize = true;
            //
            // tabPage3
            //
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.tdeeResultLabel);
            this.tabPage3.Controls.Add(this.bmrResultLabel);
            this.tabPage3.Controls.Add(this.calculateButton);
            this.tabPage3.Controls.Add(this.bodyFatPanel);
            this.tabPage3.Controls.Add(this.activityLevelComboBox);
            this.tabPage3.Controls.Add(this.heightNumericUpDown);
            this.tabPage3.Controls.Add(this.weightNumericUpDown);
            this.tabPage3.Controls.Add(this.ageNumericUpDown);
            this.tabPage3.Controls.Add(this.genderComboBox);
            this.tabPage3.Controls.Add(this.formulaComboBox);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Text = "Calorie Calculator";
            //
            // All other controls for tabPage3...
            //
            this.formulaComboBox.Location = new System.Drawing.Point(150, 20); this.formulaComboBox.Name = "formulaComboBox";
            this.genderComboBox.Location = new System.Drawing.Point(150, 60); this.genderComboBox.Name = "genderComboBox";
            this.ageNumericUpDown.Location = new System.Drawing.Point(150, 100); this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.weightNumericUpDown.Location = new System.Drawing.Point(150, 140); this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.heightNumericUpDown.Location = new System.Drawing.Point(150, 180); this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.activityLevelComboBox.Location = new System.Drawing.Point(150, 260); this.activityLevelComboBox.Name = "activityLevelComboBox";
            this.bodyFatPanel.Location = new System.Drawing.Point(20, 210); this.bodyFatPanel.Name = "bodyFatPanel";
            this.bodyFatPanel.Controls.Add(this.bodyFatLabel); this.bodyFatPanel.Controls.Add(this.bodyFatNumericUpDown);
            this.bodyFatNumericUpDown.Location = new System.Drawing.Point(130, 10); this.bodyFatNumericUpDown.Name = "bodyFatNumericUpDown";
            this.calculateButton.Location = new System.Drawing.Point(150, 300); this.calculateButton.Name = "calculateButton"; this.calculateButton.Text = "Calculate";
            this.bmrResultLabel.Location = new System.Drawing.Point(40, 350); this.bmrResultLabel.Name = "bmrResultLabel"; this.bmrResultLabel.Text = "BMR: "; this.bmrResultLabel.AutoSize = true;
            this.tdeeResultLabel.Location = new System.Drawing.Point(40, 380); this.tdeeResultLabel.Name = "tdeeResultLabel"; this.tdeeResultLabel.Text = "TDEE: "; this.tdeeResultLabel.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23); this.label1.Name = "label1"; this.label1.Text = "Formula:"; this.label1.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 63); this.label2.Name = "label2"; this.label2.Text = "Gender:"; this.label2.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 102); this.label3.Name = "label3"; this.label3.Text = "Age:"; this.label3.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 142); this.label4.Name = "label4"; this.label4.Text = "Weight (kg):"; this.label4.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 182); this.label5.Name = "label5"; this.label5.Text = "Height (cm):"; this.label5.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 263); this.label6.Name = "label6"; this.label6.Text = "Activity Level:"; this.label6.AutoSize = true;
            this.bodyFatLabel.Location = new System.Drawing.Point(20, 12); this.bodyFatLabel.Name = "bodyFatLabel"; this.bodyFatLabel.Text = "Body Fat (%):"; this.bodyFatLabel.AutoSize = true;
            //
            // Form1
            //
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Nutrition Diary";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            this.bodyFatPanel.ResumeLayout(false);
            this.bodyFatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bodyFatNumericUpDown)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox foodListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox dailyLogListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label totalCaloriesLabel;
        private System.Windows.Forms.Label totalProteinLabel;
        private System.Windows.Forms.Label totalCarbsLabel;
        private System.Windows.Forms.Label totalFatLabel;
        private System.Windows.Forms.Label totalIronLabel;
        private System.Windows.Forms.Label totalVitaminCLabel;
        private System.Windows.Forms.DateTimePicker historyDateTimePicker;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label historyTotalCaloriesLabel;
        private System.Windows.Forms.Label historyTotalProteinLabel;
        private System.Windows.Forms.Label historyTotalCarbsLabel;
        private System.Windows.Forms.Label historyTotalFatLabel;
        private System.Windows.Forms.Label historyTotalIronLabel;
        private System.Windows.Forms.Label historyTotalVitaminCLabel;
        private System.Windows.Forms.ComboBox formulaComboBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.NumericUpDown ageNumericUpDown;
        private System.Windows.Forms.NumericUpDown weightNumericUpDown;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.ComboBox activityLevelComboBox;
        private System.Windows.Forms.Panel bodyFatPanel;
        private System.Windows.Forms.NumericUpDown bodyFatNumericUpDown;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label bmrResultLabel;
        private System.Windows.Forms.Label tdeeResultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label bodyFatLabel;
    }
}
