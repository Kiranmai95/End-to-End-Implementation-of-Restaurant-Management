
namespace RMS
{
    partial class Addchef
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
            this.Cheffntxt = new System.Windows.Forms.TextBox();
            this.Chef = new System.Windows.Forms.Label();
            this.Cheferrorlabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lastname = new System.Windows.Forms.Label();
            this.Cheflntxt = new System.Windows.Forms.TextBox();
            this.phonenumber = new System.Windows.Forms.Label();
            this.phntxt = new System.Windows.Forms.TextBox();
            this.snogv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChefIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChefFnameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChefLNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.phntxt);
            this.leftpanel.Controls.Add(this.phonenumber);
            this.leftpanel.Controls.Add(this.Cheflntxt);
            this.leftpanel.Controls.Add(this.lastname);
            this.leftpanel.Controls.Add(this.Cheferrorlabel);
            this.leftpanel.Controls.Add(this.Chef);
            this.leftpanel.Controls.Add(this.Cheffntxt);
            this.leftpanel.Size = new System.Drawing.Size(311, 667);
            this.leftpanel.Controls.SetChildIndex(this.Cheffntxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.Chef, 0);
            this.leftpanel.Controls.SetChildIndex(this.Cheferrorlabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.lastname, 0);
            this.leftpanel.Controls.SetChildIndex(this.Cheflntxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.phonenumber, 0);
            this.leftpanel.Controls.SetChildIndex(this.phntxt, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(999, 667);
            // 
            // Cheffntxt
            // 
            this.Cheffntxt.Enabled = false;
            this.Cheffntxt.Location = new System.Drawing.Point(52, 252);
            this.Cheffntxt.Name = "Cheffntxt";
            this.Cheffntxt.Size = new System.Drawing.Size(210, 34);
            this.Cheffntxt.TabIndex = 4;
            this.Cheffntxt.TextChanged += new System.EventHandler(this.Cheftxt_TextChanged);
            // 
            // Chef
            // 
            this.Chef.AutoSize = true;
            this.Chef.Location = new System.Drawing.Point(53, 193);
            this.Chef.Name = "Chef";
            this.Chef.Size = new System.Drawing.Size(150, 28);
            this.Chef.TabIndex = 5;
            this.Chef.Text = "Chef First Name";
            // 
            // Cheferrorlabel
            // 
            this.Cheferrorlabel.AutoSize = true;
            this.Cheferrorlabel.Location = new System.Drawing.Point(242, 221);
            this.Cheferrorlabel.Name = "Cheferrorlabel";
            this.Cheferrorlabel.Size = new System.Drawing.Size(20, 28);
            this.Cheferrorlabel.TabIndex = 6;
            this.Cheferrorlabel.Text = "*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(317, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 455);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snogv,
            this.ChefIDGV,
            this.ChefFnameGV,
            this.ChefLNameGV,
            this.PhoneGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(977, 422);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(53, 300);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(147, 28);
            this.lastname.TabIndex = 7;
            this.lastname.Text = "Chef Last Name";
            // 
            // Cheflntxt
            // 
            this.Cheflntxt.Location = new System.Drawing.Point(52, 340);
            this.Cheflntxt.Name = "Cheflntxt";
            this.Cheflntxt.Size = new System.Drawing.Size(210, 34);
            this.Cheflntxt.TabIndex = 8;
            // 
            // phonenumber
            // 
            this.phonenumber.AutoSize = true;
            this.phonenumber.Location = new System.Drawing.Point(53, 389);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(95, 28);
            this.phonenumber.TabIndex = 9;
            this.phonenumber.Text = "Phone no";
            // 
            // phntxt
            // 
            this.phntxt.Location = new System.Drawing.Point(52, 420);
            this.phntxt.MaxLength = 15;
            this.phntxt.Name = "phntxt";
            this.phntxt.Size = new System.Drawing.Size(209, 34);
            this.phntxt.TabIndex = 10;
            // 
            // snogv
            // 
            this.snogv.HeaderText = "";
            this.snogv.MinimumWidth = 8;
            this.snogv.Name = "snogv";
            this.snogv.Width = 150;
            // 
            // ChefIDGV
            // 
            this.ChefIDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChefIDGV.HeaderText = "Chef ID";
            this.ChefIDGV.MinimumWidth = 8;
            this.ChefIDGV.Name = "ChefIDGV";
            this.ChefIDGV.Visible = false;
            // 
            // ChefFnameGV
            // 
            this.ChefFnameGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChefFnameGV.HeaderText = "Chef first Name";
            this.ChefFnameGV.MinimumWidth = 8;
            this.ChefFnameGV.Name = "ChefFnameGV";
            // 
            // ChefLNameGV
            // 
            this.ChefLNameGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChefLNameGV.HeaderText = "Chef Last Name";
            this.ChefLNameGV.MinimumWidth = 8;
            this.ChefLNameGV.Name = "ChefLNameGV";
            // 
            // PhoneGV
            // 
            this.PhoneGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneGV.HeaderText = "Phone Number";
            this.PhoneGV.MinimumWidth = 8;
            this.PhoneGV.Name = "PhoneGV";
            // 
            // Addchef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 667);
            this.Controls.Add(this.groupBox1);
            this.Name = "Addchef";
            this.Text = "Addchef";
            this.Controls.SetChildIndex(this.leftpanel, 0);
            this.Controls.SetChildIndex(this.rightpanel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Cheffntxt;
        private System.Windows.Forms.Label Chef;
        private System.Windows.Forms.Label Cheferrorlabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox phntxt;
        private System.Windows.Forms.Label phonenumber;
        private System.Windows.Forms.TextBox Cheflntxt;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn snogv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChefIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChefFnameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChefLNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGV;
    }
}