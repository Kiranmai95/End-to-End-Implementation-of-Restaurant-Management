using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RMS
{
    class Delete
    {
        public static void deleteData(string procedure, string param,int value)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedure, Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param,value);
                Mainclass.con.Open();
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.ShowMessage("data deleted successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.ShowMessage(ex.Message, "Error");
            }
        }
    }
}
