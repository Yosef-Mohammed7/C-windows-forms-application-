using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void CalculateAge_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker2.Value;
            DateTime to = DateTime.Now;
            TimeSpan tspan = to - from;
            DateTime age = DateTime.MinValue.AddDays(tspan.Days);


            MessageBox.Show("Your Age is " + (age.Year - 1).ToString("0")+" Years "+(age.Month-1)+" Months "+ (age.Day-1)+" Days");
        }
    }
}
