
namespace RMS
{
    partial class Settings
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
            this.Servertext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Databasetext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Usertext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Passwordtext = new System.Windows.Forms.TextBox();
            this.iscb = new System.Windows.Forms.CheckBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.Servererrorlable = new System.Windows.Forms.Label();
            this.Databaseerrorlable = new System.Windows.Forms.Label();
            this.useriderrorlable = new System.Windows.Forms.Label();
            this.Passworderrorlabel = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.savebutton);
            this.leftpanel.Controls.Add(this.Servertext);
            this.leftpanel.Controls.Add(this.iscb);
            this.leftpanel.Controls.Add(this.Passwordtext);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Controls.Add(this.Usertext);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.Databasetext);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.Databaseerrorlable);
            this.leftpanel.Controls.Add(this.Servererrorlable);
            this.leftpanel.Controls.Add(this.useriderrorlable);
            this.leftpanel.Controls.Add(this.Passworderrorlabel);
            this.leftpanel.Size = new System.Drawing.Size(282, 723);
            this.leftpanel.Controls.SetChildIndex(this.Passworderrorlabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.useriderrorlable, 0);
            this.leftpanel.Controls.SetChildIndex(this.Servererrorlable, 0);
            this.leftpanel.Controls.SetChildIndex(this.Databaseerrorlable, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.Databasetext, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.Usertext, 0);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.Passwordtext, 0);
            this.leftpanel.Controls.SetChildIndex(this.iscb, 0);
            this.leftpanel.Controls.SetChildIndex(this.Servertext, 0);
            this.leftpanel.Controls.SetChildIndex(this.savebutton, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Location = new System.Drawing.Point(282, 0);
            this.rightpanel.Size = new System.Drawing.Size(923, 723);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server Name";
            // 
            // Servertext
            // 
            this.Servertext.Location = new System.Drawing.Point(12, 196);
            this.Servertext.MaxLength = 50;
            this.Servertext.Name = "Servertext";
            this.Servertext.Size = new System.Drawing.Size(241, 34);
            this.Servertext.TabIndex = 3;
            this.Servertext.TextChanged += new System.EventHandler(this.Servertext_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Database";
            // 
            // Databasetext
            // 
            this.Databasetext.Location = new System.Drawing.Point(12, 277);
            this.Databasetext.MaxLength = 50;
            this.Databasetext.Name = "Databasetext";
            this.Databasetext.Size = new System.Drawing.Size(241, 34);
            this.Databasetext.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "User ID";
            // 
            // Usertext
            // 
            this.Usertext.Location = new System.Drawing.Point(12, 370);
            this.Usertext.MaxLength = 50;
            this.Usertext.Name = "Usertext";
            this.Usertext.Size = new System.Drawing.Size(241, 34);
            this.Usertext.TabIndex = 7;
            this.Usertext.TextChanged += new System.EventHandler(this.Usertext_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // Passwordtext
            // 
            this.Passwordtext.Location = new System.Drawing.Point(12, 468);
            this.Passwordtext.MaxLength = 50;
            this.Passwordtext.Name = "Passwordtext";
            this.Passwordtext.Size = new System.Drawing.Size(241, 34);
            this.Passwordtext.TabIndex = 9;
            this.Passwordtext.TextChanged += new System.EventHandler(this.Passwordtext_TextChanged);
            // 
            // iscb
            // 
            this.iscb.AutoSize = true;
            this.iscb.Location = new System.Drawing.Point(22, 519);
            this.iscb.Name = "iscb";
            this.iscb.Size = new System.Drawing.Size(204, 32);
            this.iscb.TabIndex = 10;
            this.iscb.Text = "Integrated Security";
            this.iscb.UseVisualStyleBackColor = true;
            this.iscb.CheckedChanged += new System.EventHandler(this.iscb_CheckedChanged);
            // 
            // savebutton
            // 
            this.savebutton.FlatAppearance.BorderSize = 2;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Location = new System.Drawing.Point(33, 583);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(160, 51);
            this.savebutton.TabIndex = 11;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // Servererrorlable
            // 
            this.Servererrorlable.AutoSize = true;
            this.Servererrorlable.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Servererrorlable.Location = new System.Drawing.Point(213, 139);
            this.Servererrorlable.Name = "Servererrorlable";
            this.Servererrorlable.Size = new System.Drawing.Size(31, 41);
            this.Servererrorlable.TabIndex = 12;
            this.Servererrorlable.Text = "*";
            this.Servererrorlable.Visible = false;
            // 
            // Databaseerrorlable
            // 
            this.Databaseerrorlable.AutoSize = true;
            this.Databaseerrorlable.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Databaseerrorlable.Location = new System.Drawing.Point(213, 220);
            this.Databaseerrorlable.Name = "Databaseerrorlable";
            this.Databaseerrorlable.Size = new System.Drawing.Size(31, 41);
            this.Databaseerrorlable.TabIndex = 13;
            this.Databaseerrorlable.Text = "*";
            this.Databaseerrorlable.Visible = false;
            // 
            // useriderrorlable
            // 
            this.useriderrorlable.AutoSize = true;
            this.useriderrorlable.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useriderrorlable.Location = new System.Drawing.Point(213, 314);
            this.useriderrorlable.Name = "useriderrorlable";
            this.useriderrorlable.Size = new System.Drawing.Size(31, 41);
            this.useriderrorlable.TabIndex = 14;
            this.useriderrorlable.Text = "*";
            this.useriderrorlable.Visible = false;
            // 
            // Passworderrorlabel
            // 
            this.Passworderrorlabel.AutoSize = true;
            this.Passworderrorlabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passworderrorlabel.Location = new System.Drawing.Point(213, 424);
            this.Passworderrorlabel.Name = "Passworderrorlabel";
            this.Passworderrorlabel.Size = new System.Drawing.Size(31, 41);
            this.Passworderrorlabel.TabIndex = 15;
            this.Passworderrorlabel.Text = "*";
            this.Passworderrorlabel.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 723);
            this.Name = "Settings";
            this.Text = "Settings";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox iscb;
        private System.Windows.Forms.TextBox Passwordtext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Usertext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Databasetext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Servertext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label Databaseerrorlable;
        private System.Windows.Forms.Label Servererrorlable;
        private System.Windows.Forms.Label useriderrorlable;
        private System.Windows.Forms.Label Passworderrorlabel;
    }
}