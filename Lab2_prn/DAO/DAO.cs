using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_prn.DAO
{
    internal class DAO
    {
        public static SqlConnection GetConnection()
        {
            string ConStr = "server=NANTHUYEEN\\SQLEXPRESS;database=Northwind;user=sa;password=Anthuyen281211";
            return new SqlConnection(ConStr);
        }

        public static DataTable GetDataBySQL(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters != null)
                command.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}

