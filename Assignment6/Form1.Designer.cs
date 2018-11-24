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
            this.button3 = new System.Windows.Forms.Button();
            this.Batting_Button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(144, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 50);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
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
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(144, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Batting_Button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Attendance_Button);
            this.Name = "Form1";
            this.Text = "Chart Portal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Attendance_Button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Batting_Button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Exit_Button;
    }
}

