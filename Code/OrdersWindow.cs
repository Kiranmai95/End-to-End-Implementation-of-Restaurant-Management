using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace RMS
{
    public partial class OrdersWindow : Sample2
    {
        public OrdersWindow()
        {
            InitializeComponent();
        }


        
    private void ItemDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemDD.SelectedIndex!=-1)
            {
                try
                {
                    ItemDD.BackColor = Color.White;
                    SqlCommand cmd = new SqlCommand("rms.sp_getitemsWRTprice", Mainclass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Item_id", Convert.ToInt32(ItemDD.SelectedValue.ToString()));
                    Mainclass.con.Open();
                    
                    pricetxt.Text = Math.Round(Convert.ToDouble(cmd.ExecuteScalar().ToString()),0).ToString();
                    Mainclass.con.Close();

                }
                catch(Exception ex)
                {
                    Mainclass.con.Close();
                    Mainclass.ShowMessage(ex.Message, "Error");
                }
            }
            else
            {
                pricetxt.Text = "";
                pricetxt.BackColor = Color.White;
                ItemDD.BackColor = Color.Firebrick;
            }
        }

        private void OrdersWindow_Load(object sender, EventArgs e)
        {
            Retriveal.loadItems("rms.sp_getMenu", ItemDD, "Item", "ItemID");
            
            ItemDD.SelectedIndex = -1;
            Retriveal.loadItems("rms.getTables", TablenumberDD, "Table Number", "TableID");
            TablenumberDD.SelectedIndex = -1;
            ItemDD.BackColor = Color.White;
            TablenumberDD.BackColor = Color.White;
            Qtyupdown.BackColor = Color.White;
        }






        float totalamount = 0;
        private void cartBtn_Click(object sender, EventArgs e)
        {
            
            if (Mainclass.CheckControls(leftpanel).Count!=0)
            {
                Mainclass.ShowMessage("Fields with red are mandatory", "Error");
          
            }
            else
            {
                bool check = false;
                foreach(DataGridViewRow row in dataGridView1.Rows)
               {
                   if (row.Cells["Itemidgv"].Value  == ItemDD.SelectedValue)
                   {
                       check = true;
                        break;
                    }

               }
                
                DataRowView drvitem = ItemDD.SelectedItem as DataRowView;
                DataRowView drvtable = TablenumberDD.SelectedItem as DataRowView;
                if (check)
                {
                    Mainclass.ShowMessage("Item added already", "Error");
                }
                else
                {

                    totalamount += Convert.ToSingle(pricetxt.Text)* Convert.ToInt32(Qtyupdown.Value);
                    Totallabel.Text = totalamount.ToString();
                    dataGridView1.Rows.Add(null,Emailtxt.ToString(), Convert.ToInt32(ItemDD.SelectedValue.ToString()),
                    drvitem["Item"], Convert.ToSingle(pricetxt.Text)
                    , Convert.ToInt32(Qtyupdown.Text),
                    desctxt.Text.ToString(), Convert.ToInt32(TablenumberDD.SelectedValue.ToString()),
                   drvtable["Table Number"]);


                }
                       

               // dataGridView1.Rows.Add(row);
                

            }
            Mainclass.sno(dataGridView1, "snogv");
        }

        private void pricetxt_TextChanged(object sender, EventArgs e)
        {
            if (pricetxt.Text=="")
            { pricetxt.BackColor = Color.White; }
            else { pricetxt.BackColor = Color.Firebrick; }
        }

        private void TablenumberDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TablenumberDD.SelectedIndex!=-1)
            {
                TablenumberDD.BackColor = Color.White;
            }
            else { TablenumberDD.BackColor = Color.Firebrick; }
        }

        private void Qtyupdown_ValueChanged(object sender, EventArgs e)
        {
            if(Qtyupdown.Value==0)
            {
                Qtyupdown.BackColor = Color.Firebrick;
            }
            else { Qtyupdown.BackColor = Color.White; }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            
            if (e.RowIndex !=-1  && e.ColumnIndex !=-1)
            {
                if (e.ColumnIndex==9)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    
                    float prc = (Convert.ToSingle(row.Cells["Pricegv"].Value.ToString()))*(Convert.ToSingle(Qtyupdown.Value));
                    totalamount -= prc;
                    Totallabel.Text = totalamount.ToString();
                    dataGridView1.Rows.Remove(row);
                    Mainclass.sno(dataGridView1, "snogv");
                }

            }
        }
        public override void Delete_btn_click_Click(object sender, EventArgs e)
        {

        }

        private void InsertOrderdetails()
        {
            Int64 orderID = Retriveal.lastorderID();
            int count = 0;
            //for (int i =0; i< dataGridView1.Rows.Count;i++)
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                    //int idx = dataGridView1.SelectedIndex;
                 //   count += insert.insertOrderdetails(Convert.ToInt64(orderID), Convert.ToInt32(ItemDD.SelectedValue.ToString()),
                //      Convert.ToInt32(Qtyupdown.Value), Convert.ToInt32(pricetxt.Text));
                // count++;
                // dataGridView1.ClearSelection();
                string Sqlquery = "Insert into[rms].[Order_items] values (@Order_id, @item_id, @Quantity, @Unit_Price)";
                SqlCommand cmd = new SqlCommand(Sqlquery, Mainclass.con);
                cmd.Parameters.AddWithValue("@Order_id", Convert.ToInt64(orderID));
                cmd.Parameters.AddWithValue("@item_id", row.Cells["Itemidgv"].Value);
                cmd.Parameters.AddWithValue("@Quantity", row.Cells["Quantitygv"].Value);
                cmd.Parameters.AddWithValue("@Unit_Price", row.Cells["Pricegv"].Value);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                count++;


            }
            if (count > 0)
            {
                Mainclass.ShowMessage("Order Placed", "Success");
            }
            else
            {
                Mainclass.ShowMessage("Error Occured", "Error");

            }
        }
        public override void Save_btn_click_Click(object sender, EventArgs e)
        {
            using(TransactionScope sc = new TransactionScope())
            {
                try {
                    insert.insertOrder(Customer_id, 0, 
                        Convert.ToInt16(TablenumberDD.SelectedValue.ToString()), 
                        DateTime.Today, 0, desctxt.Text, 
                        Convert.ToSingle(Totallabel.Text));
                    InsertOrderdetails();
                 //   Int64 orderID = Retriveal.lastorderID();
//                   SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-3GK7KTP; Initial Catalog =Restaurant_Management; Integrated Security = true ; MultipleActiveResultSets=true");

//                    for (int i =0;i<dataGridView1.RowCount-1;i++)
//                    {
//                        SqlCommand cmd = new SqlCommand
//                            (@"Insert into [rms].[Order_items] (Order_id,item_id,Quantity,Unit_Price)
//values('" + Convert.ToInt64(orderID) + "','" + Convert.ToInt32(ItemDD.SelectedValue.ToString()) + "'" +
//",'" + Convert.ToInt32(Qtyupdown.Value) + "','" + Convert.ToInt32(pricetxt.Text) + "')");
//                        con.Open();
//                        cmd.ExecuteNonQuery();
//                        con.Close();
//                    }





                }
                catch { }
                sc.Complete();

            }
        }



        public override void View_Click(object sender, EventArgs e)
        {

        }
        Int16 Customer_id;


        private void Emailtxt_Leave(object sender, EventArgs e)
        {
            if (Emailtxt.Text != "")
            {
                Emailtxt.BackColor = Color.White;
                Customer_id = Retriveal.getCustomerid(Emailtxt.Text);
                if (Customer_id == 0)
                {
                    Customers cw = new Customers();
                    Mainclass.ShowWindow(cw, this, MDI.ActiveForm);
                }

            } 
        }

       
    }
}

