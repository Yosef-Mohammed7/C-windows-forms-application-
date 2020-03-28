using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2_AddingRemoving
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please MUST select item from Left to List box ");
            }
            else
            { 
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
                Application.Exit();
        }
    }
}
    