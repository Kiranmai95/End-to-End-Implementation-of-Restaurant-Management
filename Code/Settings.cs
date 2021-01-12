using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using System.IO;
namespace RMS
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Servertext_TextChanged(object sender, EventArgs e)
        {
            if (Servertext.Text=="") { Servererrorlable.Visible = true; } else { Servererrorlable.Visible = false; }
        }
        private void Databasetext_TextChanged(object sender, EventArgs e)
        {
            if (Databasetext.Text == "") { Servererrorlable.Visible = true; } else { Databaseerrorlable.Visible = false; }
        }

        private void iscb_CheckedChanged(object sender, EventArgs e)
        {
            if (iscb.Checked)
            {
                useriderrorlable.Visible = false;
                Passworderrorlabel.Visible = false;
                Usertext.Enabled = false;
                Passwordtext.Enabled = false;
                Usertext.Text = "";
                Passwordtext.Text = "";
            }
            else
            {
                Usertext.Enabled = true;
                Passwordtext.Enabled = true;
            }
        }

        private void Usertext_TextChanged(object sender, EventArgs e)
        {
            if (iscb.Checked)
            {
                if (Usertext.Text == "") { useriderrorlable.Visible = true; } else { useriderrorlable.Visible = false; }
            } 
        }

        private void Passwordtext_TextChanged(object sender, EventArgs e)
        {
            if (iscb.Checked)
            {
                if (Passwordtext.Text == "") { Passworderrorlabel.Visible = true; } else { Passworderrorlabel.Visible = false; }
            }

        }
        public void updateConfigFile(string con)
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    xElement.FirstChild.Attributes[2].Value = con;
                }
            }

            XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("connectionStrings");
        
        }
        string connection;
        private void saveConnection()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\rms_connect";
            File.WriteAllText(path, connection);
        }
        private void savebutton_Click(object sender, EventArgs e)
        {
            if (iscb.Checked)
            {
                if (Servertext.Text == "") { Servererrorlable.Visible = true; } else { Servererrorlable.Visible = false; }
                if (Databasetext.Text == "") { Databaseerrorlable.Visible = true; } else { Databaseerrorlable.Visible = false; }
                if(Servererrorlable.Visible || Databaseerrorlable.Visible) {
                    Mainclass.ShowMessage("Fields with * are mandatory.", "Error");
                }
                else
                {
                    connection = "Data Source =" + Servertext.Text +
                        "; Initial Catalog =" + Databasetext.Text +
                        "; Integrated Security = true ; MultipleActiveResultSets=true;";
                    saveConnection();
                    DialogResult dr = MessageBox.Show("Settings saved successfully","Sucess",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        LoginScreen ls = new LoginScreen();
                        Mainclass.ShowWindow(ls, this, MDI.ActiveForm);
                    }
                    
                    
                }
            }
            else
            {

                if (Servertext.Text == "") { Servererrorlable.Visible = true; } else { Servererrorlable.Visible = false; }
                if (Databasetext.Text == "") { Databaseerrorlable.Visible = true; } else { Databaseerrorlable.Visible = false; }
                if (Usertext.Text == "") { useriderrorlable.Visible = true; } else { useriderrorlable.Visible = false; }
                if (Passwordtext.Text == "") { Passworderrorlabel.Visible = true; } else { Passworderrorlabel.Visible = false; }
                if (Servererrorlable.Visible || Databaseerrorlable.Visible ||useriderrorlable.Visible || Passworderrorlabel.Visible)
                {
                    Mainclass.ShowMessage("Fields with * are mandatory.", "Error");
                }
                else
                {
                    connection = "Data Source =" + Servertext.Text + "; Initial Catalog =" + Databasetext.Text +
                       ";User ID ="+Usertext.Text +";Passwords="+Passwordtext.Text+"; MultipleActiveResultSets=true;";
                    saveConnection();
                    //updateConfigFile(connection);
                    DialogResult dr = MessageBox.Show("Settings saved successfully","Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {

                        LoginScreen ls = new LoginScreen();
                        Mainclass.ShowWindow(ls, this, MDI.ActiveForm);

                    }
                }
            }
        }
    }
}
