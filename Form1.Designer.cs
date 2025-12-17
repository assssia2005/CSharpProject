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
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            //
            // tabPage1
            //
            this.tabPage1.BackColor = System.Drawing.Color.White;
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
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Text = "Nutrition Diary";
            //
            // searchTextBox
            //
            this.searchTextBox.Location = new System.Drawing.Point(13, 16);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(200, 30);
            //
            // searchButton
            //
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(219, 16);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 30);
            this.searchButton.Text = "Search";
            //
            // foodListBox
            //
            this.foodListBox.Location = new System.Drawing.Point(13, 52);
            this.foodListBox.Name = "foodListBox";
            this.foodListBox.Size = new System.Drawing.Size(286, 184);
            //
            // addButton
            //
            this.addButton.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(13, 242);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(286, 40);
            this.addButton.Text = "Add to Daily Log";
            //
            // dailyLogListBox
            //
            this.dailyLogListBox.Location = new System.Drawing.Point(320, 52);
            this.dailyLogListBox.Name = "dailyLogListBox";
            this.dailyLogListBox.Size = new System.Drawing.Size(286, 184);
            //
            // removeButton
            //
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(320, 242);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(286, 40);
            this.removeButton.Text = "Remove from Daily Log";
            //
            // totalCaloriesLabel
            //
            this.totalCaloriesLabel.Location = new System.Drawing.Point(320, 280);
            this.totalCaloriesLabel.Name = "totalCaloriesLabel";
            this.totalCaloriesLabel.Text = "Total Calories: 0";
            this.totalCaloriesLabel.AutoSize = true;
            //
            // totalProteinLabel
            //
            this.totalProteinLabel.Location = new System.Drawing.Point(320, 304);
            this.totalProteinLabel.Name = "totalProteinLabel";
            this.totalProteinLabel.Text = "Total Protein: 0";
            this.totalProteinLabel.AutoSize = true;
            //
            // totalCarbsLabel
            //
            this.totalCarbsLabel.Location = new System.Drawing.Point(320, 328);
            this.totalCarbsLabel.Name = "totalCarbsLabel";
            this.totalCarbsLabel.Text = "Total Carbs: 0";
            this.totalCarbsLabel.AutoSize = true;
            //
            // totalFatLabel
            //
            this.totalFatLabel.Location = new System.Drawing.Point(320, 352);
            this.totalFatLabel.Name = "totalFatLabel";
            this.totalFatLabel.Text = "Total Fat: 0";
            this.totalFatLabel.AutoSize = true;
            //
            // totalIronLabel
            //
            this.totalIronLabel.Location = new System.Drawing.Point(320, 376);
            this.totalIronLabel.Name = "totalIronLabel";
            this.totalIronLabel.Text = "Total Iron: 0";
            this.totalIronLabel.AutoSize = true;
            //
            // totalVitaminCLabel
            //
            this.totalVitaminCLabel.Location = new System.Drawing.Point(320, 400);
            this.totalVitaminCLabel.Name = "totalVitaminCLabel";
            this.totalVitaminCLabel.Text = "Total Vitamin C: 0";
            this.totalVitaminCLabel.AutoSize = true;
            //
            // tabPage2
            //
            this.tabPage2.BackColor = System.Drawing.Color.White;
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
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Text = "History";
            //
            // historyDateTimePicker
            //
            this.historyDateTimePicker.Location = new System.Drawing.Point(13, 16);
            this.historyDateTimePicker.Name = "historyDateTimePicker";
            this.historyDateTimePicker.Size = new System.Drawing.Size(250, 30);
            //
            // historyListBox
            //
            this.historyListBox.Location = new System.Drawing.Point(13, 52);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(593, 184);
            //
            // editButton
            //
            this.editButton.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(456, 242);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(150, 40);
            this.editButton.Text = "Edit Selected";
            //
            // historyTotalCaloriesLabel
            //
            this.historyTotalCaloriesLabel.Location = new System.Drawing.Point(13, 248);
            this.historyTotalCaloriesLabel.Name = "historyTotalCaloriesLabel";
            this.historyTotalCaloriesLabel.Text = "Total Calories: 0";
            this.historyTotalCaloriesLabel.AutoSize = true;
            //
            // historyTotalProteinLabel
            //
            this.historyTotalProteinLabel.Location = new System.Drawing.Point(13, 272);
            this.historyTotalProteinLabel.Name = "historyTotalProteinLabel";
            this.historyTotalProteinLabel.Text = "Total Protein: 0";
            this.historyTotalProteinLabel.AutoSize = true;
            //
            // historyTotalCarbsLabel
            //
            this.historyTotalCarbsLabel.Location = new System.Drawing.Point(13, 296);
            this.historyTotalCarbsLabel.Name = "historyTotalCarbsLabel";
            this.historyTotalCarbsLabel.Text = "Total Carbs: 0";
            this.historyTotalCarbsLabel.AutoSize = true;
            //
            // historyTotalFatLabel
            //
            this.historyTotalFatLabel.Location = new System.Drawing.Point(13, 320);
            this.historyTotalFatLabel.Name = "historyTotalFatLabel";
            this.historyTotalFatLabel.Text = "Total Fat: 0";
            this.historyTotalFatLabel.AutoSize = true;
            //
            // historyTotalIronLabel
            //
            this.historyTotalIronLabel.Location = new System.Drawing.Point(13, 344);
            this.historyTotalIronLabel.Name = "historyTotalIronLabel";
            this.historyTotalIronLabel.Text = "Total Iron: 0";
            this.historyTotalIronLabel.AutoSize = true;
            //
            // historyTotalVitaminCLabel
            //
            this.historyTotalVitaminCLabel.Location = new System.Drawing.Point(13, 368);
            this.historyTotalVitaminCLabel.Name = "historyTotalVitaminCLabel";
            this.historyTotalVitaminCLabel.Text = "Total Vitamin C: 0";
            this.historyTotalVitaminCLabel.AutoSize = true;
            //
            // tabPage3
            //
            this.tabPage3.BackColor = System.Drawing.Color.White;
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
            this.tabPage3.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage3.Text = "Calorie Calculator";
            //
            // formulaComboBox
            //
            this.formulaComboBox.Location = new System.Drawing.Point(160, 26);
            this.formulaComboBox.Name = "formulaComboBox";
            this.formulaComboBox.Size = new System.Drawing.Size(200, 31);
            //
            // genderComboBox
            //
            this.genderComboBox.Location = new System.Drawing.Point(160, 66);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(200, 31);
            //
            // ageNumericUpDown
            //
            this.ageNumericUpDown.Location = new System.Drawing.Point(160, 106);
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(200, 30);
            //
            // weightNumericUpDown
            //
            this.weightNumericUpDown.Location = new System.Drawing.Point(160, 146);
            this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.weightNumericUpDown.Size = new System.Drawing.Size(200, 30);
            //
            // heightNumericUpDown
            //
            this.heightNumericUpDown.Location = new System.Drawing.Point(160, 186);
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(200, 30);
            //
            // activityLevelComboBox
            //
            this.activityLevelComboBox.Location = new System.Drawing.Point(160, 266);
            this.activityLevelComboBox.Name = "activityLevelComboBox";
            this.activityLevelComboBox.Size = new System.Drawing.Size(200, 31);
            //
            // bodyFatPanel
            //
            this.bodyFatPanel.Location = new System.Drawing.Point(30, 216);
            this.bodyFatPanel.Name = "bodyFatPanel";
            this.bodyFatPanel.Size = new System.Drawing.Size(330, 44);
            this.bodyFatPanel.Controls.Add(this.bodyFatLabel);
            this.bodyFatPanel.Controls.Add(this.bodyFatNumericUpDown);
            //
            // bodyFatNumericUpDown
            //
            this.bodyFatNumericUpDown.Location = new System.Drawing.Point(130, 10);
            this.bodyFatNumericUpDown.Name = "bodyFatNumericUpDown";
            this.bodyFatNumericUpDown.Size = new System.Drawing.Size(200, 30);
            //
            // calculateButton
            //
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.calculateButton.FlatAppearance.BorderSize = 0;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(160, 316);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(200, 40);
            this.calculateButton.Text = "Calculate";
            this.calculateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calculateButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            //
            // bmrResultLabel
            //
            this.bmrResultLabel.Location = new System.Drawing.Point(50, 376);
            this.bmrResultLabel.Name = "bmrResultLabel";
            this.bmrResultLabel.Text = "BMR: ";
            this.bmrResultLabel.AutoSize = true;
            //
            // tdeeResultLabel
            //
            this.tdeeResultLabel.Location = new System.Drawing.Point(50, 406);
            this.tdeeResultLabel.Name = "tdeeResultLabel";
            this.tdeeResultLabel.Text = "TDEE: ";
            this.tdeeResultLabel.AutoSize = true;
            //
            // label1
            //
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Name = "label1";
            this.label1.Text = "Formula:";
            this.label1.AutoSize = true;
            //
            // label2
            //
            this.label2.Location = new System.Drawing.Point(50, 69);
            this.label2.Name = "label2";
            this.label2.Text = "Gender:";
            this.label2.AutoSize = true;
            //
            // label3
            //
            this.label3.Location = new System.Drawing.Point(50, 108);
            this.label3.Name = "label3";
            this.label3.Text = "Age:";
            this.label3.AutoSize = true;
            //
            // label4
            //
            this.label4.Location = new System.Drawing.Point(50, 148);
            this.label4.Name = "label4";
            this.label4.Text = "Weight (kg):";
            this.label4.AutoSize = true;
            //
            // label5
            //
            this.label5.Location = new System.Drawing.Point(50, 188);
            this.label5.Name = "label5";
            this.label5.Text = "Height (cm):";
            this.label5.AutoSize = true;
            //
            // label6
            //
            this.label6.Location = new System.Drawing.Point(50, 269);
            this.label6.Name = "label6";
            this.label6.Text = "Activity Level:";
            this.label6.AutoSize = true;
            //
            // bodyFatLabel
            //
            this.bodyFatLabel.Location = new System.Drawing.Point(20, 12);
            this.bodyFatLabel.Name = "bodyFatLabel";
            this.bodyFatLabel.Text = "Body Fat (%):";
            this.bodyFatLabel.AutoSize = true;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
