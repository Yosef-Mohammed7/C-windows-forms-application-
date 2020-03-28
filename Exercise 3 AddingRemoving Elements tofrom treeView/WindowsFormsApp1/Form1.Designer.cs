namespace WindowsFormsApp1
{
    partial class AddChildNodes
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.AddNodes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RemoveNodes = new System.Windows.Forms.Button();
            this.DeleteTree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(143, 339);
            this.treeView1.TabIndex = 0;
            // 
            // AddNodes
            // 
            this.AddNodes.Location = new System.Drawing.Point(214, 79);
            this.AddNodes.Name = "AddNodes";
            this.AddNodes.Size = new System.Drawing.Size(121, 23);
            this.AddNodes.TabIndex = 1;
            this.AddNodes.Text = "Add Nodes";
            this.AddNodes.UseVisualStyleBackColor = true;
            this.AddNodes.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Child Nodes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RemoveNodes
            // 
            this.RemoveNodes.Location = new System.Drawing.Point(214, 159);
            this.RemoveNodes.Name = "RemoveNodes";
            this.RemoveNodes.Size = new System.Drawing.Size(121, 23);
            this.RemoveNodes.TabIndex = 3;
            this.RemoveNodes.Text = "Remove Nodes";
            this.RemoveNodes.UseVisualStyleBackColor = true;
            this.RemoveNodes.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteTree
            // 
            this.DeleteTree.Location = new System.Drawing.Point(214, 202);
            this.DeleteTree.Name = "DeleteTree";
            this.DeleteTree.Size = new System.Drawing.Size(121, 23);
            this.DeleteTree.TabIndex = 4;
            this.DeleteTree.Text = "Delete Tree";
            this.DeleteTree.UseVisualStyleBackColor = true;
            this.DeleteTree.Click += new System.EventHandler(this.button4_Click);
            // 
            // AddChildNodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 379);
            this.Controls.Add(this.DeleteTree);
            this.Controls.Add(this.RemoveNodes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddNodes);
            this.Controls.Add(this.treeView1);
            this.Name = "AddChildNodes";
            this.Text = "TreeView Application ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button AddNodes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button RemoveNodes;
        private System.Windows.Forms.Button DeleteTree;
    }
}

