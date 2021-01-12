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
    public partial class TablesWindow : Sample2
    {
        public TablesWindow()
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
                    Delete.deleteData("rms.sp_deletetables", "@Table_id", TableID);
                    Mainclass.resetDisable(leftpanel);
                    Retriveal.getTables(dataGridView1, Table_Numbergv, Table_Chairsgv, Table_Statusgv, Table_idgv);
                }
            }
        }
        int TableID;

        public override void Save_btn_click_Click(object sender, EventArgs e)
        {
            if (Mainclass.CheckControls(leftpanel).Count == 0)
            {
                if (edit == 0)
                {
                    insert.insertTables(Convert.ToInt32(TableNumberDD.SelectedItem.ToString()), Convert.ToInt32(chairsDD.SelectedItem.ToString()), StatusDD.SelectedItem.ToString());
                    Mainclass.resetDisable(leftpanel);
                    Retriveal.getTables(dataGridView1, Table_Numbergv, Table_Chairsgv, Table_Statusgv, Table_idgv);
                }
                else if (edit == 1)
                {
                    updation.UpdateTables(Convert.ToInt32(TableNumberDD.SelectedItem.ToString()), Convert.ToInt32(chairsDD.SelectedItem.ToString()), StatusDD.SelectedItem.ToString(), TableID);
                    Mainclass.resetDisable(leftpanel);
                    Retriveal.getTables(dataGridView1, Table_Numbergv, Table_Chairsgv, Table_Statusgv, Table_idgv);
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
            Retriveal.getTables(dataGridView1, Table_Numbergv, Table_Chairsgv, Table_Statusgv, Table_idgv);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                Mainclass.DisableControls(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                
                TableNumberDD.SelectedItem = row.Cells["Table_Numbergv"].Value.ToString();
                chairsDD.SelectedItem = row.Cells["Table_Chairsgv"].Value.ToString();
                StatusDD.SelectedItem = row.Cells["Table_Statusgv"].Value.ToString();
                TableID = Convert.ToInt16(row.Cells["Table_idgv"].Value.ToString());
            }
        }
    }
}
