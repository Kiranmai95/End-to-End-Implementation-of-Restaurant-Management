
namespace RMS
{
    partial class LoginScreen
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
            this.Emailtext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.leftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.Loginbutton);
            this.leftpanel.Controls.Add(this.passwordtext);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.Emailtext);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.Emailtext, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.passwordtext, 0);
            this.leftpanel.Controls.SetChildIndex(this.Loginbutton, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(639, 562);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Emailtext
            // 
            this.Emailtext.Location = new System.Drawing.Point(0, 146);
            this.Emailtext.Name = "Emailtext";
            this.Emailtext.Size = new System.Drawing.Size(244, 34);
            this.Emailtext.TabIndex = 3;
            this.Emailtext.TextChanged += new System.EventHandler(this.Emailtext_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // passwordtext
            // 
            this.passwordtext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordtext.Location = new System.Drawing.Point(0, 233);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(244, 34);
            this.passwordtext.TabIndex = 5;
            this.passwordtext.UseSystemPasswordChar = true;
            this.passwordtext.TextChanged += new System.EventHandler(this.passwordtext_TextChanged);
            // 
            // Loginbutton
            // 
            this.Loginbutton.FlatAppearance.BorderSize = 2;
            this.Loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbutton.Location = new System.Drawing.Point(27, 287);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(160, 51);
            this.Loginbutton.TabIndex = 6;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // LoginScreen
            // 
            this.AcceptButton = this.Loginbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 562);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "LoginScreen";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Emailtext;
        private System.Windows.Forms.Label label3;
    }
}