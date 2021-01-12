
namespace RMS
{
    partial class Sample2
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Add_btn_click = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.GroupBox();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.Edit_btn_click = new System.Windows.Forms.Button();
            this.Save_btn_click = new System.Windows.Forms.Button();
            this.Delete_btn_click = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Backbutton = new System.Windows.Forms.Button();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Search.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.panel4);
            this.leftpanel.Size = new System.Drawing.Size(314, 522);
            this.leftpanel.Controls.SetChildIndex(this.panel4, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.panel3);
            this.rightpanel.Dock = System.Windows.Forms.DockStyle.None;
            this.rightpanel.Location = new System.Drawing.Point(317, 0);
            this.rightpanel.Size = new System.Drawing.Size(932, 522);
            this.rightpanel.Controls.SetChildIndex(this.panel3, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 100);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel1.Controls.Add(this.Add_btn_click, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Search, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.Edit_btn_click, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Save_btn_click, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Delete_btn_click, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.View, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(932, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Add_btn_click
            // 
            this.Add_btn_click.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_btn_click.FlatAppearance.BorderSize = 2;
            this.Add_btn_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn_click.Location = new System.Drawing.Point(3, 3);
            this.Add_btn_click.Name = "Add_btn_click";
            this.Add_btn_click.Size = new System.Drawing.Size(137, 94);
            this.Add_btn_click.TabIndex = 5;
            this.Add_btn_click.Text = "&ADD";
            this.Add_btn_click.UseVisualStyleBackColor = true;
            this.Add_btn_click.Click += new System.EventHandler(this.Add_btn_click_Click);
            // 
            // Search
            // 
            this.Search.Controls.Add(this.SearchText);
            this.Search.ForeColor = System.Drawing.Color.SteelBlue;
            this.Search.Location = new System.Drawing.Point(718, 3);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(208, 94);
            this.Search.TabIndex = 4;
            this.Search.TabStop = false;
            this.Search.Text = "SEARCH";
            // 
            // SearchText
            // 
            this.SearchText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchText.Location = new System.Drawing.Point(3, 27);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(202, 31);
            this.SearchText.TabIndex = 0;
            // 
            // Edit_btn_click
            // 
            this.Edit_btn_click.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Edit_btn_click.FlatAppearance.BorderSize = 2;
            this.Edit_btn_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_btn_click.Location = new System.Drawing.Point(146, 3);
            this.Edit_btn_click.Name = "Edit_btn_click";
            this.Edit_btn_click.Size = new System.Drawing.Size(137, 94);
            this.Edit_btn_click.TabIndex = 6;
            this.Edit_btn_click.Text = "&EDIT";
            this.Edit_btn_click.UseVisualStyleBackColor = true;
            this.Edit_btn_click.Click += new System.EventHandler(this.Edit_btn_click_Click);
            // 
            // Save_btn_click
            // 
            this.Save_btn_click.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save_btn_click.FlatAppearance.BorderSize = 2;
            this.Save_btn_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_btn_click.Location = new System.Drawing.Point(289, 3);
            this.Save_btn_click.Name = "Save_btn_click";
            this.Save_btn_click.Size = new System.Drawing.Size(137, 94);
            this.Save_btn_click.TabIndex = 7;
            this.Save_btn_click.Text = "&SAVE";
            this.Save_btn_click.UseVisualStyleBackColor = true;
            this.Save_btn_click.Click += new System.EventHandler(this.Save_btn_click_Click);
            // 
            // Delete_btn_click
            // 
            this.Delete_btn_click.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_btn_click.FlatAppearance.BorderSize = 2;
            this.Delete_btn_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn_click.Location = new System.Drawing.Point(432, 3);
            this.Delete_btn_click.Name = "Delete_btn_click";
            this.Delete_btn_click.Size = new System.Drawing.Size(137, 94);
            this.Delete_btn_click.TabIndex = 8;
            this.Delete_btn_click.Text = "&DELETE";
            this.Delete_btn_click.UseVisualStyleBackColor = true;
            this.Delete_btn_click.Click += new System.EventHandler(this.Delete_btn_click_Click);
            // 
            // View
            // 
            this.View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.View.FlatAppearance.BorderSize = 2;
            this.View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View.Location = new System.Drawing.Point(575, 3);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(137, 94);
            this.View.TabIndex = 9;
            this.View.Text = "&VIEW";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Backbutton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 100);
            this.panel4.TabIndex = 2;
            // 
            // Backbutton
            // 
            this.Backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbutton.Location = new System.Drawing.Point(128, 6);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 42);
            this.Backbutton.TabIndex = 0;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Sample2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 522);
            this.Name = "Sample2";
            this.Text = "";
            this.Load += new System.EventHandler(this.Sample2_Load);
            this.leftpanel.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.GroupBox Search;
        public System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Backbutton;
        public System.Windows.Forms.Button Add_btn_click;
        public System.Windows.Forms.Button Edit_btn_click;
        public System.Windows.Forms.Button Save_btn_click;
        public System.Windows.Forms.Button Delete_btn_click;
        public System.Windows.Forms.Button View;
    }
}