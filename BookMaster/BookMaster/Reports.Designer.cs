namespace BookMaster
{
    partial class Reports
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
            this.btnexp = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.TabPage();
            this.Reminders = new System.Windows.Forms.TabPage();
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.History.SuspendLayout();
            this.Reminders.SuspendLayout();
            this.tabcontrol1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexp
            // 
            this.btnexp.Location = new System.Drawing.Point(675, 26);
            this.btnexp.Name = "btnexp";
            this.btnexp.Size = new System.Drawing.Size(113, 23);
            this.btnexp.TabIndex = 0;
            this.btnexp.Text = "EXPORT";
            this.btnexp.UseVisualStyleBackColor = true;
            this.btnexp.Click += new System.EventHandler(this.btnexp_Click);
            // 
            // History
            // 
            this.History.Controls.Add(this.dataGridView2);
            this.History.Controls.Add(this.label3);
            this.History.Controls.Add(this.label2);
            this.History.Controls.Add(this.txtbookid);
            this.History.Controls.Add(this.label1);
            this.History.Location = new System.Drawing.Point(4, 25);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(3);
            this.History.Size = new System.Drawing.Size(768, 340);
            this.History.TabIndex = 1;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Reminders
            // 
            this.Reminders.Controls.Add(this.dataGridView1);
            this.Reminders.Location = new System.Drawing.Point(4, 25);
            this.Reminders.Name = "Reminders";
            this.Reminders.Padding = new System.Windows.Forms.Padding(3);
            this.Reminders.Size = new System.Drawing.Size(768, 340);
            this.Reminders.TabIndex = 0;
            this.Reminders.Text = "Reminders";
            this.Reminders.UseVisualStyleBackColor = true;
            this.Reminders.Click += new System.EventHandler(this.Reminders_Click);
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.Reminders);
            this.tabcontrol1.Controls.Add(this.History);
            this.tabcontrol1.Location = new System.Drawing.Point(12, 55);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(776, 369);
            this.tabcontrol1.TabIndex = 1;
            this.tabcontrol1.SelectedIndexChanged += new System.EventHandler(this.tabcontrol1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(768, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOOK ID";
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(24, 56);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(136, 22);
            this.txtbookid.TabIndex = 1;
            this.txtbookid.TextChanged += new System.EventHandler(this.txtbookid_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subtitle";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(251, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(511, 328);
            this.dataGridView2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "REPORTS";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabcontrol1);
            this.Controls.Add(this.btnexp);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.History.ResumeLayout(false);
            this.History.PerformLayout();
            this.Reminders.ResumeLayout(false);
            this.tabcontrol1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexp;
        private System.Windows.Forms.TabPage History;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Reminders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.Label label4;
    }
}