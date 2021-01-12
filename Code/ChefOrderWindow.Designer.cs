
namespace RMS
{
    partial class ChefOrderWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_namegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantitygv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_chefgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LoadBtn = new System.Windows.Forms.Button();
            this.snogv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orderidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statusgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donebtngv = new System.Windows.Forms.DataGridViewButtonColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.dataGridView1);
            this.leftpanel.Size = new System.Drawing.Size(328, 651);
            this.leftpanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.LoadBtn);
            this.rightpanel.Controls.Add(this.dataGridView2);
            this.rightpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightpanel.Location = new System.Drawing.Point(328, 0);
            this.rightpanel.Size = new System.Drawing.Size(914, 651);
            this.rightpanel.Controls.SetChildIndex(this.dataGridView2, 0);
            this.rightpanel.Controls.SetChildIndex(this.LoadBtn, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snogv,
            this.Orderidgv,
            this.Statusgv,
            this.donebtngv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(328, 491);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView2.ColumnHeadersHeight = 34;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Item_namegv,
            this.Quantitygv,
            this.Desc_chefgv});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 160);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(914, 341);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 59;
            // 
            // Item_namegv
            // 
            this.Item_namegv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_namegv.HeaderText = "Item Name";
            this.Item_namegv.MinimumWidth = 8;
            this.Item_namegv.Name = "Item_namegv";
            this.Item_namegv.ReadOnly = true;
            // 
            // Quantitygv
            // 
            this.Quantitygv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantitygv.HeaderText = "Quantity";
            this.Quantitygv.MinimumWidth = 8;
            this.Quantitygv.Name = "Quantitygv";
            this.Quantitygv.ReadOnly = true;
            // 
            // Desc_chefgv
            // 
            this.Desc_chefgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc_chefgv.HeaderText = "Description to Chef";
            this.Desc_chefgv.MinimumWidth = 8;
            this.Desc_chefgv.Name = "Desc_chefgv";
            this.Desc_chefgv.ReadOnly = true;
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.Firebrick;
            this.LoadBtn.FlatAppearance.BorderSize = 2;
            this.LoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadBtn.ForeColor = System.Drawing.Color.White;
            this.LoadBtn.Location = new System.Drawing.Point(641, 604);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(125, 44);
            this.LoadBtn.TabIndex = 4;
            this.LoadBtn.Text = "Load Orders";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // snogv
            // 
            this.snogv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.snogv.HeaderText = "#";
            this.snogv.MinimumWidth = 8;
            this.snogv.Name = "snogv";
            this.snogv.ReadOnly = true;
            // 
            // Orderidgv
            // 
            this.Orderidgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Orderidgv.HeaderText = "Order ID";
            this.Orderidgv.MinimumWidth = 8;
            this.Orderidgv.Name = "Orderidgv";
            this.Orderidgv.ReadOnly = true;
            this.Orderidgv.Width = 123;
            // 
            // Statusgv
            // 
            this.Statusgv.HeaderText = "Status";
            this.Statusgv.MinimumWidth = 8;
            this.Statusgv.Name = "Statusgv";
            this.Statusgv.ReadOnly = true;
            this.Statusgv.Width = 101;
            // 
            // donebtngv
            // 
            this.donebtngv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.donebtngv.HeaderText = "Action";
            this.donebtngv.MinimumWidth = 8;
            this.donebtngv.Name = "donebtngv";
            this.donebtngv.Text = "Done";
            this.donebtngv.UseColumnTextForButtonValue = true;
            this.donebtngv.Width = 50;
            // 
            // ChefOrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 651);
            this.Name = "ChefOrderWindow";
            this.Text = "ChefOrderWindow";
            this.Load += new System.EventHandler(this.ChefOrderWindow_Load);
            this.leftpanel.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_namegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantitygv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_chefgv;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snogv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orderidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statusgv;
        private System.Windows.Forms.DataGridViewButtonColumn donebtngv;
    }
}