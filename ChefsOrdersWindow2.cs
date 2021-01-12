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
    public partial class ChefsOrdersWindow2 : Form
    {
        public ChefsOrdersWindow2()
        {
            InitializeComponent();
        }


        private void ChefsOrdersWindow2_Load(object sender, EventArgs e)
        {
            Retriveal.getPendingorders(dataGridView1, Orderidgv, Statusgv);
            Mainclass.sno(dataGridView1, "snogv");
            Retriveal.loadItems("rms.sp_getChef", ChefDD, "Chef first Name", "Chef ID");
            ChefDD.SelectedIndex = -1;
        }
        Int64 OrderID;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                OrderID = Convert.ToInt64(row.Cells["Orderidgv"].Value.ToString());
                Retriveal.getPendingorderdetails(OrderID, dataGridView2, Item_namegv, Quantitygv, Desc_chefgv);
                Mainclass.sno(dataGridView1, "snogv");
                if (e.ColumnIndex == 3)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to Update Order Status?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {

                        if (ChefDD.SelectedIndex != -1)
                        {
                            updation.Updateorderstatus(OrderID, 1);
                            //OrderID = Convert.ToInt64(row.Cells["Orderidgv"].Value.ToString());
                            updation.Chefid_Orders(Convert.ToInt16(ChefDD.SelectedValue.ToString()), OrderID);
                            Retriveal.getPendingorders(dataGridView1, Orderidgv, Statusgv);
                            Mainclass.sno(dataGridView1, "snogv");
                        }


                    }
                }

            }

        }



       

        private void ChefDD_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void LoadBtn_Click_1(object sender, EventArgs e)
        {
            Retriveal.getPendingorders(dataGridView1, Orderidgv, Statusgv);
            Mainclass.sno(dataGridView1, "snogv");

        }

        
    }

}
