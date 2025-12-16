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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(618, 450);
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
            this.tabPage1.Size = new System.Drawing.Size(610, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nutrition Diary";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // tabPage2
            //
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(610, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Page 2";
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
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Nutrition Diary";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}
