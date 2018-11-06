namespace GymApp
{
    partial class EnteringDetails
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
            this.v_Surname = new System.Windows.Forms.TextBox();
            this.v_Firstname = new System.Windows.Forms.TextBox();
            this.v_Address = new System.Windows.Forms.TextBox();
            this.v_Phone = new System.Windows.Forms.TextBox();
            this.v_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.v_OK = new System.Windows.Forms.Button();
            this.v_Help = new System.Windows.Forms.Button();
            this.v_Exit = new System.Windows.Forms.Button();
            this.v_GymMember = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.v_Title = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // v_Surname
            // 
            this.v_Surname.Location = new System.Drawing.Point(121, 115);
            this.v_Surname.Name = "v_Surname";
            this.v_Surname.Size = new System.Drawing.Size(284, 20);
            this.v_Surname.TabIndex = 0;
            // 
            // v_Firstname
            // 
            this.v_Firstname.Location = new System.Drawing.Point(121, 75);
            this.v_Firstname.Name = "v_Firstname";
            this.v_Firstname.Size = new System.Drawing.Size(284, 20);
            this.v_Firstname.TabIndex = 1;
            // 
            // v_Address
            // 
            this.v_Address.Location = new System.Drawing.Point(121, 153);
            this.v_Address.Name = "v_Address";
            this.v_Address.Size = new System.Drawing.Size(284, 20);
            this.v_Address.TabIndex = 2;
            // 
            // v_Phone
            // 
            this.v_Phone.Location = new System.Drawing.Point(121, 233);
            this.v_Phone.Name = "v_Phone";
            this.v_Phone.Size = new System.Drawing.Size(161, 20);
            this.v_Phone.TabIndex = 3;
            // 
            // v_Email
            // 
            this.v_Email.Location = new System.Drawing.Point(121, 193);
            this.v_Email.Name = "v_Email";
            this.v_Email.Size = new System.Drawing.Size(235, 20);
            this.v_Email.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "First line of address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Home phone number";
            // 
            // v_OK
            // 
            this.v_OK.Location = new System.Drawing.Point(168, 354);
            this.v_OK.Name = "v_OK";
            this.v_OK.Size = new System.Drawing.Size(75, 23);
            this.v_OK.TabIndex = 13;
            this.v_OK.Text = "OK";
            this.v_OK.UseVisualStyleBackColor = true;
            this.v_OK.Click += new System.EventHandler(this.v_OK_Click);
            // 
            // v_Help
            // 
            this.v_Help.Enabled = false;
            this.v_Help.Location = new System.Drawing.Point(249, 354);
            this.v_Help.Name = "v_Help";
            this.v_Help.Size = new System.Drawing.Size(75, 23);
            this.v_Help.TabIndex = 14;
            this.v_Help.Text = "Help";
            this.v_Help.UseVisualStyleBackColor = true;
            // 
            // v_Exit
            // 
            this.v_Exit.Location = new System.Drawing.Point(330, 354);
            this.v_Exit.Name = "v_Exit";
            this.v_Exit.Size = new System.Drawing.Size(75, 23);
            this.v_Exit.TabIndex = 15;
            this.v_Exit.Text = "Exit";
            this.v_Exit.UseVisualStyleBackColor = true;
            this.v_Exit.Click += new System.EventHandler(this.v_Exit_Click);
            // 
            // v_GymMember
            // 
            this.v_GymMember.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.v_GymMember.Location = new System.Drawing.Point(12, 278);
            this.v_GymMember.Name = "v_GymMember";
            this.v_GymMember.Size = new System.Drawing.Size(160, 22);
            this.v_GymMember.TabIndex = 0;
            this.v_GymMember.Text = "Customer is a gym member?";
            this.v_GymMember.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Title";
            // 
            // v_Title
            // 
            this.v_Title.Location = new System.Drawing.Point(121, 37);
            this.v_Title.Name = "v_Title";
            this.v_Title.Size = new System.Drawing.Size(122, 20);
            this.v_Title.TabIndex = 17;
            // 
            // EnteringDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 389);
            this.Controls.Add(this.v_Title);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.v_GymMember);
            this.Controls.Add(this.v_Exit);
            this.Controls.Add(this.v_Help);
            this.Controls.Add(this.v_OK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v_Email);
            this.Controls.Add(this.v_Phone);
            this.Controls.Add(this.v_Address);
            this.Controls.Add(this.v_Firstname);
            this.Controls.Add(this.v_Surname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnteringDetails";
            this.Text = "Enter customer details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox v_Surname;
        private System.Windows.Forms.TextBox v_Firstname;
        private System.Windows.Forms.TextBox v_Address;
        private System.Windows.Forms.TextBox v_Phone;
        private System.Windows.Forms.TextBox v_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button v_OK;
        private System.Windows.Forms.Button v_Help;
        private System.Windows.Forms.Button v_Exit;
        private System.Windows.Forms.CheckBox v_GymMember;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox v_Title;
    }
}