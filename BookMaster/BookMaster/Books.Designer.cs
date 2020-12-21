namespace BookMaster
{
    partial class Books
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "KEY";
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(357, 57);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(247, 22);
            this.txtkey.TabIndex = 1;
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(357, 125);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(247, 22);
            this.txttitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "TITLE";
            // 
            // txtsub
            // 
            this.txtsub.Location = new System.Drawing.Point(357, 185);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(247, 22);
            this.txtsub.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "SUBTITLE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "FIRST PUBLICATION";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(357, 294);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(247, 22);
            this.txtdescription.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "DESCRIPTION";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(273, 384);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(154, 23);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(357, 236);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(247, 22);
            this.dtp1.TabIndex = 11;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkey);
            this.Controls.Add(this.label1);
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DateTimePicker dtp1;
    }
}