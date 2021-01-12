using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RMS
{
    class insert
    {
        public static void insertOrder( int Customer_id,int Chef_id,int Table_id, DateTime Order_datetime,
            int Order_Status, string Desc_Chef,float Total_bill)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("rms.sp_insertorders", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Customer_id", Customer_id);
                cmd.Parameters.AddWithValue("@Chef_id", Chef_id);
                cmd.Parameters.AddWithValue("@Table_id", Table_id);
                cmd.Parameters.AddWithValue("@Order_datetime", Order_datetime);
                cmd.Parameters.AddWithValue("@Order_Status", Order_Status);
                cmd.Parameters.AddWithValue("@Desc_Chef", Desc_Chef);
                cmd.Parameters.AddWithValue("@Total_bill", Total_bill);
                Mainclass.con.Open();
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.ShowMessage( " order placed successfully", "success");
                }


            }
            catch (Exception)
            {
                Mainclass.con.Close();
                Mainclass.ShowMessage("unable to save order", "Error");
            }
        }

        public static int insertOrderdetails(Int64 Order_id, int item_id , int Quantity, int Unit_Price )
        {
           int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("rms.sp_insertorder_details", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@Order_id", Order_id);
                cmd.Parameters.AddWithValue("@item_id", item_id);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                cmd.Parameters.AddWithValue("@Unit_Price", Unit_Price);
                Mainclass.con.Open();
                res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
              


            }
            catch (Exception)
            {
                Mainclass.con.Close();
                Mainclass.ShowMessage("unable to save order", "Error");
            }
          return res;
        }
        public static void insertMenu(string Item_name, string Item_desc, float Item_price)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("rms.sp_insertMenuitems", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Item_name", Item_name);
                cmd.Parameters.AddWithValue("@Item_desc", Item_desc);
                cmd.Parameters.AddWithValue("@Item_price", Item_price);
                Mainclass.con.Open();
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.ShowMessage(Item_name + " added successfully into the system", "success");
                }


            }
            catch (Exception)
            {
                Mainclass.con.Close();
                Mainclass.ShowMessage("unable to save.\n possible error item may exit", "Error");
            }
        }
        public static void insertTables(int Table_Number, int Table_Chairs, string Table_Status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("rms.sp_insertTables", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Table_Number", Table_Number);
                cmd.Parameters.AddWithValue("@Chairs", Table_Chairs);
                cmd.Parameters.AddWithValue("@status", Table_Status);
                Mainclass.con.Open();
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.ShowMessage(Table_Number + " added successfully into the system", "success");
                }


            }
            catch (Exception)
            {
                Mainclass.con.Close();
                Mainclass.ShowMessage("unable to save.\n possible error Table may exit", "Error");
            }
        }
        public static void insertchef(string First_Name,string Last_Name, string Phone)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("rms.sp_insertChef", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@First_Name", First_Name);
                cmd.Parameters.AddWithValue("@Last_Name", Last_Name);
                cmd.Parameters.AddWithValue( "@Phone", Phone);
                Mainclass.con.Open();
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if(res>0)
                {
                    Mainclass.ShowMessage(First_Name+ "Chef added successfully into the system", "success");
                }


            }
            catch (Exception)
            {
                Mainclass.con.Close();
                Mainclass.ShowMessage("unable to save.\n possible error chef may exit", "Error");
            }
        }
        public static void insertcustomer(string Username, string Email, string password, string Phone)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("rms.sp_insertcustomers", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", Username);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@phone", Phone);
                Mainclass.con.Open();
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.ShowMessage(Username + "added successfully into the system", "success");
                }


            }
            catch (Exception)
            {
                Mainclass.con.Close();
                Mainclass.ShowMessage("unable to save user.\n possible error chef may exit", "Error");
            }
        }
    }
}
