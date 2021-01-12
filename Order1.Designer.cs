
namespace RMS
{
    partial class Order1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Snogv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemIDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNamegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightpanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(250, 705);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.groupBox1);
            this.rightpanel.Size = new System.Drawing.Size(999, 519);
            this.rightpanel.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(8, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Snogv,
            this.ItemIDgv,
            this.ItemNamegv});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(953, 70);
            this.dataGridView1.TabIndex = 0;
            // 
            // Snogv
            // 
            this.Snogv.HeaderText = "Sno";
            this.Snogv.MinimumWidth = 8;
            this.Snogv.Name = "Snogv";
            this.Snogv.Visible = false;
            this.Snogv.Width = 150;
            // 
            // ItemIDgv
            // 
            this.ItemIDgv.HeaderText = "Item ID";
            this.ItemIDgv.MinimumWidth = 8;
            this.ItemIDgv.Name = "ItemIDgv";
            this.ItemIDgv.Width = 150;
            // 
            // ItemNamegv
            // 
            this.ItemNamegv.HeaderText = "Item Name";
            this.ItemNamegv.MinimumWidth = 8;
            this.ItemNamegv.Name = "ItemNamegv";
            this.ItemNamegv.Width = 150;
            // 
            // Order1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 705);
            this.Name = "Order1";
            this.Text = "Order1";
            this.rightpanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Snogv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemIDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNamegv;
    }
}