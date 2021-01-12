
namespace RMS
{
    partial class TablesWindow
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
            this.TblNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TableNumberDD = new System.Windows.Forms.ComboBox();
            this.chairsDD = new System.Windows.Forms.ComboBox();
            this.StatusDD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snogv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_idgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Numbergv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Chairsgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Statusgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.StatusDD);
            this.leftpanel.Controls.Add(this.chairsDD);
            this.leftpanel.Controls.Add(this.TableNumberDD);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.TblNo);
            this.leftpanel.Size = new System.Drawing.Size(250, 728);
            this.leftpanel.Controls.SetChildIndex(this.TblNo, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.TableNumberDD, 0);
            this.leftpanel.Controls.SetChildIndex(this.chairsDD, 0);
            this.leftpanel.Controls.SetChildIndex(this.StatusDD, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.dataGridView1);
            this.rightpanel.Location = new System.Drawing.Point(251, 0);
            this.rightpanel.Size = new System.Drawing.Size(999, 728);
            this.rightpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightpanel_Paint);
            this.rightpanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // TblNo
            // 
            this.TblNo.AutoSize = true;
            this.TblNo.Location = new System.Drawing.Point(28, 174);
            this.TblNo.Name = "TblNo";
            this.TblNo.Size = new System.Drawing.Size(134, 28);
            this.TblNo.TabIndex = 3;
            this.TblNo.Text = "Table Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of Chairs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Table Status";
            // 
            // TableNumberDD
            // 
            this.TableNumberDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableNumberDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TableNumberDD.FormattingEnabled = true;
            this.TableNumberDD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.TableNumberDD.Location = new System.Drawing.Point(30, 205);
            this.TableNumberDD.Name = "TableNumberDD";
            this.TableNumberDD.Size = new System.Drawing.Size(214, 36);
            this.TableNumberDD.TabIndex = 9;
            // 
            // chairsDD
            // 
            this.chairsDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chairsDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chairsDD.FormattingEnabled = true;
            this.chairsDD.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8"});
            this.chairsDD.Location = new System.Drawing.Point(36, 298);
            this.chairsDD.Name = "chairsDD";
            this.chairsDD.Size = new System.Drawing.Size(214, 36);
            this.chairsDD.TabIndex = 10;
            // 
            // StatusDD
            // 
            this.StatusDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StatusDD.FormattingEnabled = true;
            this.StatusDD.Items.AddRange(new object[] {
            "Empty",
            "Occupied"});
            this.StatusDD.Location = new System.Drawing.Point(36, 398);
            this.StatusDD.Name = "StatusDD";
            this.StatusDD.Size = new System.Drawing.Size(214, 36);
            this.StatusDD.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snogv,
            this.Table_idgv,
            this.Table_Numbergv,
            this.Table_Chairsgv,
            this.Table_Statusgv});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(999, 568);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // snogv
            // 
            this.snogv.HeaderText = "";
            this.snogv.MinimumWidth = 8;
            this.snogv.Name = "snogv";
            this.snogv.Width = 150;
            // 
            // Table_idgv
            // 
            this.Table_idgv.HeaderText = "Table ID";
            this.Table_idgv.MinimumWidth = 4;
            this.Table_idgv.Name = "Table_idgv";
            this.Table_idgv.Visible = false;
            this.Table_idgv.Width = 150;
            // 
            // Table_Numbergv
            // 
            this.Table_Numbergv.HeaderText = "Table Number";
            this.Table_Numbergv.MinimumWidth = 4;
            this.Table_Numbergv.Name = "Table_Numbergv";
            this.Table_Numbergv.Width = 150;
            // 
            // Table_Chairsgv
            // 
            this.Table_Chairsgv.HeaderText = "No of Chairs";
            this.Table_Chairsgv.MinimumWidth = 4;
            this.Table_Chairsgv.Name = "Table_Chairsgv";
            this.Table_Chairsgv.Width = 150;
            // 
            // Table_Statusgv
            // 
            this.Table_Statusgv.HeaderText = "Table Status";
            this.Table_Statusgv.MinimumWidth = 4;
            this.Table_Statusgv.Name = "Table_Statusgv";
            this.Table_Statusgv.Width = 150;
            // 
            // TablesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 728);
            this.Name = "TablesWindow";
            this.Text = "TablesWindow";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TblNo;
        private System.Windows.Forms.ComboBox TableNumberDD;
        private System.Windows.Forms.ComboBox chairsDD;
        private System.Windows.Forms.ComboBox StatusDD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snogv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_idgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Numbergv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Chairsgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Statusgv;
    }
}