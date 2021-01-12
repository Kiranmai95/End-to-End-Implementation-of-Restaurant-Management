using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RMS
{
    class updation
    {

        public static void Chefid_Orders(int Chef_id,Int64 OrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("rms.sp_UpdateChefID", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Chef_id", Chef_id);
                cmd.Parameters.AddWithValue("@OrderID", OrderID);


                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                


            }
            catch (Exception)
            {
                Mainclass.con.Close();
                Mainclass.ShowMessage("unable to Update chefid.", "Error");
            }
        }
        public static void Updateorderstatus(Int64 OrderID, int status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("rms.sp_UpdateOrderStatus", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrderID", OrderID);
                cmd.Parameters.AddWithValue("@status", status);
                
                
                Mainclass.con.Open();
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.ShowMessage( " Order Status Updated successfully into the system", "success");
                }


            }
            catch (Exception)
            {
                Mainclass.con.Close();
                Mainclass.ShowMessage("unable to Update Status.", "Error");
            }
        }
        public static void updateMenu(int Item_id,string Item_name, string Item_desc, float Item_price)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("rms.sp_UpdateMenuitems", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Item_name", Item_name);
                cmd.Parameters.AddWithValue("@Item_desc", Item_desc);
                cmd.Parameters.AddWithValue("@Item_price", Item_price);
                cmd.Parameters.AddWithValue("@Item_id", Item_id);
                Mainclass.con.Open();
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.ShowMessage(Item_name + " Updated successfully into the system", "success");
                }


            }
            catch (Exception)
            {
                Mainclass.con.Close();
                Mainclass.ShowMessage("unable to save.\n possible error item may exit", "Error");
            }
        }
        public static void UpdateTables(int Table_Number, int Table_Chairs, string Table_Status, int Table_id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("rms.sp_insertChef", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Table_Number", Table_Number);
                cmd.Parameters.AddWithValue("@Chairs", Table_Chairs);
                cmd.Parameters.AddWithValue("@status", Table_Status);
                cmd.Parameters.AddWithValue("@Table_id", Table_id);
                Mainclass.con.Open();
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.ShowMessage(Table_Number + " Updated successfully into the system", "success");
                }


            }
            catch (Exception)
            {
                Mainclass.con.Close();
                Mainclass.ShowMessage("unable to Update.\n possible error Table may exit", "Error");
            }
        }
        public static void updatechef(string First_Name, string Last_Name, string Phone,int Chef_id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("rms.sp_UpdateChef", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@First_Name", First_Name);
                cmd.Parameters.AddWithValue("@Last_Name", Last_Name);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Chef_id", Chef_id);
                Mainclass.con.Open();
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.ShowMessage( "Updated successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.ShowMessage(ex.Message, "Error");
            }
        }


        public static void updatecustomer(int Customer_id,string Username, string Email, string password, string Phone)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("rms.sp_updatecustomers", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", Username);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@phone", Phone);
                cmd.Parameters.AddWithValue("@customerid", Customer_id);
                Mainclass.con.Open();
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.ShowMessage(Username + "Updated successfully into the system", "success");
                }


            }
            catch (Exception)
            {
                Mainclass.con.Close();
                Mainclass.ShowMessage("unable to save user.", "Error");
            }
        }
    }
}
