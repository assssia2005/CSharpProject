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
            this.historyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.historyTotalCaloriesLabel = new System.Windows.Forms.Label();
            this.historyTotalProteinLabel = new System.Windows.Forms.Label();
            this.historyTotalCarbsLabel = new System.Windows.Forms.Label();
            this.historyTotalFatLabel = new System.Windows.Forms.Label();
            this.historyTotalIronLabel = new System.Windows.Forms.Label();
            this.historyTotalVitaminCLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            // searchTextBox, etc. for tabPage1
            // ... (All controls from the first tab)
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
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            this.tabPage2.UseVisualStyleBackColor = true;
            //
            // historyDateTimePicker, etc. for tabPage2
            // ... (All controls for the history tab)
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
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(626, 433);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Calorie Calculator";
            this.tabPage3.UseVisualStyleBackColor = true;
            //
            // All other control initializations...
            // ...
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

        // All controls are now properly declared
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
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label historyTotalCaloriesLabel;
        private System.Windows.Forms.Label historyTotalProteinLabel;
        private System.Windows.Forms.Label historyTotalCarbsLabel;
        private System.Windows.Forms.Label historyTotalFatLabel;
        private System.Windows.Forms.Label historyTotalIronLabel;
        private System.Windows.Forms.Label historyTotalVitaminCLabel;
        private System.Windows.Forms.TabPage tabPage3;
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
