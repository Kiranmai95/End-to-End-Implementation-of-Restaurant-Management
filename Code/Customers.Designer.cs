
namespace RMS
{
    partial class Customers
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.pswdtxt = new System.Windows.Forms.TextBox();
            this.Phntxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snogv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_IDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emailgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passwordgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.Phntxt);
            this.leftpanel.Controls.Add(this.pswdtxt);
            this.leftpanel.Controls.Add(this.EmailText);
            this.leftpanel.Controls.Add(this.NameText);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Size = new System.Drawing.Size(250, 659);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.NameText, 0);
            this.leftpanel.Controls.SetChildIndex(this.EmailText, 0);
            this.leftpanel.Controls.SetChildIndex(this.pswdtxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.Phntxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.groupBox1);
            this.rightpanel.Size = new System.Drawing.Size(999, 656);
            this.rightpanel.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Phone Number";
            // 
            // NameText
            // 
            this.NameText.Enabled = false;
            this.NameText.Location = new System.Drawing.Point(12, 221);
            this.NameText.MaxLength = 30;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(232, 34);
            this.NameText.TabIndex = 7;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // EmailText
            // 
            this.EmailText.Enabled = false;
            this.EmailText.Location = new System.Drawing.Point(12, 302);
            this.EmailText.MaxLength = 50;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(232, 34);
            this.EmailText.TabIndex = 8;
            this.EmailText.TextChanged += new System.EventHandler(this.EmailText_TextChanged);
            // 
            // pswdtxt
            // 
            this.pswdtxt.Enabled = false;
            this.pswdtxt.Location = new System.Drawing.Point(12, 396);
            this.pswdtxt.MaxLength = 30;
            this.pswdtxt.Name = "pswdtxt";
            this.pswdtxt.Size = new System.Drawing.Size(232, 34);
            this.pswdtxt.TabIndex = 9;
            this.pswdtxt.TextChanged += new System.EventHandler(this.pswdtxt_TextChanged);
            // 
            // Phntxt
            // 
            this.Phntxt.Enabled = false;
            this.Phntxt.Location = new System.Drawing.Point(12, 489);
            this.Phntxt.MaxLength = 15;
            this.Phntxt.Name = "Phntxt";
            this.Phntxt.Size = new System.Drawing.Size(232, 34);
            this.Phntxt.TabIndex = 10;
            this.Phntxt.UseSystemPasswordChar = true;
            this.Phntxt.TextChanged += new System.EventHandler(this.Phntxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(8, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 453);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snogv,
            this.Customer_IDgv,
            this.Namegv,
            this.Emailgv,
            this.Passwordgv,
            this.PhoneGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(903, 423);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // snogv
            // 
            this.snogv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snogv.HeaderText = "";
            this.snogv.MinimumWidth = 8;
            this.snogv.Name = "snogv";
            this.snogv.Width = 29;
            // 
            // Customer_IDgv
            // 
            this.Customer_IDgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_IDgv.HeaderText = "Customer ID";
            this.Customer_IDgv.MinimumWidth = 4;
            this.Customer_IDgv.Name = "Customer_IDgv";
            this.Customer_IDgv.Visible = false;
            // 
            // Namegv
            // 
            this.Namegv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Namegv.HeaderText = "Name";
            this.Namegv.MinimumWidth = 4;
            this.Namegv.Name = "Namegv";
            // 
            // Emailgv
            // 
            this.Emailgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Emailgv.HeaderText = "Email";
            this.Emailgv.MinimumWidth = 4;
            this.Emailgv.Name = "Emailgv";
            // 
            // Passwordgv
            // 
            this.Passwordgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Passwordgv.HeaderText = "Password";
            this.Passwordgv.MinimumWidth = 4;
            this.Passwordgv.Name = "Passwordgv";
            // 
            // PhoneGV
            // 
            this.PhoneGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneGV.HeaderText = "Phone";
            this.PhoneGV.MinimumWidth = 4;
            this.PhoneGV.Name = "PhoneGV";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 659);
            this.Name = "Customers";
            this.Text = "Customers";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Phntxt;
        private System.Windows.Forms.TextBox pswdtxt;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snogv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_IDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emailgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passwordgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGV;
    }
}