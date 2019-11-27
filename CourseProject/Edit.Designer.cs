namespace CourseProject
{
    partial class Edit
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
            this.label2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.Content = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Reminder = new System.Windows.Forms.CheckBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GoToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Title";
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(200, 36);
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(311, 29);
            this.Title.TabIndex = 27;
            // 
            // Content
            // 
            this.Content.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Content.Location = new System.Drawing.Point(200, 92);
            this.Content.Multiline = true;
            this.Content.Name = "Content";
            this.Content.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Content.Size = new System.Drawing.Size(511, 250);
            this.Content.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Content";
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(200, 517);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(199, 51);
            this.Save.TabIndex = 30;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Reminder
            // 
            this.Reminder.AutoSize = true;
            this.Reminder.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reminder.Location = new System.Drawing.Point(200, 391);
            this.Reminder.Name = "Reminder";
            this.Reminder.Size = new System.Drawing.Size(373, 33);
            this.Reminder.TabIndex = 31;
            this.Reminder.Text = "Do You Want To Set A Reminder?";
            this.Reminder.UseVisualStyleBackColor = true;
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(402, 466);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 22);
            this.StartDate.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "Date and Time";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(195, 604);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(578, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Want to go back to main page?Click The Button Below";
            // 
            // GoToMain
            // 
            this.GoToMain.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToMain.Location = new System.Drawing.Point(200, 671);
            this.GoToMain.Name = "GoToMain";
            this.GoToMain.Size = new System.Drawing.Size(199, 86);
            this.GoToMain.TabIndex = 36;
            this.GoToMain.Text = "Go Back To Main Page";
            this.GoToMain.UseVisualStyleBackColor = true;
            this.GoToMain.Click += new System.EventHandler(this.GoToMain_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 777);
            this.Controls.Add(this.GoToMain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.Reminder);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label2);
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Content;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.CheckBox Reminder;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GoToMain;
    }
}