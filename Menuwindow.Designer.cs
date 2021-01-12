
namespace RMS
{
    partial class Menuwindow
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
            this.label3 = new System.Windows.Forms.Label();
            this.itemnametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Itemdesctxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snogv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_idgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_namegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_descgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_pricegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.pricetxt);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.Itemdesctxt);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.itemnametxt);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Size = new System.Drawing.Size(250, 709);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.itemnametxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.Itemdesctxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.pricetxt, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.groupBox1);
            this.rightpanel.Size = new System.Drawing.Size(999, 697);
            this.rightpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightpanel_Paint);
            this.rightpanel.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "ItemName";
            // 
            // itemnametxt
            // 
            this.itemnametxt.Location = new System.Drawing.Point(3, 228);
            this.itemnametxt.MaxLength = 20;
            this.itemnametxt.Name = "itemnametxt";
            this.itemnametxt.Size = new System.Drawing.Size(241, 34);
            this.itemnametxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Item Description";
            // 
            // Itemdesctxt
            // 
            this.Itemdesctxt.Location = new System.Drawing.Point(4, 322);
            this.Itemdesctxt.MaxLength = 100;
            this.Itemdesctxt.Multiline = true;
            this.Itemdesctxt.Name = "Itemdesctxt";
            this.Itemdesctxt.Size = new System.Drawing.Size(241, 106);
            this.Itemdesctxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price";
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(8, 486);
            this.pricetxt.MaxLength = 5;
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(239, 34);
            this.pricetxt.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(6, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 268);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snogv,
            this.Item_idgv,
            this.Item_namegv,
            this.Item_descgv,
            this.Item_pricegv});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(958, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // snogv
            // 
            this.snogv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snogv.HeaderText = "";
            this.snogv.MinimumWidth = 8;
            this.snogv.Name = "snogv";
            this.snogv.Width = 29;
            // 
            // Item_idgv
            // 
            this.Item_idgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_idgv.HeaderText = "Item ID";
            this.Item_idgv.MinimumWidth = 4;
            this.Item_idgv.Name = "Item_idgv";
            this.Item_idgv.Visible = false;
            // 
            // Item_namegv
            // 
            this.Item_namegv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_namegv.HeaderText = "Item Name";
            this.Item_namegv.MinimumWidth = 4;
            this.Item_namegv.Name = "Item_namegv";
            // 
            // Item_descgv
            // 
            this.Item_descgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_descgv.HeaderText = "Item Description";
            this.Item_descgv.MinimumWidth = 4;
            this.Item_descgv.Name = "Item_descgv";
            // 
            // Item_pricegv
            // 
            this.Item_pricegv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_pricegv.HeaderText = "Price";
            this.Item_pricegv.MinimumWidth = 8;
            this.Item_pricegv.Name = "Item_pricegv";
            // 
            // Menuwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 709);
            this.Name = "Menuwindow";
            this.Text = "Menuwindow";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Itemdesctxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snogv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_idgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_namegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_descgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_pricegv;
    }
}