
namespace RMS
{
    partial class ChefsOrdersWindow2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snogv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orderidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statusgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donebtngv = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Backbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ChefDD = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_namegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantitygv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_chefgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.LeftPanel.Controls.Add(this.dataGridView1);
            this.LeftPanel.Controls.Add(this.panel2);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.ForeColor = System.Drawing.Color.White;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(465, 704);
            this.LeftPanel.TabIndex = 0;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(465, 582);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // snogv
            // 
            this.snogv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snogv.HeaderText = "#";
            this.snogv.MinimumWidth = 8;
            this.snogv.Name = "snogv";
            this.snogv.ReadOnly = true;
            this.snogv.Width = 54;
            // 
            // Orderidgv
            // 
            this.Orderidgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Orderidgv.HeaderText = "Order ID";
            this.Orderidgv.MinimumWidth = 8;
            this.Orderidgv.Name = "Orderidgv";
            this.Orderidgv.ReadOnly = true;
            // 
            // Statusgv
            // 
            this.Statusgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Statusgv.HeaderText = "Status";
            this.Statusgv.MinimumWidth = 8;
            this.Statusgv.Name = "Statusgv";
            this.Statusgv.ReadOnly = true;
            // 
            // donebtngv
            // 
            this.donebtngv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donebtngv.HeaderText = "Action";
            this.donebtngv.MinimumWidth = 8;
            this.donebtngv.Name = "donebtngv";
            this.donebtngv.Text = "Done";
            this.donebtngv.UseColumnTextForButtonValue = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Backbutton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 122);
            this.panel2.TabIndex = 0;
            // 
            // Backbutton
            // 
            this.Backbutton.ForeColor = System.Drawing.Color.Black;
            this.Backbutton.Location = new System.Drawing.Point(390, 87);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 35);
            this.Backbutton.TabIndex = 1;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Chefs";
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.panel3);
            this.RightPanel.Controls.Add(this.dataGridView2);
            this.RightPanel.Controls.Add(this.panel1);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RightPanel.Location = new System.Drawing.Point(465, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(770, 704);
            this.RightPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.ChefDD);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 463);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 241);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Firebrick;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Order Processed by";
            // 
            // ChefDD
            // 
            this.ChefDD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ChefDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChefDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChefDD.FormattingEnabled = true;
            this.ChefDD.Location = new System.Drawing.Point(0, 32);
            this.ChefDD.Name = "ChefDD";
            this.ChefDD.Size = new System.Drawing.Size(229, 28);
            this.ChefDD.TabIndex = 6;
            this.ChefDD.SelectedIndexChanged += new System.EventHandler(this.ChefDD_SelectedIndexChanged);
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
            this.dataGridView2.Location = new System.Drawing.Point(0, 122);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(770, 341);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 54;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 122);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LoadBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 122);
            this.panel4.TabIndex = 6;
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.Firebrick;
            this.LoadBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoadBtn.FlatAppearance.BorderSize = 2;
            this.LoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.ForeColor = System.Drawing.Color.White;
            this.LoadBtn.Location = new System.Drawing.Point(0, 78);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(200, 44);
            this.LoadBtn.TabIndex = 5;
            this.LoadBtn.Text = "Load Orders";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click_1);
            // 
            // ChefsOrdersWindow2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 704);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "ChefsOrdersWindow2";
            this.Text = "ChefsOrdersWindow2";
            this.Load += new System.EventHandler(this.ChefsOrdersWindow2_Load);
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_namegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantitygv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_chefgv;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snogv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orderidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statusgv;
        private System.Windows.Forms.DataGridViewButtonColumn donebtngv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ChefDD;
        private System.Windows.Forms.Panel panel4;
    }
}