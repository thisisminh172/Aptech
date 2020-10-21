namespace DemoSession2
{
    partial class ListViewDemo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("HTML5");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("SQL Server");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Semeter 1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Java");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("PHP");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Semeter 2", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Winform", -2, 1);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("ASP.NET");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Semeter 3", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Servlet");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("JAVA");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Semeter 4", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Semeter", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9,
            treeNode12});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewDemo));
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Nguyễn Hữu Thắng");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Lê Minh");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("PHòng kế toán", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Nguyễn Minh Tuấn");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Lê Thị Thảo");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Phòng kinh doanh", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Nguyễn Văn A");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Nguyễn Thị B");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Phòng tổ chức", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Công ty ABC", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode19,
            treeNode22});
            this.lstStudent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // lstStudent
            // 
            this.lstStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStudent.HideSelection = false;
            this.lstStudent.Location = new System.Drawing.Point(12, 25);
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.Size = new System.Drawing.Size(172, 146);
            this.lstStudent.TabIndex = 0;
            this.lstStudent.UseCompatibleStateImageBehavior = false;
            this.lstStudent.View = System.Windows.Forms.View.Details;
            this.lstStudent.Click += new System.EventHandler(this.lstStudent_Click_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Sinh viên";
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(238, 25);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node5";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Text = "HTML5";
            treeNode2.Name = "Node6";
            treeNode2.SelectedImageIndex = 3;
            treeNode2.Text = "SQL Server";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Semeter 1";
            treeNode4.Name = "Node7";
            treeNode4.Text = "Java";
            treeNode5.Name = "Node8";
            treeNode5.Text = "PHP";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Semeter 2";
            treeNode7.ImageIndex = -2;
            treeNode7.Name = "Node9";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "Winform";
            treeNode8.Name = "Node10";
            treeNode8.Text = "ASP.NET";
            treeNode9.Name = "Node3";
            treeNode9.Text = "Semeter 3";
            treeNode10.Name = "Node12";
            treeNode10.Text = "Servlet";
            treeNode11.Name = "Node13";
            treeNode11.Text = "JAVA";
            treeNode12.Name = "Node4";
            treeNode12.Text = "Semeter 4";
            treeNode13.Name = "node";
            treeNode13.Text = "Semeter";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.treeView1.SelectedImageIndex = 1;
            this.treeView1.Size = new System.Drawing.Size(178, 146);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bird.jpg");
            this.imageList1.Images.SetKeyName(1, "cat.jpg");
            this.imageList1.Images.SetKeyName(2, "dog.jpg");
            this.imageList1.Images.SetKeyName(3, "fish.jpg");
            // 
            // treeView2
            // 
            this.treeView2.ImageIndex = 0;
            this.treeView2.ImageList = this.imageList1;
            this.treeView2.Location = new System.Drawing.Point(464, 25);
            this.treeView2.Name = "treeView2";
            treeNode14.Name = "Node4";
            treeNode14.SelectedImageIndex = 1;
            treeNode14.Text = "Nguyễn Hữu Thắng";
            treeNode15.Name = "Node5";
            treeNode15.SelectedImageIndex = 1;
            treeNode15.Text = "Lê Minh";
            treeNode16.Name = "Node1";
            treeNode16.Text = "PHòng kế toán";
            treeNode17.Name = "Node6";
            treeNode17.SelectedImageIndex = 2;
            treeNode17.Text = "Nguyễn Minh Tuấn";
            treeNode18.Name = "Node7";
            treeNode18.SelectedImageIndex = 2;
            treeNode18.Text = "Lê Thị Thảo";
            treeNode19.Name = "Node2";
            treeNode19.Text = "Phòng kinh doanh";
            treeNode20.Name = "Node8";
            treeNode20.SelectedImageIndex = 3;
            treeNode20.Text = "Nguyễn Văn A";
            treeNode21.Name = "Node9";
            treeNode21.SelectedImageIndex = 3;
            treeNode21.Text = "Nguyễn Thị B";
            treeNode22.Name = "Node3";
            treeNode22.Text = "Phòng tổ chức";
            treeNode23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            treeNode23.ForeColor = System.Drawing.Color.Red;
            treeNode23.Name = "Node0";
            treeNode23.Text = "Công ty ABC";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode23});
            this.treeView2.SelectedImageIndex = 0;
            this.treeView2.Size = new System.Drawing.Size(223, 341);
            this.treeView2.TabIndex = 2;
            // 
            // ListViewDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lstStudent);
            this.Name = "ListViewDemo";
            this.Text = "Tên sinh viên";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ListViewDemo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstStudent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView2;
    }
}