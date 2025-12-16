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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.formulaComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.weightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.activityLevelComboBox = new System.Windows.Forms.ComboBox();
            this.bodyFatPanel = new System.Windows.Forms.Panel();
            this.bodyFatNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.bmrResultLabel = new System.Windows.Forms.Label();
            this.tdeeResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bodyFatLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 461);
            this.tabControl1.TabIndex = 0;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nutrition Diary";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // tabPage2
            //
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tdeeResultLabel);
            this.tabPage2.Controls.Add(this.bmrResultLabel);
            this.tabPage2.Controls.Add(this.calculateButton);
            this.tabPage2.Controls.Add(this.bodyFatPanel);
            this.tabPage2.Controls.Add(this.activityLevelComboBox);
            this.tabPage2.Controls.Add(this.heightNumericUpDown);
            this.tabPage2.Controls.Add(this.weightNumericUpDown);
            this.tabPage2.Controls.Add(this.ageNumericUpDown);
            this.tabPage2.Controls.Add(this.genderComboBox);
            this.tabPage2.Controls.Add(this.formulaComboBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calorie Calculator";
            this.tabPage2.UseVisualStyleBackColor = true;
            //
            // searchTextBox
            //
            this.searchTextBox.Location = new System.Drawing.Point(8, 6);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(200, 23);
            this.searchTextBox.TabIndex = 0;
            //
            // searchButton
            //
            this.searchButton.Location = new System.Drawing.Point(214, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            //
            // foodListBox
            //
            this.foodListBox.FormattingEnabled = true;
            this.foodListBox.ItemHeight = 15;
            this.foodListBox.Location = new System.Drawing.Point(8, 35);
            this.foodListBox.Name = "foodListBox";
            this.foodListBox.Size = new System.Drawing.Size(281, 199);
            this.foodListBox.TabIndex = 2;
            //
            // addButton
            //
            this.addButton.Location = new System.Drawing.Point(8, 240);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(281, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add to Daily Log";
            this.addButton.UseVisualStyleBackColor = true;
            //
            // dailyLogListBox
            //
            this.dailyLogListBox.FormattingEnabled = true;
            this.dailyLogListBox.ItemHeight = 15;
            this.dailyLogListBox.Location = new System.Drawing.Point(314, 35);
            this.dailyLogListBox.Name = "dailyLogListBox";
            this.dailyLogListBox.Size = new System.Drawing.Size(281, 199);
            this.dailyLogListBox.TabIndex = 4;
            //
            // removeButton
            //
            this.removeButton.Location = new System.Drawing.Point(314, 240);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(281, 23);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove from Daily Log";
            this.removeButton.UseVisualStyleBackColor = true;
            //
            // totalCaloriesLabel
            //
            this.totalCaloriesLabel.AutoSize = true;
            this.totalCaloriesLabel.Location = new System.Drawing.Point(314, 277);
            this.totalCaloriesLabel.Name = "totalCaloriesLabel";
            this.totalCaloriesLabel.Size = new System.Drawing.Size(82, 15);
            this.totalCaloriesLabel.TabIndex = 6;
            this.totalCaloriesLabel.Text = "Total Calories: 0";
            //
            // totalProteinLabel
            //
            this.totalProteinLabel.AutoSize = true;
            this.totalProteinLabel.Location = new System.Drawing.Point(314, 301);
            this.totalProteinLabel.Name = "totalProteinLabel";
            this.totalProteinLabel.Size = new System.Drawing.Size(79, 15);
            this.totalProteinLabel.TabIndex = 7;
            this.totalProteinLabel.Text = "Total Protein: 0";
            //
            // totalCarbsLabel
            //
            this.totalCarbsLabel.AutoSize = true;
            this.totalCarbsLabel.Location = new System.Drawing.Point(314, 325);
            this.totalCarbsLabel.Name = "totalCarbsLabel";
            this.totalCarbsLabel.Size = new System.Drawing.Size(70, 15);
            this.totalCarbsLabel.TabIndex = 8;
            this.totalCarbsLabel.Text = "Total Carbs: 0";
            //
            // totalFatLabel
            //
            this.totalFatLabel.AutoSize = true;
            this.totalFatLabel.Location = new System.Drawing.Point(314, 349);
            this.totalFatLabel.Name = "totalFatLabel";
            this.totalFatLabel.Size = new System.Drawing.Size(55, 15);
            this.totalFatLabel.TabIndex = 9;
            this.totalFatLabel.Text = "Total Fat: 0";
            //
            // totalIronLabel
            //
            this.totalIronLabel.AutoSize = true;
            this.totalIronLabel.Location = new System.Drawing.Point(314, 373);
            this.totalIronLabel.Name = "totalIronLabel";
            this.totalIronLabel.Size = new System.Drawing.Size(59, 15);
            this.totalIronLabel.TabIndex = 10;
            this.totalIronLabel.Text = "Total Iron: 0";
            //
            // totalVitaminCLabel
            //
            this.totalVitaminCLabel.AutoSize = true;
            this.totalVitaminCLabel.Location = new System.Drawing.Point(314, 397);
            this.totalVitaminCLabel.Name = "totalVitaminCLabel";
            this.totalVitaminCLabel.Size = new System.Drawing.Size(91, 15);
            this.totalVitaminCLabel.TabIndex = 11;
            this.totalVitaminCLabel.Text = "Total Vitamin C: 0";
            //
            // formulaComboBox
            //
            this.formulaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formulaComboBox.FormattingEnabled = true;
            this.formulaComboBox.Location = new System.Drawing.Point(150, 20);
            this.formulaComboBox.Name = "formulaComboBox";
            this.formulaComboBox.Size = new System.Drawing.Size(200, 23);
            this.formulaComboBox.TabIndex = 0;
            //
            // genderComboBox
            //
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(150, 60);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 23);
            this.genderComboBox.TabIndex = 1;
            //
            // ageNumericUpDown
            //
            this.ageNumericUpDown.Location = new System.Drawing.Point(150, 100);
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.ageNumericUpDown.TabIndex = 2;
            //
            // weightNumericUpDown
            //
            this.weightNumericUpDown.DecimalPlaces = 1;
            this.weightNumericUpDown.Location = new System.Drawing.Point(150, 140);
            this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.weightNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.weightNumericUpDown.TabIndex = 3;
            //
            // heightNumericUpDown
            //
            this.heightNumericUpDown.DecimalPlaces = 1;
            this.heightNumericUpDown.Location = new System.Drawing.Point(150, 180);
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.heightNumericUpDown.TabIndex = 4;
            //
            // activityLevelComboBox
            //
            this.activityLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityLevelComboBox.FormattingEnabled = true;
            this.activityLevelComboBox.Location = new System.Drawing.Point(150, 260);
            this.activityLevelComboBox.Name = "activityLevelComboBox";
            this.activityLevelComboBox.Size = new System.Drawing.Size(200, 23);
            this.activityLevelComboBox.TabIndex = 6;
            //
            // bodyFatPanel
            //
            this.bodyFatPanel.Controls.Add(this.bodyFatLabel);
            this.bodyFatPanel.Controls.Add(this.bodyFatNumericUpDown);
            this.bodyFatPanel.Location = new System.Drawing.Point(20, 210);
            this.bodyFatPanel.Name = "bodyFatPanel";
            this.bodyFatPanel.Size = new System.Drawing.Size(330, 45);
            this.bodyFatPanel.TabIndex = 5;
            this.bodyFatPanel.Visible = false;
            //
            // bodyFatNumericUpDown
            //
            this.bodyFatNumericUpDown.DecimalPlaces = 1;
            this.bodyFatNumericUpDown.Location = new System.Drawing.Point(130, 10);
            this.bodyFatNumericUpDown.Name = "bodyFatNumericUpDown";
            this.bodyFatNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.bodyFatNumericUpDown.TabIndex = 0;
            //
            // calculateButton
            //
            this.calculateButton.Location = new System.Drawing.Point(150, 300);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 30);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            //
            // bmrResultLabel
            //
            this.bmrResultLabel.AutoSize = true;
            this.bmrResultLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bmrResultLabel.Location = new System.Drawing.Point(40, 350);
            this.bmrResultLabel.Name = "bmrResultLabel";
            this.bmrResultLabel.Size = new System.Drawing.Size(46, 17);
            this.bmrResultLabel.TabIndex = 8;
            this.bmrResultLabel.Text = "BMR: ";
            //
            // tdeeResultLabel
            //
            this.tdeeResultLabel.AutoSize = true;
            this.tdeeResultLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tdeeResultLabel.Location = new System.Drawing.Point(40, 380);
            this.tdeeResultLabel.Name = "tdeeResultLabel";
            this.tdeeResultLabel.Size = new System.Drawing.Size(49, 17);
            this.tdeeResultLabel.TabIndex = 9;
            this.tdeeResultLabel.Text = "TDEE: ";
            //
            // label1
            //
            this.label1.AutoSize = true; this.label1.Location = new System.Drawing.Point(40, 23); this.label1.Name = "label1"; this.label1.Size = new System.Drawing.Size(54, 15); this.label1.TabIndex = 10; this.label1.Text = "Formula:";
            this.label2.AutoSize = true; this.label2.Location = new System.Drawing.Point(40, 63); this.label2.Name = "label2"; this.label2.Size = new System.Drawing.Size(48, 15); this.label2.TabIndex = 11; this.label2.Text = "Gender:";
            this.label3.AutoSize = true; this.label3.Location = new System.Drawing.Point(40, 102); this.label3.Name = "label3"; this.label3.Size = new System.Drawing.Size(31, 15); this.label3.TabIndex = 12; this.label3.Text = "Age:";
            this.label4.AutoSize = true; this.label4.Location = new System.Drawing.Point(40, 142); this.label4.Name = "label4"; this.label4.Size = new System.Drawing.Size(68, 15); this.label4.TabIndex = 13; this.label4.Text = "Weight (kg):";
            this.label5.AutoSize = true; this.label5.Location = new System.Drawing.Point(40, 182); this.label5.Name = "label5"; this.label5.Size = new System.Drawing.Size(70, 15); this.label5.TabIndex = 14; this.label5.Text = "Height (cm):";
            this.label6.AutoSize = true; this.label6.Location = new System.Drawing.Point(40, 263); this.label6.Name = "label6"; this.label6.Size = new System.Drawing.Size(80, 15); this.label6.TabIndex = 15; this.label6.Text = "Activity Level:";
            this.bodyFatLabel.AutoSize = true; this.bodyFatLabel.Location = new System.Drawing.Point(20, 12); this.bodyFatLabel.Name = "bodyFatLabel"; this.bodyFatLabel.Size = new System.Drawing.Size(72, 15); this.bodyFatLabel.TabIndex = 16; this.bodyFatLabel.Text = "Body Fat (%):";
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker historyDateTimePicker;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.Label historyTotalCaloriesLabel;
        private System.Windows.Forms.Label historyTotalProteinLabel;
        private System.Windows.Forms.Label historyTotalCarbsLabel;
        private System.Windows.Forms.Label historyTotalFatLabel;
        private System.Windows.Forms.Label historyTotalIronLabel;
        private System.Windows.Forms.Label historyTotalVitaminCLabel;
        private System.Windows.Forms.Button editButton;
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
