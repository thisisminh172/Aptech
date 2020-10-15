namespace FlowerShopApp
{
    partial class frmFlowers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlowers));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picFlower = new System.Windows.Forms.PictureBox();
            this.btnView = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFlower)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "red.jpg");
            this.imageList1.Images.SetKeyName(1, "red1.jpg");
            this.imageList1.Images.SetKeyName(2, "rose.jpg");
            this.imageList1.Images.SetKeyName(3, "yellow.jpg");
            // 
            // picFlower
            // 
            this.picFlower.Location = new System.Drawing.Point(185, 37);
            this.picFlower.Name = "picFlower";
            this.picFlower.Size = new System.Drawing.Size(301, 187);
            this.picFlower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFlower.TabIndex = 0;
            this.picFlower.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(294, 264);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "VIEW NEXT";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer_change);
            // 
            // frmFlowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.picFlower);
            this.Name = "frmFlowers";
            this.Text = "frmFlowers";
            ((System.ComponentModel.ISupportInitialize)(this.picFlower)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picFlower;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Timer timer1;
    }
}