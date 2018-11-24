using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
