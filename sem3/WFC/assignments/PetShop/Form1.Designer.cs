namespace PetShop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBird = new System.Windows.Forms.RadioButton();
            this.radFish = new System.Windows.Forms.RadioButton();
            this.radCat = new System.Windows.Forms.RadioButton();
            this.radDog = new System.Windows.Forms.RadioButton();
            this.picPets = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPets)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "PET SHOP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBird);
            this.groupBox1.Controls.Add(this.radFish);
            this.groupBox1.Controls.Add(this.radCat);
            this.groupBox1.Controls.Add(this.radDog);
            this.groupBox1.Location = new System.Drawing.Point(75, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHOOSE";
            // 
            // radBird
            // 
            this.radBird.AutoSize = true;
            this.radBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBird.Location = new System.Drawing.Point(26, 148);
            this.radBird.Name = "radBird";
            this.radBird.Size = new System.Drawing.Size(73, 33);
            this.radBird.TabIndex = 0;
            this.radBird.TabStop = true;
            this.radBird.Text = "bird";
            this.radBird.UseVisualStyleBackColor = true;
            this.radBird.CheckedChanged += new System.EventHandler(this.radBird_CheckedChanged);
            // 
            // radFish
            // 
            this.radFish.AutoSize = true;
            this.radFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFish.Location = new System.Drawing.Point(26, 109);
            this.radFish.Name = "radFish";
            this.radFish.Size = new System.Drawing.Size(68, 33);
            this.radFish.TabIndex = 0;
            this.radFish.TabStop = true;
            this.radFish.Text = "fish";
            this.radFish.UseVisualStyleBackColor = true;
            this.radFish.CheckedChanged += new System.EventHandler(this.radFish_CheckedChanged);
            // 
            // radCat
            // 
            this.radCat.AutoSize = true;
            this.radCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCat.Location = new System.Drawing.Point(26, 70);
            this.radCat.Name = "radCat";
            this.radCat.Size = new System.Drawing.Size(62, 33);
            this.radCat.TabIndex = 0;
            this.radCat.TabStop = true;
            this.radCat.Text = "cat";
            this.radCat.UseVisualStyleBackColor = true;
            this.radCat.CheckedChanged += new System.EventHandler(this.radCat_CheckedChanged);
            // 
            // radDog
            // 
            this.radDog.AutoSize = true;
            this.radDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDog.Location = new System.Drawing.Point(26, 30);
            this.radDog.Name = "radDog";
            this.radDog.Size = new System.Drawing.Size(73, 33);
            this.radDog.TabIndex = 0;
            this.radDog.TabStop = true;
            this.radDog.Text = "dog";
            this.radDog.UseVisualStyleBackColor = true;
            this.radDog.CheckedChanged += new System.EventHandler(this.radDog_CheckedChanged);
            // 
            // picPets
            // 
            this.picPets.Location = new System.Drawing.Point(424, 96);
            this.picPets.Name = "picPets";
            this.picPets.Size = new System.Drawing.Size(233, 239);
            this.picPets.TabIndex = 2;
            this.picPets.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dog.jpg");
            this.imageList1.Images.SetKeyName(1, "cat.jpg");
            this.imageList1.Images.SetKeyName(2, "fish.jpg");
            this.imageList1.Images.SetKeyName(3, "bird.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picPets);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBird;
        private System.Windows.Forms.RadioButton radFish;
        private System.Windows.Forms.RadioButton radCat;
        private System.Windows.Forms.RadioButton radDog;
        private System.Windows.Forms.PictureBox picPets;
        private System.Windows.Forms.ImageList imageList1;
    }
}

