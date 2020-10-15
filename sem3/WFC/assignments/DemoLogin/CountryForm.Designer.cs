namespace DemoLogin
{
    partial class CountryForm
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
            this.lstCountry = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkListCountry = new System.Windows.Forms.CheckedListBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCountry
            // 
            this.lstCountry.BackColor = System.Drawing.Color.Red;
            this.lstCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCountry.ForeColor = System.Drawing.SystemColors.Window;
            this.lstCountry.FormattingEnabled = true;
            this.lstCountry.ItemHeight = 20;
            this.lstCountry.Items.AddRange(new object[] {
            "USA",
            "RUSSIA",
            "VIETNAM",
            "JAPAN",
            "FRANCE",
            "GERMANY",
            "AUSTRALIA"});
            this.lstCountry.Location = new System.Drawing.Point(498, 109);
            this.lstCountry.Name = "lstCountry";
            this.lstCountry.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstCountry.Size = new System.Drawing.Size(201, 204);
            this.lstCountry.TabIndex = 0;
            this.lstCountry.SelectedIndexChanged += new System.EventHandler(this.lstCountry_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "COUNTRY LIST";
            // 
            // chkListCountry
            // 
            this.chkListCountry.FormattingEnabled = true;
            this.chkListCountry.Items.AddRange(new object[] {
            "USA",
            "RUSSIA",
            "VIETNAM",
            "JAPAN",
            "FRANCE",
            "GERMANY",
            "AUSTRALIA"});
            this.chkListCountry.Location = new System.Drawing.Point(271, 109);
            this.chkListCountry.Name = "chkListCountry";
            this.chkListCountry.Size = new System.Drawing.Size(148, 214);
            this.chkListCountry.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(271, 343);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(140, 31);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(117, 400);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(35, 13);
            this.lblList.TabIndex = 4;
            this.lblList.Text = "label2";
            // 
            // CountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.chkListCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCountry);
            this.Name = "CountryForm";
            this.Text = "CountryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkListCountry;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblList;
    }
}