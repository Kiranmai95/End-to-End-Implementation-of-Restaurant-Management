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
using System.IO;

namespace RMS
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            if(!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\rms_connect"))
            //if (ConfigurationManager.ConnectionStrings["con"].ConnectionString == "")
            {
                Settings obj = new Settings();
                Mainclass.ShowWindow(obj, this);
            }
            else
            {
                LoginScreen ls = new LoginScreen();
                Mainclass.ShowWindow(ls, this);
            }
        }
        
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings obj = new Settings();
            Mainclass.ShowWindow(obj, this);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginScreen ls = new LoginScreen();
            Mainclass.ShowWindow(ls, this);
        }
    }
}
