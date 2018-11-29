/*
 * CSCI 504: Programming principles in .NET
 * Assignment 6
 * Benjamin Simpson - Z100820
 * Xueqiong Li - z1785226
*/

using System;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadReport_Click(object sender, EventArgs e)
        {
            var activeForm = ActiveForm;
            Hide();
            var button = (Button) sender;
            var form = new ChartForm(button.Name, activeForm);
            form.Show();
        }

        private void Exit_Click(object seender, EventArgs e)
        {
            Close();
        }
    }
}
