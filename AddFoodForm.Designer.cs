namespace CSharpProject
{
    partial class AddFoodForm
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
            this.foodNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.caloriesTextBox = new System.Windows.Forms.TextBox();
            this.proteinTextBox = new System.Windows.Forms.TextBox();
            this.carbsTextBox = new System.Windows.Forms.TextBox();
            this.fatTextBox = new System.Windows.Forms.TextBox();
            this.ironTextBox = new System.Windows.Forms.TextBox();
            this.vitaminCTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // foodNameTextBox
            //
            this.foodNameTextBox.Location = new System.Drawing.Point(150, 30);
            this.foodNameTextBox.Name = "foodNameTextBox";
            this.foodNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.foodNameTextBox.TabIndex = 0;
            //
            // categoryTextBox
            //
            this.categoryTextBox.Location = new System.Drawing.Point(150, 70);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(200, 22);
            this.categoryTextBox.TabIndex = 1;
            //
            // caloriesTextBox
            //
            this.caloriesTextBox.Location = new System.Drawing.Point(150, 110);
            this.caloriesTextBox.Name = "caloriesTextBox";
            this.caloriesTextBox.Size = new System.Drawing.Size(200, 22);
            this.caloriesTextBox.TabIndex = 2;
            //
            // proteinTextBox
            //
            this.proteinTextBox.Location = new System.Drawing.Point(150, 150);
            this.proteinTextBox.Name = "proteinTextBox";
            this.proteinTextBox.Size = new System.Drawing.Size(200, 22);
            this.proteinTextBox.TabIndex = 3;
            //
            // carbsTextBox
            //
            this.carbsTextBox.Location = new System.Drawing.Point(150, 190);
            this.carbsTextBox.Name = "carbsTextBox";
            this.carbsTextBox.Size = new System.Drawing.Size(200, 22);
            this.carbsTextBox.TabIndex = 4;
            //
            // fatTextBox
            //
            this.fatTextBox.Location = new System.Drawing.Point(150, 230);
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(200, 22);
            this.fatTextBox.TabIndex = 5;
            //
            // ironTextBox
            //
            this.ironTextBox.Location = new System.Drawing.Point(150, 270);
            this.ironTextBox.Name = "ironTextBox";
            this.ironTextBox.Size = new System.Drawing.Size(200, 22);
            this.ironTextBox.TabIndex = 6;
            //
            // vitaminCTextBox
            //
            this.vitaminCTextBox.Location = new System.Drawing.Point(150, 310);
            this.vitaminCTextBox.Name = "vitaminCTextBox";
            this.vitaminCTextBox.Size = new System.Drawing.Size(200, 22);
            this.vitaminCTextBox.TabIndex = 7;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.Text = "Food Name:";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.Text = "Category:";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.Text = "Calories:";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.Text = "Protein:";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.Text = "Carbs:";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.Text = "Fat:";
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.Text = "Iron:";
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.Text = "Vitamin C:";
            //
            // saveButton
            //
            this.saveButton.Location = new System.Drawing.Point(150, 350);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(200, 40);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            //
            // AddFoodForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vitaminCTextBox);
            this.Controls.Add(this.ironTextBox);
            this.Controls.Add(this.fatTextBox);
            this.Controls.Add(this.carbsTextBox);
            this.Controls.Add(this.proteinTextBox);
            this.Controls.Add(this.caloriesTextBox);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.foodNameTextBox);
            this.Name = "AddFoodForm";
            this.Text = "Add New Food";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox foodNameTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox caloriesTextBox;
        private System.Windows.Forms.TextBox proteinTextBox;
        private System.Windows.Forms.TextBox carbsTextBox;
        private System.Windows.Forms.TextBox fatTextBox;
        private System.Windows.Forms.TextBox ironTextBox;
        private System.Windows.Forms.TextBox vitaminCTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveButton;
    }
}
