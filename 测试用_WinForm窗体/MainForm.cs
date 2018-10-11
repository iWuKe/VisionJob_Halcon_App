using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Drawing;

namespace shikii.Test.Wnd
{
   public class MainForm : Form
    {
        private TreeView treeView1;

        public MainForm()
        {
            InitializeComponent();

            treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
         
            treeView1.DrawNode += TreeView1_DrawNode;
        }

        private void TreeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
           
            Graphics g = e.Graphics;
            e.Node.
            //g.DrawImage(Image.FromFile("D:/icon.png"), e.Node.Bounds.X, e.Node.Bounds.Y,16,16);
            //e.Node.ContextMenuStrip = new ContextMenuStrip();
            //e.Node.ContextMenuStrip.Items.Add("jet");
            g.DrawString(e.Node.Text, treeView1.Font, Brushes.Black,e.Node.Bounds.X + 16 , e.Node.Bounds.Y );
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点2");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(31, 34);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点0";
            treeNode1.Text = "节点0";
            treeNode2.Name = "节点1";
            treeNode2.Text = "节点1";
            treeNode3.Name = "节点2";
            treeNode3.Text = "节点2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(251, 260);
            this.treeView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(433, 409);
            this.Controls.Add(this.treeView1);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
