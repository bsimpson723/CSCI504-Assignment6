namespace Assignment6
{
    partial class Form1
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
            this.Attendance_Button = new System.Windows.Forms.Button();
            this.SocialMedia_Button = new System.Windows.Forms.Button();
            this.Batting_Button = new System.Windows.Forms.Button();
            this.Icecream_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Attendance_Button
            // 
            this.Attendance_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendance_Button.Location = new System.Drawing.Point(144, 144);
            this.Attendance_Button.Name = "Attendance_Button";
            this.Attendance_Button.Size = new System.Drawing.Size(150, 50);
            this.Attendance_Button.TabIndex = 0;
            this.Attendance_Button.Text = "Attendance Rate";
            this.Attendance_Button.UseVisualStyleBackColor = true;
            this.Attendance_Button.Click += new System.EventHandler(this.LoadReport_Click);
            // 
            // SocialMedia_Button
            // 
            this.SocialMedia_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SocialMedia_Button.Location = new System.Drawing.Point(144, 209);
            this.SocialMedia_Button.Name = "SocialMedia_Button";
            this.SocialMedia_Button.Size = new System.Drawing.Size(150, 50);
            this.SocialMedia_Button.TabIndex = 1;
            this.SocialMedia_Button.Text = "Social Media Market Share";
            this.SocialMedia_Button.UseVisualStyleBackColor = true;
            this.SocialMedia_Button.Click += new System.EventHandler(this.LoadReport_Click);
            // 
            // Batting_Button
            // 
            this.Batting_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Batting_Button.Location = new System.Drawing.Point(144, 80);
            this.Batting_Button.Name = "Batting_Button";
            this.Batting_Button.Size = new System.Drawing.Size(150, 50);
            this.Batting_Button.TabIndex = 2;
            this.Batting_Button.Text = "Hitting Statistics";
            this.Batting_Button.UseVisualStyleBackColor = true;
            this.Batting_Button.Click += new System.EventHandler(this.LoadReport_Click);
            // 
            // Icecream_Button
            // 
            this.Icecream_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icecream_Button.Location = new System.Drawing.Point(144, 272);
            this.Icecream_Button.Name = "Icecream_Button";
            this.Icecream_Button.Size = new System.Drawing.Size(150, 50);
            this.Icecream_Button.TabIndex = 3;
            this.Icecream_Button.Text = "Icecream Sales";
            this.Icecream_Button.UseVisualStyleBackColor = true;
            this.Icecream_Button.Click += new System.EventHandler(this.LoadReport_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.Location = new System.Drawing.Point(144, 338);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(150, 50);
            this.Exit_Button.TabIndex = 4;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Icecream_Button);
            this.Controls.Add(this.Batting_Button);
            this.Controls.Add(this.SocialMedia_Button);
            this.Controls.Add(this.Attendance_Button);
            this.Name = "Form1";
            this.Text = "Chart Portal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Attendance_Button;
        private System.Windows.Forms.Button SocialMedia_Button;
        private System.Windows.Forms.Button Batting_Button;
        private System.Windows.Forms.Button Icecream_Button;
        private System.Windows.Forms.Button Exit_Button;
    }
}

