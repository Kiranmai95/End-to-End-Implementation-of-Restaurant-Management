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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        private void Sample2_Load(object sender, EventArgs e)
        {

        }


        public virtual void Backbutton_Click(object sender, EventArgs e)
        {
            AdminHomeScreen adm = new AdminHomeScreen();
            Mainclass.ShowWindow(adm, MDI.ActiveForm);
        }
        public static int edit = 0;
        public static int delStatus = 0; 
        public virtual void Add_btn_click_Click(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.resetEnable(leftpanel);
            delStatus = 0;
        }

        public virtual void Edit_btn_click_Click(object sender, EventArgs e)
        {
            edit = 1;
            Mainclass.EnableControls(leftpanel);

        }

        public virtual void Delete_btn_click_Click(object sender, EventArgs e)
        {

        }

        public virtual void Save_btn_click_Click(object sender, EventArgs e)
        {

        }



        public virtual void View_Click(object sender, EventArgs e)
        {

        }
    }
}
