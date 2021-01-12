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
    public partial class ChefOrderWindow : Sample2
    {
        public ChefOrderWindow()
        {
            InitializeComponent();
        }

        private void ChefOrderWindow_Load(object sender, EventArgs e)
        {
            Retriveal.getPendingorders(dataGridView1,Orderidgv,Statusgv);
            Mainclass.sno(dataGridView1, "snogv");
            //timer1.Start();
            Add_btn_click.Visible = false;
            Edit_btn_click.Visible = false;
            Delete_btn_click.Visible = false;
            Save_btn_click.Visible = false;
            //View_Click.visible = false;
            

            
        }
        Int64 OrderID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1) ;
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                OrderID = Convert.ToInt64(row.Cells["Orderidgv"].Value.ToString());
                Retriveal.getPendingorderdetails(OrderID, dataGridView2,Item_namegv,Quantitygv,Desc_chefgv);
                Mainclass.sno(dataGridView1, "snogv");
                if (e.ColumnIndex ==3)
                {
                    DialogResult dr = MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation.Updateorderstatus(OrderID, 1);
                        Retriveal.getPendingorders(dataGridView1, Orderidgv, Statusgv);
                        Mainclass.sno(dataGridView1, "snogv");
                    }
                }

            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            Retriveal.getPendingorders(dataGridView1, Orderidgv, Statusgv);
            Mainclass.sno(dataGridView1, "snogv");
        }
    }
}
