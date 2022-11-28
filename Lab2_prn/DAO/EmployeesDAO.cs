using Lab2_prn.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_prn.DAO
{
    internal class EmployeesDAO
    {
        public List<Employee> GetEmployees()
        {
            /*NorthwindContext context = new NorthwindContext();
            List<Employee> employees = context.Employees.ToList();
            foreach(Employee employee in employees)
            {
                employee.Orders.sel
            }*/
            string sql = "select * from Employees";
            DataTable dt = DAO.GetDataBySQL(sql);
            List<Employee> list = new List<Employee>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Employee(
                    Convert.ToInt32(dr["EmployeeID"]),
                    dr["FirstName"].ToString() +" "+ dr["LastName"].ToString() is null ? "" : dr["FirstName"].ToString() +" "+ dr["LastName"].ToString()
                    ));
            }
            return list;
        }
    }
}

