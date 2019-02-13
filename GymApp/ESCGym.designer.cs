namespace GymApp
{
    partial class ESCGym
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.v_Calculate = new System.Windows.Forms.Button();
            this.v_Exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.v_Target = new System.Windows.Forms.Label();
            this.v_Category = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.v_DailyKilocalorieIntake = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.v_BMI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.v_BMR = new System.Windows.Forms.TextBox();
            this.v_ExerciseLevel = new System.Windows.Forms.ListBox();
            this.v_Help = new System.Windows.Forms.Button();
            this.v_Print = new System.Windows.Forms.Button();
            this.v_Age = new System.Windows.Forms.NumericUpDown();
            this.v_Weight = new System.Windows.Forms.NumericUpDown();
            this.v_Height = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.v_Male = new System.Windows.Forms.RadioButton();
            this.v_Female = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Height)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weight";
            // 
            // v_Calculate
            // 
            this.v_Calculate.Location = new System.Drawing.Point(374, 485);
            this.v_Calculate.Name = "v_Calculate";
            this.v_Calculate.Size = new System.Drawing.Size(75, 23);
            this.v_Calculate.TabIndex = 8;
            this.v_Calculate.Text = "Calculate";
            this.v_Calculate.UseVisualStyleBackColor = true;
            this.v_Calculate.Click += new System.EventHandler(this.v_Calculate_Click);
            // 
            // v_Exit
            // 
            this.v_Exit.Location = new System.Drawing.Point(455, 485);
            this.v_Exit.Name = "v_Exit";
            this.v_Exit.Size = new System.Drawing.Size(75, 23);
            this.v_Exit.TabIndex = 10;
            this.v_Exit.Text = "Exit";
            this.v_Exit.UseVisualStyleBackColor = true;
            this.v_Exit.Click += new System.EventHandler(this.v_Exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Exercise Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Years";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Centimeters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kilograms";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.v_Target);
            this.groupBox1.Controls.Add(this.v_Category);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.v_DailyKilocalorieIntake);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.v_BMI);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.v_BMR);
            this.groupBox1.Location = new System.Drawing.Point(46, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 159);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // v_Target
            // 
            this.v_Target.AutoSize = true;
            this.v_Target.Location = new System.Drawing.Point(302, 106);
            this.v_Target.Name = "v_Target";
            this.v_Target.Size = new System.Drawing.Size(38, 13);
            this.v_Target.TabIndex = 7;
            this.v_Target.Text = "Target";
            // 
            // v_Category
            // 
            this.v_Category.AutoSize = true;
            this.v_Category.Location = new System.Drawing.Point(302, 66);
            this.v_Category.Name = "v_Category";
            this.v_Category.Size = new System.Drawing.Size(49, 13);
            this.v_Category.TabIndex = 6;
            this.v_Category.Text = "Category";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Recommended Daily Kilocalorie Intake";
            // 
            // v_DailyKilocalorieIntake
            // 
            this.v_DailyKilocalorieIntake.Location = new System.Drawing.Point(196, 103);
            this.v_DailyKilocalorieIntake.Name = "v_DailyKilocalorieIntake";
            this.v_DailyKilocalorieIntake.Size = new System.Drawing.Size(100, 20);
            this.v_DailyKilocalorieIntake.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "BMI";
            // 
            // v_BMI
            // 
            this.v_BMI.Location = new System.Drawing.Point(196, 63);
            this.v_BMI.Name = "v_BMI";
            this.v_BMI.Size = new System.Drawing.Size(100, 20);
            this.v_BMI.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "BMR";
            // 
            // v_BMR
            // 
            this.v_BMR.Location = new System.Drawing.Point(196, 25);
            this.v_BMR.Name = "v_BMR";
            this.v_BMR.Size = new System.Drawing.Size(100, 20);
            this.v_BMR.TabIndex = 0;
            // 
            // v_ExerciseLevel
            // 
            this.v_ExerciseLevel.FormattingEnabled = true;
            this.v_ExerciseLevel.Items.AddRange(new object[] {
            "Sedentary",
            "Light (1-3 days per week)",
            "Moderate (3-5 days per week)",
            "Heavy (6-7 days per week)",
            "Very Heavy (Twice per day or more)"});
            this.v_ExerciseLevel.Location = new System.Drawing.Point(134, 206);
            this.v_ExerciseLevel.Name = "v_ExerciseLevel";
            this.v_ExerciseLevel.Size = new System.Drawing.Size(188, 82);
            this.v_ExerciseLevel.TabIndex = 17;
            // 
            // v_Help
            // 
            this.v_Help.Location = new System.Drawing.Point(293, 485);
            this.v_Help.Name = "v_Help";
            this.v_Help.Size = new System.Drawing.Size(75, 23);
            this.v_Help.TabIndex = 18;
            this.v_Help.Text = "Help";
            this.v_Help.UseVisualStyleBackColor = true;
            this.v_Help.Visible = false;
            this.v_Help.Click += new System.EventHandler(this.v_Help_Click);
            // 
            // v_Print
            // 
            this.v_Print.Enabled = false;
            this.v_Print.Location = new System.Drawing.Point(212, 485);
            this.v_Print.Name = "v_Print";
            this.v_Print.Size = new System.Drawing.Size(75, 23);
            this.v_Print.TabIndex = 19;
            this.v_Print.Text = "Print";
            this.v_Print.UseVisualStyleBackColor = true;
            this.v_Print.Visible = false;
            this.v_Print.Click += new System.EventHandler(this.v_Print_Click);
            // 
            // v_Age
            // 
            this.v_Age.Location = new System.Drawing.Point(132, 78);
            this.v_Age.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.v_Age.Name = "v_Age";
            this.v_Age.Size = new System.Drawing.Size(54, 20);
            this.v_Age.TabIndex = 20;
            this.v_Age.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // v_Weight
            // 
            this.v_Weight.Location = new System.Drawing.Point(132, 160);
            this.v_Weight.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.v_Weight.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.v_Weight.Name = "v_Weight";
            this.v_Weight.Size = new System.Drawing.Size(54, 20);
            this.v_Weight.TabIndex = 21;
            this.v_Weight.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // v_Height
            // 
            this.v_Height.Location = new System.Drawing.Point(132, 121);
            this.v_Height.Maximum = new decimal(new int[] {
            210,
            0,
            0,
            0});
            this.v_Height.Minimum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.v_Height.Name = "v_Height";
            this.v_Height.Size = new System.Drawing.Size(54, 20);
            this.v_Height.TabIndex = 22;
            this.v_Height.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.v_Male);
            this.groupBox2.Controls.Add(this.v_Female);
            this.groupBox2.Location = new System.Drawing.Point(330, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 76);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Gender ";
            // 
            // v_Male
            // 
            this.v_Male.AutoSize = true;
            this.v_Male.Location = new System.Drawing.Point(16, 42);
            this.v_Male.Name = "v_Male";
            this.v_Male.Size = new System.Drawing.Size(48, 17);
            this.v_Male.TabIndex = 26;
            this.v_Male.TabStop = true;
            this.v_Male.Text = "Male";
            this.v_Male.UseVisualStyleBackColor = true;
            // 
            // v_Female
            // 
            this.v_Female.AutoSize = true;
            this.v_Female.Checked = true;
            this.v_Female.Location = new System.Drawing.Point(16, 19);
            this.v_Female.Name = "v_Female";
            this.v_Female.Size = new System.Drawing.Size(59, 17);
            this.v_Female.TabIndex = 27;
            this.v_Female.TabStop = true;
            this.v_Female.Text = "Female";
            this.v_Female.UseVisualStyleBackColor = true;
            // 
            // ESCGym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 529);
            this.Controls.Add(this.v_Height);
            this.Controls.Add(this.v_Weight);
            this.Controls.Add(this.v_Age);
            this.Controls.Add(this.v_Print);
            this.Controls.Add(this.v_ExerciseLevel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.v_Exit);
            this.Controls.Add(this.v_Calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v_Help);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ESCGym";
            this.Text = "East Surrey Gym";
            this.Load += new System.EventHandler(this.ESCGym_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Height)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button v_Calculate;
        private System.Windows.Forms.Button v_Exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox v_BMR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox v_BMI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox v_DailyKilocalorieIntake;
        private System.Windows.Forms.Label v_Category;
        private System.Windows.Forms.ListBox v_ExerciseLevel;
        private System.Windows.Forms.Button v_Help;
        private System.Windows.Forms.Button v_Print;
        private System.Windows.Forms.NumericUpDown v_Age;
        private System.Windows.Forms.NumericUpDown v_Weight;
        private System.Windows.Forms.NumericUpDown v_Height;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton v_Male;
        private System.Windows.Forms.RadioButton v_Female;
        private System.Windows.Forms.Label v_Target;
    }
}