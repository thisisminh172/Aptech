namespace DemoSession2
{
    partial class TreeViewForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Le Minh");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nguyen Huu Thang");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Phong ke toan", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nguyen Minh Tuan");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Le Thi Thao");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Phong kinh doanh", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nguyen Van A");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nguyen Van B");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Phong to chuc", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Cong Ty ABC", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(183, 43);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node4";
            treeNode1.Text = "Le Minh";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Nguyen Huu Thang";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Phong ke toan";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Nguyen Minh Tuan";
            treeNode5.Name = "Node7";
            treeNode5.Text = "Le Thi Thao";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Phong kinh doanh";
            treeNode7.Name = "Node8";
            treeNode7.Text = "Nguyen Van A";
            treeNode8.Name = "Node9";
            treeNode8.Text = "Nguyen Van B";
            treeNode9.Name = "Node3";
            treeNode9.Text = "Phong to chuc";
            treeNode10.Name = "Node0";
            treeNode10.Text = "Cong Ty ABC";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(282, 274);
            this.treeView1.TabIndex = 0;
            
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // TreeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "TreeViewForm";
            this.Text = "TreeViewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}