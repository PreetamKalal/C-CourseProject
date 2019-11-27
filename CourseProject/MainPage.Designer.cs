namespace CourseProject
{
    partial class MainPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.GoToDairy = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 526);
            this.panel1.TabIndex = 0;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(189, 394);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(199, 51);
            this.Save.TabIndex = 58;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 29);
            this.label6.TabIndex = 56;
            this.label6.Text = "Password";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 29);
            this.label4.TabIndex = 52;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 29);
            this.label3.TabIndex = 51;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 29);
            this.label2.TabIndex = 50;
            this.label2.Text = "E-Mail ID";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "UserName";
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(482, 293);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(156, 190);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // GoToDairy
            // 
            this.GoToDairy.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToDairy.Location = new System.Drawing.Point(482, 36);
            this.GoToDairy.Name = "GoToDairy";
            this.GoToDairy.Size = new System.Drawing.Size(156, 188);
            this.GoToDairy.TabIndex = 2;
            this.GoToDairy.Text = "Go To Dairy";
            this.GoToDairy.UseVisualStyleBackColor = true;
            this.GoToDairy.Click += new System.EventHandler(this.GoToDairy_Click);
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(148, 58);
            this.UserName.Multiline = true;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Size = new System.Drawing.Size(311, 29);
            this.UserName.TabIndex = 59;
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(148, 121);
            this.FirstName.Multiline = true;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(311, 29);
            this.FirstName.TabIndex = 60;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(148, 185);
            this.LastName.Multiline = true;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(311, 29);
            this.LastName.TabIndex = 61;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(148, 255);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(311, 29);
            this.Email.TabIndex = 62;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(148, 319);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(311, 29);
            this.Password.TabIndex = 63;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 526);
            this.Controls.Add(this.GoToDairy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Logout);
            this.Name = "MainPage";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GoToDairy;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox UserName;
    }
}