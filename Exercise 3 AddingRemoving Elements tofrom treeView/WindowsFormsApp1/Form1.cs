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
    public partial class AddChildNodes : Form
    {
        public AddChildNodes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Laptops");
            treeView1.Nodes.Add("Smart Phones ");
            treeView1.Nodes.Add("Printers");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Laptops
            treeView1.Nodes[0].Nodes.Add("Dell");
            treeView1.Nodes[0].Nodes.Add("Toshiba");
            treeView1.Nodes[0].Nodes.Add("Acer");
            //Smart Phones
            treeView1.Nodes[1].Nodes.Add("Iphone");
            treeView1.Nodes[1].Nodes.Add("Samsung");
            treeView1.Nodes[1].Nodes.Add("LG");
            // nodes Printers
            treeView1.Nodes[2].Nodes.Add("Canon");
            treeView1.Nodes[2].Nodes.Add("Epson");

        }
        //to remove nodes 
        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }
        // to delet tree
        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }
    }
}
