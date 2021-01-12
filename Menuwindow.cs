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
    public partial class Menuwindow : Sample2
    {
        public Menuwindow()
        {
            InitializeComponent();
        }

        private void rightpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public override void Delete_btn_click_Click(object sender, EventArgs e)
        {
            if (delStatus == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Delete.deleteData("rms.sp_DeleteMenuitems", "@Item_id", ItemID);
                    Mainclass.resetDisable(leftpanel);
                    Retriveal.getMenu(dataGridView1, Item_idgv, Item_namegv, Item_descgv, Item_pricegv);
                }
            }
        }
        int ItemID;
        public override void Save_btn_click_Click(object sender, EventArgs e)
        {
            if (Mainclass.CheckControls(leftpanel).Count == 0)
            {
                if (edit == 0)
                {
                    insert.insertMenu(itemnametxt.Text,Itemdesctxt.Text, Convert.ToSingle(pricetxt.Text));
                    Mainclass.resetDisable(leftpanel);
                    Retriveal.getMenu(dataGridView1, Item_idgv, Item_namegv, Item_descgv, Item_pricegv);
                }
                else if (edit == 1)
                {
                    updation.updateMenu(ItemID,itemnametxt.Text, Itemdesctxt.Text, Convert.ToSingle(pricetxt.Text));
                    Mainclass.resetDisable(leftpanel);
                    Retriveal.getMenu(dataGridView1, Item_idgv, Item_namegv, Item_descgv, Item_pricegv);
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
            Retriveal.getMenu(dataGridView1, Item_idgv, Item_namegv, Item_descgv, Item_pricegv);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                Mainclass.DisableControls(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ItemID = Convert.ToInt16(row.Cells["Item_idgv"].Value.ToString());
                itemnametxt.Text = row.Cells["Item_namegv"].Value.ToString();
                Itemdesctxt.Text = row.Cells["Item_descgv"].Value.ToString();
                pricetxt.Text = row.Cells["Item_pricegv"].Value.ToString();
                
            }
        }
    }
}
