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
    public partial class Addchef : Sample2
    {
        public Addchef()
        {
            InitializeComponent();
        }

        int edit = 0; 
        int delStatus = 0;
        public override void Add_btn_click_Click(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.resetEnable(leftpanel);
            delStatus = 0;

        }
        public override void Edit_btn_click_Click(object sender, EventArgs e)
        {
            edit = 1;
            Mainclass.EnableControls(leftpanel);
        }
        public override void Save_btn_click_Click(object sender, EventArgs e)
        {
            if (Cheffntxt.Text =="") {Cheferrorlabel.Visible = true; } else {Cheferrorlabel.Visible = false;
            }
            if (Cheferrorlabel.Visible)
            {
                Mainclass.ShowMessage("Fields with * are mandatory", "Error");
            }
            else
            {
                if (edit ==0)
                {
                    insert.insertchef(Cheffntxt.Text, Cheflntxt.Text, phntxt.Text);
                    
                    Mainclass.resetDisable(leftpanel);
                    Retriveal.getChef(dataGridView1,ChefIDGV, ChefFnameGV, ChefLNameGV, PhoneGV);
                }
                else if(edit == 1)
                {

                    updation.updatechef(Cheffntxt.Text, Cheflntxt.Text, phntxt.Text, chefid);
                    Mainclass.resetDisable(leftpanel);
                    Retriveal.getChef(dataGridView1, ChefIDGV, ChefFnameGV, ChefLNameGV, PhoneGV);
                }
            }


        }
        private void Cheftxt_TextChanged(object sender, EventArgs e)
        {
            if (Cheffntxt.Text=="")
            {
                Cheferrorlabel.Visible = true;

            }
            else
            {
                Cheferrorlabel.Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public override void View_Click(object sender, EventArgs e)
        {
            Retriveal.getChef(dataGridView1, ChefIDGV, ChefFnameGV, ChefLNameGV, PhoneGV);
        }
        int chefid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex !=-1 && e.ColumnIndex!=-1)
            {
                edit = 1;
                delStatus = 1;
                Mainclass.DisableControls(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                chefid = Convert.ToInt16(row.Cells["ChefIDGV"].Value.ToString());
                Cheffntxt.Text = row.Cells["ChefFnameGV"].Value.ToString();
                Cheflntxt.Text = row.Cells["ChefLNameGV"].Value.ToString();
                phntxt.Text = row.Cells["PhoneGV"].Value.ToString();
            }
        }
        public override void Delete_btn_click_Click(object sender, EventArgs e)
        {
            if (delStatus==1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete this record?","Question", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr==DialogResult.Yes)
                {
                    Delete.deleteData("rms.sp_DeleteChef", "@Chef_id", chefid);
                    Mainclass.resetDisable(leftpanel);
                    Retriveal.getChef(dataGridView1, ChefIDGV, ChefFnameGV, ChefLNameGV, PhoneGV);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
