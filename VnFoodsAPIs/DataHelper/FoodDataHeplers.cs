using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace VnFoodsAPIs.DataHelper
{
    public class FoodDataHeplers
    {
       

        public static SqlConnection InitConnection() {
            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["FoodApiConnection"].ToString());
            conn.Open();
            return conn;
        }

        public static DataSet ExecutedSelect(string tablename)
        {
            DataSet ds = new DataSet();
            DataTable table = new DataTable();
            table.TableName = tablename;
            SqlCommand cmd = new SqlCommand("select * from tbFoods", InitConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //adapter.Fill(table);
            ds.Tables.Add(table);
            adapter.Fill(ds, tablename);
            //return table;
            return ds;
        }

        public static int ExecutedUID (string cmd)
        {
            int rows = 0;
            var commad = new SqlCommand(cmd, InitConnection());
            rows = commad.ExecuteNonQuery();
            return rows;
        }
    }
}