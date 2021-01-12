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
    public partial class Customers : Sample2
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            if (NameText.Text == "") { NameText.BackColor = Color.Firebrick; } else { NameText.BackColor = Color.White; }

        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {
            if (EmailText.Text == "") { EmailText.BackColor = Color.Firebrick; }
            else
            {
                EmailText.BackColor = Color.White;
            }
        }

        private void Phntxt_TextChanged(object sender, EventArgs e)
        {
            if (Phntxt.Text == "") { Phntxt.BackColor = Color.Firebrick; }
            else
            {
                Phntxt.BackColor = Color.White;
            }

        }

        private void pswdtxt_TextChanged(object sender, EventArgs e)
        {
            if (pswdtxt.Text == "") { pswdtxt.BackColor = Color.Firebrick; }
            else
            {
                pswdtxt.BackColor = Color.White;
            }

        }



        public override void Delete_btn_click_Click(object sender, EventArgs e)
        {
            if (delStatus == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Delete.deleteData("rms.sp_deletecustomers", "@customerid", customerID);
                    Mainclass.resetDisable(leftpanel);
                    Retriveal.getCustomers(dataGridView1, Customer_IDgv, Namegv, Emailgv, Passwordgv, PhoneGV);
                }
            }
        }
        int customerID;
        public override void Save_btn_click_Click(object sender, EventArgs e)
        {
            if (Mainclass.CheckControls(leftpanel).Count ==0)
            {
                if (edit ==0)
                {
                    insert.insertcustomer(NameText.Text, EmailText.Text, pswdtxt.Text, Phntxt.Text);
                    Mainclass.resetDisable(leftpanel);
                    Retriveal.getCustomers(dataGridView1, Customer_IDgv, Namegv, Emailgv, Passwordgv, PhoneGV);
                }
                else if (edit==1)
                {
                    updation.updatecustomer(customerID,NameText.Text, EmailText.Text, pswdtxt.Text, Phntxt.Text);
                    Mainclass.resetDisable(leftpanel);
                    Retriveal.getCustomers(dataGridView1, Customer_IDgv, Namegv, Emailgv, Passwordgv, PhoneGV);
                }
               // MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("please enter all fields");
            }
        }



        public override void View_Click(object sender, EventArgs e)
        {
            Retriveal.getCustomers(dataGridView1, Customer_IDgv, Namegv, Emailgv, Passwordgv, PhoneGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                Mainclass.DisableControls(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                customerID = Convert.ToInt16(row.Cells["Customer_IDgv"].Value.ToString());
                NameText.Text = row.Cells["Namegv"].Value.ToString();
                EmailText.Text = row.Cells["Emailgv"].Value.ToString();
                pswdtxt.Text = row.Cells["Passwordgv"].Value.ToString();
                Phntxt.Text = row.Cells["PhoneGV"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
