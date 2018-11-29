/*
 * CSCI 504: Programming principles in .NET
 * Assignment 6
 * Benjamin Simpson - Z100820
 * Xueqiong Li - z1785226
*/

namespace Assignment6
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartControl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartTite_Label = new System.Windows.Forms.Label();
            this.Menu_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChartControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartControl
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartControl.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartControl.Legends.Add(legend2);
            this.ChartControl.Location = new System.Drawing.Point(69, 59);
            this.ChartControl.Name = "ChartControl";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartControl.Series.Add(series2);
            this.ChartControl.Size = new System.Drawing.Size(945, 589);
            this.ChartControl.TabIndex = 0;
            this.ChartControl.Text = "chart1";
            // 
            // ChartTite_Label
            // 
            this.ChartTite_Label.AutoSize = true;
            this.ChartTite_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartTite_Label.Location = new System.Drawing.Point(64, 18);
            this.ChartTite_Label.Name = "ChartTite_Label";
            this.ChartTite_Label.Size = new System.Drawing.Size(76, 26);
            this.ChartTite_Label.TabIndex = 1;
            this.ChartTite_Label.Text = "label1";
            // 
            // Menu_Button
            // 
            this.Menu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Button.Location = new System.Drawing.Point(870, 662);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.Size = new System.Drawing.Size(144, 46);
            this.Menu_Button.TabIndex = 2;
            this.Menu_Button.Text = "Main Menu";
            this.Menu_Button.UseVisualStyleBackColor = true;
            this.Menu_Button.Click += new System.EventHandler(this.Menu_Button_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 720);
            this.Controls.Add(this.Menu_Button);
            this.Controls.Add(this.ChartTite_Label);
            this.Controls.Add(this.ChartControl);
            this.Name = "ChartForm";
            this.Text = "ChartForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChartForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ChartControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartControl;
        private System.Windows.Forms.Label ChartTite_Label;
        private System.Windows.Forms.Button Menu_Button;
    }
}