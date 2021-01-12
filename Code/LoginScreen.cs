using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS
{
    public partial class LoginScreen : Sample
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (Mainclass.CheckControls(leftpanel).Count==0)
            {
                if(Retriveal.isvalidcustomer(Emailtext.Text,passwordtext.Text))
                {
                    AdminHomeScreen rw = new AdminHomeScreen();
                    Mainclass.ShowWindow(rw, this, MDI.ActiveForm);
                }
                else { }

                

            }
            
        }

        private void passwordtext_TextChanged(object sender, EventArgs e)
        {
            if (passwordtext.Text == "") { passwordtext.BackColor = Color.Firebrick; } else { passwordtext.BackColor = Color.White; }
        }

        private void Emailtext_TextChanged(object sender, EventArgs e)
        {
            if (Emailtext.Text == "") { Emailtext.BackColor = Color.Firebrick; } else { Emailtext.BackColor = Color.White; }
        }
    }
}
