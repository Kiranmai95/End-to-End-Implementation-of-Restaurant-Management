using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RMS
{
    class Retriveal
    {
        public static void  getPendingorders(DataGridView gv, DataGridViewColumn Orderidgv, DataGridViewColumn Statusgv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("rms.Sp_get_orders", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Orderidgv.DataPropertyName = dt.Columns["Order ID"].ToString();
                Statusgv.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch(Exception ex)
            {
                Mainclass.ShowMessage(ex.Message, "Error");
                

            }
        }

        public static void getPendingorderdetails(Int64 OrderID,DataGridView gv,
            DataGridViewColumn Item_namegv, DataGridViewColumn Quantitygv, DataGridViewColumn Desc_chefgv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("rms.Sp_get_orders_detailswrtchef", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Order_id", OrderID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Item_namegv.DataPropertyName = dt.Columns["Item Name"].ToString();
                Quantitygv.DataPropertyName = dt.Columns["Quantity"].ToString();
                Desc_chefgv.DataPropertyName = dt.Columns["Note to Chef"].ToString();
                gv.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                Mainclass.ShowMessage(ex.Message, "Error");


            }
        }
        public static Int16 getCustomerid(string Email)
        {
            Int16 Customer_id = 0;
            try {
                SqlCommand cmd = new SqlCommand("rms.sp_getcustomeridWRTEmail", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", Email);
                Mainclass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                //Mainclass.con.Close();
                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                        Customer_id = Convert.ToInt16(dr["Customer_id"].ToString());

                    }
                }
                else
                {
                    Customer_id = 0;
                    
                }
                Mainclass.con.Close();
            }
            catch(Exception ex) {
                Mainclass.ShowMessage(ex.Message, "Error");
            }
         return Customer_id;
        }
        public static void getMenu(DataGridView gv, DataGridViewColumn Item_idgv, DataGridViewColumn Item_namegv, DataGridViewColumn Item_descgv, DataGridViewColumn Item_pricegv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("rms.sp_getMenu", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Item_idgv.DataPropertyName = dt.Columns["ItemID"].ToString();
                Item_namegv.DataPropertyName = dt.Columns["Item"].ToString();
                Item_descgv.DataPropertyName = dt.Columns["Description"].ToString();
                Item_pricegv.DataPropertyName = dt.Columns["Price"].ToString();

                gv.DataSource = dt;
                Mainclass.sno(gv, "snogv");

            }
            catch (Exception ex)
            {
                Mainclass.ShowMessage(ex.Message, "Error");
            }
        }




        public static void getTables(DataGridView gv, DataGridViewColumn Table_Numbergv, DataGridViewColumn Table_Chairsgv, DataGridViewColumn Table_Statusgv, DataGridViewColumn Table_idgv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("rms.getTables", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Table_Numbergv.DataPropertyName = dt.Columns["Table Number"].ToString();
                Table_Chairsgv.DataPropertyName = dt.Columns["Chairs"].ToString();
                Table_Statusgv.DataPropertyName = dt.Columns["Status"].ToString();
                Table_idgv.DataPropertyName = dt.Columns["TableID"].ToString();

                gv.DataSource = dt;
                Mainclass.sno(gv, "snogv");

            }
            catch (Exception ex)
            {
                Mainclass.ShowMessage(ex.Message, "Error");
            }
        }
        public static void getChef(DataGridView gv, DataGridViewColumn ChefIDGV, DataGridViewColumn ChefFnameGV, DataGridViewColumn ChefLNameGV, DataGridViewColumn PhoneGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("rms.sp_getChef", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ChefIDGV.DataPropertyName = dt.Columns["Chef ID"].ToString();
                ChefFnameGV.DataPropertyName = dt.Columns["Chef first Name"].ToString();
                ChefLNameGV.DataPropertyName = dt.Columns["Chef Last Name"].ToString();
                PhoneGV.DataPropertyName = dt.Columns["Phone Number"].ToString();
                gv.DataSource = dt;
                Mainclass.sno(gv, "snogv");

            }
            catch (Exception ex)
            {
                Mainclass.ShowMessage(ex.Message, "Error");
            }
        }

        private static string name;
        public static string EMAIL
        {
            get 
            {
                return name;
            }
           private set
            {
                name = value;
            }
        }
        public static bool isvalidcustomer(string Email, string password )
        {
            bool status = false;
            try
            {
                
                SqlCommand cmd = new SqlCommand("rms.sp_getuserAuth", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@password", password);
                Mainclass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (Email == dr["Email"].ToString() && password == dr["Password"].ToString())
                        {
                            EMAIL = dr["Email"].ToString();
                            status = true;
                        }
                        else
                        {
                            Mainclass.ShowMessage("Invaild username or password","Error");
                            status = false;
                        }
                    }
                }
                else
                {
                    Mainclass.ShowMessage("Invaild username or password", "Error");
                    status = false;
                }


                Mainclass.con.Close();

            }
            catch (Exception ex)
            {
                Mainclass.ShowMessage(ex.Message, "Error");
                    }
            return status;
}
        public static void getCustomers(DataGridView gv, DataGridViewColumn Customer_IDgv, DataGridViewColumn Namegv, DataGridViewColumn Emailgv, DataGridViewColumn Passwordgv, DataGridViewColumn PhoneGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("rms.sp_getcustomers", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Customer_IDgv.DataPropertyName = dt.Columns["Customer_ID"].ToString();
                Namegv.DataPropertyName = dt.Columns["Name"].ToString();
                Emailgv.DataPropertyName = dt.Columns["Email"].ToString();
                Passwordgv.DataPropertyName = dt.Columns["Password"].ToString();
                PhoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                gv.DataSource = dt;
                Mainclass.sno(gv, "snogv");

            }
            catch (Exception ex)
            {
                Mainclass.ShowMessage(ex.Message, "Error");
            }
        }
        
        public static void loadItems(string proc, ComboBox cb,string dMember,string vMember,string param=null,int val=0)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (param==null && val ==0)
                {
                   
                }
                else
                {
                    cmd.Parameters.AddWithValue(param, val);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = dMember;
                cb.ValueMember = vMember;
                cb.DataSource = dt;

            }
            catch(Exception)
            {
                throw;
            }
        }

        
        public static Int64 lastorderID()
        {
            Int64 orderID = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("rms.Sp_getLastOrderID", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                Mainclass.con.Open();
                orderID = Convert.ToInt64(cmd.ExecuteScalar().ToString());
                Mainclass.con.Close();

            }
            catch (Exception)
            {
                
            }
            return orderID;
        }


    }
}
