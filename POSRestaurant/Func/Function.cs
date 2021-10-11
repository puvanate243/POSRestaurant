using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;
using System.Drawing;

namespace POSRestaurant.Func
{
    public class Function
    {
        //Property
        private static Panel_Order _panel_Order;
        public static Panel_Order panel_Order 
        {
            get { return _panel_Order; }
            set { _panel_Order = value; }
        }

        

        //Connect SQL
        public static DataTable ConnectDatabase(string sCommand)
        {
            const string strConnection = "POSRestaurantDatabase";

            SqlConnection conn = new SqlConnection();
            conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[strConnection].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter(sCommand, conn);


            DataTable dataTable = new DataTable();

            try
            {

                int recordsAffected = da.Fill(dataTable);

                if (recordsAffected > 0)
                {
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        System.Console.WriteLine(dr[0]);
                    }
                }

                return dataTable;
            }
            catch (OleDbException e)
            {
                string msg = "";
                for (int i = 0; i < e.Errors.Count; i++)
                {
                    msg += "Error #" + i + " Message: " + e.Errors[i].Message + "\n";
                }
                System.Console.WriteLine(msg);

                return null;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
        public static int ConnectDatabase(List<string> sCommandList)
        {
            int cnt = 0;
            System.Text.StringBuilder Sb = new System.Text.StringBuilder();
            foreach (string sCommand in sCommandList)
            {
                Sb.Append(sCommand.Replace(System.Environment.NewLine, "") + ";" + System.Environment.NewLine);
                cnt++;

                if (cnt > 10000)
                {
                    ConnectDatabase(Sb.ToString());
                    Sb = new System.Text.StringBuilder();
                    cnt = 0;
                }
            }
            if ("" != Sb.ToString())
            {
                ConnectDatabase(Sb.ToString());
            }
            return 0;

        }
        public static SqlDataAdapter ConnectDatabaseSqlDataAdapter(string sCommand)
        {
            const string strConnection = "POSRestaurantDatabase";
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[strConnection].ConnectionString);
            conn.Open();
            SqlCommand sql = new SqlCommand(sCommand, conn);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            return da;
        }
        public static SqlDataReader ConnectDatabaseSqlDataReader(string sCommand)
        {
            const string strConnection = "POSRestaurantDatabase";
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[strConnection].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sCommand, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        //Convert
        public static double ConvertDouble(string str)
        {
            double d;
            if (double.TryParse(str, out d))
            {
                return d;
            }
            else
            {
                return 0;
            }
        }
        public static int ConvertInt(string str)
        {
            int i;
            if (int.TryParse(str, out i))
            {
                return i;
            }
            else
            {
                return 0;
            }
        }
        public static DateTime? ConvertDate(string str)
        {
            DateTime dt_out;
            if (true == DateTime.TryParse(str, out dt_out))
            {
                return dt_out;
            }
            else
            {
                if (3 == str.Split('/').Length)
                {
                    string str2 = str.Split('/')[2] + "/" + str.Split('/')[1] + "/" + str.Split('/')[0];
                    if (true == DateTime.TryParse(str2, out dt_out))
                    {
                        return dt_out;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }


        //Get ID
        public static string GetIdByName_Table(string name)
        {
            string id = "";
            string sql = @"SELECT [TABLE_ID] FROM [MT_TABLE] WHERE [TABLE_NAME] = '"+ name + "'";
            DataTable dt = ConnectDatabase(sql);
            if(dt.Rows.Count > 0)
            {
                id = dt.Rows[0][0].ToString();
            }
            return id;
        }
    }
}
