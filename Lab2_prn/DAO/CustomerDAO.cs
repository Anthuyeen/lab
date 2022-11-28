using Lab2_prn.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_prn.DAO
{
    internal class CustomerDAO
    {
        public List<Customer> GetCustomer()
        {
            string sql = "select * from Customers";
            DataTable dt = DAO.GetDataBySQL(sql);
            List<Customer> list = new List<Customer>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Customer(
                    dr["CustomerID"].ToString()
                    ));
            }
            return list;
        }
    }
}
