
namespace RMS
{
    partial class OrdersWindow
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
            this.ItemDD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TablenumberDD = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cartBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snogv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itemidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_namegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pricegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantitygv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_chefgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_idgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Numbergv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletegv = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Qtyupdown = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.Totallabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qtyupdown)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.Emailtxt);
            this.leftpanel.Controls.Add(this.label10);
            this.leftpanel.Controls.Add(this.Qtyupdown);
            this.leftpanel.Controls.Add(this.cartBtn);
            this.leftpanel.Controls.Add(this.label8);
            this.leftpanel.Controls.Add(this.TablenumberDD);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Controls.Add(this.desctxt);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.pricetxt);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.ItemDD);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Size = new System.Drawing.Size(271, 785);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.ItemDD, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.pricetxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.desctxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.TablenumberDD, 0);
            this.leftpanel.Controls.SetChildIndex(this.label8, 0);
            this.leftpanel.Controls.SetChildIndex(this.cartBtn, 0);
            this.leftpanel.Controls.SetChildIndex(this.Qtyupdown, 0);
            this.leftpanel.Controls.SetChildIndex(this.label10, 0);
            this.leftpanel.Controls.SetChildIndex(this.Emailtxt, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.dataGridView1);
            this.rightpanel.Controls.Add(this.panel5);
            this.rightpanel.Controls.Add(this.textBox1);
            this.rightpanel.Location = new System.Drawing.Point(274, 0);
            this.rightpanel.Size = new System.Drawing.Size(987, 782);
            this.rightpanel.Controls.SetChildIndex(this.textBox1, 0);
            this.rightpanel.Controls.SetChildIndex(this.panel5, 0);
            this.rightpanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Item";
            // 
            // ItemDD
            // 
            this.ItemDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemDD.Enabled = false;
            this.ItemDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ItemDD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDD.FormattingEnabled = true;
            this.ItemDD.Location = new System.Drawing.Point(10, 269);
            this.ItemDD.Name = "ItemDD";
            this.ItemDD.Size = new System.Drawing.Size(258, 33);
            this.ItemDD.TabIndex = 4;
            this.ItemDD.SelectedIndexChanged += new System.EventHandler(this.ItemDD_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "price";
            // 
            // pricetxt
            // 
            this.pricetxt.Enabled = false;
            this.pricetxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.Location = new System.Drawing.Point(10, 339);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(258, 31);
            this.pricetxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description to Chef";
            // 
            // desctxt
            // 
            this.desctxt.Enabled = false;
            this.desctxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desctxt.Location = new System.Drawing.Point(12, 505);
            this.desctxt.MaxLength = 50;
            this.desctxt.Multiline = true;
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(256, 78);
            this.desctxt.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 601);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Table Number";
            // 
            // TablenumberDD
            // 
            this.TablenumberDD.AllowDrop = true;
            this.TablenumberDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TablenumberDD.Enabled = false;
            this.TablenumberDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TablenumberDD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablenumberDD.FormattingEnabled = true;
            this.TablenumberDD.Location = new System.Drawing.Point(12, 641);
            this.TablenumberDD.Name = "TablenumberDD";
            this.TablenumberDD.Size = new System.Drawing.Size(259, 33);
            this.TablenumberDD.TabIndex = 10;
            this.TablenumberDD.SelectedIndexChanged += new System.EventHandler(this.TablenumberDD_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(12, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "Quantity";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 31);
            this.textBox1.TabIndex = 14;
            // 
            // cartBtn
            // 
            this.cartBtn.BackColor = System.Drawing.Color.DarkRed;
            this.cartBtn.Enabled = false;
            this.cartBtn.Location = new System.Drawing.Point(12, 692);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(224, 65);
            this.cartBtn.TabIndex = 15;
            this.cartBtn.Text = "Add to Cart";
            this.cartBtn.UseVisualStyleBackColor = false;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snogv,
            this.Email,
            this.Itemidgv,
            this.Item_namegv,
            this.Pricegv,
            this.Quantitygv,
            this.Desc_chefgv,
            this.Table_idgv,
            this.Table_Numbergv,
            this.deletegv});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(987, 492);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // 
            // snogv
            // 
            this.snogv.HeaderText = "#";
            this.snogv.MinimumWidth = 8;
            this.snogv.Name = "snogv";
            this.snogv.ReadOnly = true;
            this.snogv.Width = 59;
            // 
            // Email
            // 
            this.Email.HeaderText = "Emailgv";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            this.Email.Width = 110;
            // 
            // Itemidgv
            // 
            this.Itemidgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Itemidgv.HeaderText = "Item_ID";
            this.Itemidgv.MinimumWidth = 8;
            this.Itemidgv.Name = "Itemidgv";
            this.Itemidgv.ReadOnly = true;
            this.Itemidgv.Visible = false;
            this.Itemidgv.Width = 150;
            // 
            // Item_namegv
            // 
            this.Item_namegv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Item_namegv.HeaderText = "Item Name";
            this.Item_namegv.MinimumWidth = 8;
            this.Item_namegv.Name = "Item_namegv";
            this.Item_namegv.ReadOnly = true;
            this.Item_namegv.Width = 136;
            // 
            // Pricegv
            // 
            this.Pricegv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Pricegv.HeaderText = "Price";
            this.Pricegv.MinimumWidth = 8;
            this.Pricegv.Name = "Pricegv";
            this.Pricegv.ReadOnly = true;
            this.Pricegv.Width = 85;
            // 
            // Quantitygv
            // 
            this.Quantitygv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Quantitygv.HeaderText = "Quantity";
            this.Quantitygv.MinimumWidth = 8;
            this.Quantitygv.Name = "Quantitygv";
            this.Quantitygv.ReadOnly = true;
            this.Quantitygv.Width = 116;
            // 
            // Desc_chefgv
            // 
            this.Desc_chefgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Desc_chefgv.HeaderText = "Description to Chef";
            this.Desc_chefgv.MinimumWidth = 8;
            this.Desc_chefgv.Name = "Desc_chefgv";
            this.Desc_chefgv.ReadOnly = true;
            this.Desc_chefgv.Width = 201;
            // 
            // Table_idgv
            // 
            this.Table_idgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Table_idgv.HeaderText = "Table_id";
            this.Table_idgv.MinimumWidth = 8;
            this.Table_idgv.Name = "Table_idgv";
            this.Table_idgv.ReadOnly = true;
            this.Table_idgv.Visible = false;
            this.Table_idgv.Width = 150;
            // 
            // Table_Numbergv
            // 
            this.Table_Numbergv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Table_Numbergv.HeaderText = "Table Number";
            this.Table_Numbergv.MinimumWidth = 8;
            this.Table_Numbergv.Name = "Table_Numbergv";
            this.Table_Numbergv.ReadOnly = true;
            this.Table_Numbergv.Width = 158;
            // 
            // deletegv
            // 
            this.deletegv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.deletegv.HeaderText = "Remove";
            this.deletegv.MinimumWidth = 8;
            this.deletegv.Name = "deletegv";
            this.deletegv.Width = 82;
            // 
            // Qtyupdown
            // 
            this.Qtyupdown.Enabled = false;
            this.Qtyupdown.Location = new System.Drawing.Point(13, 418);
            this.Qtyupdown.Name = "Qtyupdown";
            this.Qtyupdown.Size = new System.Drawing.Size(255, 34);
            this.Qtyupdown.TabIndex = 16;
            this.Qtyupdown.ValueChanged += new System.EventHandler(this.Qtyupdown_ValueChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 652);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(987, 130);
            this.panel5.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Totallabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(987, 130);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Firebrick;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(487, 130);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Amount";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Totallabel
            // 
            this.Totallabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Totallabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallabel.ForeColor = System.Drawing.Color.Firebrick;
            this.Totallabel.Location = new System.Drawing.Point(496, 0);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(488, 130);
            this.Totallabel.TabIndex = 1;
            this.Totallabel.Text = "0.0";
            this.Totallabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 28);
            this.label10.TabIndex = 17;
            this.label10.Text = "Email";
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(8, 194);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(260, 34);
            this.Emailtxt.TabIndex = 18;
            this.Emailtxt.Leave += new System.EventHandler(this.Emailtxt_Leave);
            // 
            // OrdersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 785);
            this.Name = "OrdersWindow";
            this.Text = "OrdersWindow";
            this.Load += new System.EventHandler(this.OrdersWindow_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.rightpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qtyupdown)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ItemDD;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TablenumberDD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cartBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown Qtyupdown;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn snogv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itemidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_namegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pricegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantitygv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_chefgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_idgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Numbergv;
        private System.Windows.Forms.DataGridViewButtonColumn deletegv;
    }
}