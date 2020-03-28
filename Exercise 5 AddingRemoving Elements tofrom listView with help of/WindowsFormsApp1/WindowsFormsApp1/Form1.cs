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

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem list = new ListViewItem(textBox1.Text);
            list.SubItems.Add(textBox2.Text);
            list.SubItems.Add(textBox3.Text);
            listView1.Items.Add(list);

        }
        //thanks for Mashall Gannam who is to find the solution of methods Copy and deleate
        // for copy
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Add((ListViewItem)item.Clone());
            }
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        // for Deleate
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]) ;
        }
    }
}


