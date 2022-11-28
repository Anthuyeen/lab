using Lab2_prn.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_prn.DAO
{
    internal class SupplierDAO
    {
        //public List<Supplier> GetSupplier()
        //{
        //    string sql = "select * from Suppliers";
        //    DataTable dt = DAO.GetDataBySQL(sql);
        //    List<Supplier> list = new List<Supplier>();
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        list.Add(new Supplier(
        //            Convert.ToInt32(dr["SupplierID"])
        //            ));
        //    }
        //    return list;
        //}
        public List<Order> GetSupplier()
        {
            string sql = "select * from Orders";
            DataTable dt = DAO.GetDataBySQL(sql);
            List<Order> list = new List<Order>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Order(
                    Convert.ToInt32(dr["OrderID"]),
                    dr["ShipName"].ToString() is null ? "" : dr["ShipName"].ToString() 

                    ));
            }
            return list;
        }
    }
}
