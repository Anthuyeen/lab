using Lab2_prn.DAO;
using Lab2_prn.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Xaml.Permissions;

namespace Lab2_prn
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=localhost;" +
            "Initial Catalog=Northwind;" +
            "Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=NANTHUYEEN\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            LoadData();

            cbEmployeeid();
            LoadDataEmployee();

            cbCustomerId();
            LoadDataCus();

            cbSuppliersid();
            LoadDataSup();

            dtpOrderDateFrom.Text = "1996 - 07 - 04";
            dtpOderDateTo.Text = "1998 - 05 - 06";

            numFrFrom.Value = (decimal)0.02;
            numFrTo.Value = (decimal)1007.64;
            conn.Close();
        }

        void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Orders";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void LoadDataEmployee()
        {
            SqlCommand quer = new SqlCommand("Select * from Orders where EmployeeID like '%" + cbEmployees.Text + "%'", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sqlDataAdapter.SelectCommand = quer;
            dt.Clear();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void LoadDataCus()
        {
            SqlCommand quer = new SqlCommand("Select * from Orders where CustomerID like '%" + cbCustomers.Text + "%'", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sqlDataAdapter.SelectCommand = quer;
            dt.Clear();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void LoadDataSup()
        {
            SqlCommand quer = new SqlCommand("Select * from Orders where ShipName like '%" + cbSuppliers.Text + "%'", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sqlDataAdapter.SelectCommand = quer;
            dt.Clear();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void display_datagridSortEmPloyee()
        {
            SqlCommand quer = new SqlCommand("SELECT * FROM Orders ORDER by EmployeeID ASC", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sqlDataAdapter.SelectCommand = quer;
            dt.Clear();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void display_datagridSortCustomer()
        {
            SqlCommand quer = new SqlCommand("SELECT * FROM Orders ORDER by CustomerID ASC", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sqlDataAdapter.SelectCommand = quer;
            dt.Clear();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void display_datagridSortFreight()
        {
            SqlCommand quer = new SqlCommand("SELECT * FROM Orders ORDER by Freight ASC", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sqlDataAdapter.SelectCommand = quer;
            dt.Clear();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void display_datagridSortOrderDate()
        {
            SqlCommand quer = new SqlCommand("SELECT * FROM Orders ORDER by OrderDate ASC", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sqlDataAdapter.SelectCommand = quer;
            dt.Clear();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void cbEmployeeid()
        {
            EmployeesDAO employeesDAO = new EmployeesDAO();
            cbEmployees.DisplayMember = "FirstName";
            cbEmployees.ValueMember = "EmployeeID";
            List<Employee> e = employeesDAO.GetEmployees();
            e.Insert(0, new()
            {
                FirstName = "all",
                EmployeeId = 0
            }) ;
            cbEmployees.DataSource = e;
            cbEmployees.SelectedIndex = 0;
        }

        private void cbCustomerId()
        {
            CustomerDAO customerDAO = new CustomerDAO();
            cbCustomers.DisplayMember = "CustomerID";
            cbCustomers.ValueMember = "CustomerID";
            cbCustomers.DataSource = customerDAO.GetCustomer();
            cbCustomers.Text = "";
        }

        private void cbSuppliersid()
        {
            SupplierDAO supplierDAO = new SupplierDAO();
            cbSuppliers.DisplayMember = "ShipName";
            cbSuppliers.ValueMember = "ShipName";
            cbSuppliers.DataSource = supplierDAO.GetSupplier();
            cbSuppliers.Text = "";
        }

        private void display_datagridODFrom()
        {
            SqlCommand quer = new SqlCommand("SELECT * FROM Orders WHERE OrderDate >= '" + dtpOrderDateFrom.Value + "' AND OrderDate < '" + dtpOderDateTo.Value + "'", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sqlDataAdapter.SelectCommand = quer;
            dt.Clear();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void display_datagridODTo()
        {
            SqlCommand quer = new SqlCommand("SELECT * FROM Orders WHERE Freight >= '" + numFrFrom.Text + "' AND Freight < '" + numFrTo.Text + "'", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sqlDataAdapter.SelectCommand = quer;
            dt.Clear();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void cbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataEmployee();
            
        }

        private void rbtnSortEm_CheckedChanged(object sender, EventArgs e)
        {
            display_datagridSortEmPloyee();
        }

        private void rBtnSortOD_CheckedChanged(object sender, EventArgs e)
        {
            display_datagridSortOrderDate();
        }

        private void rBtnSortCus_CheckedChanged(object sender, EventArgs e)
        {
            display_datagridSortCustomer();
        }

        private void rBtnSortFreight_CheckedChanged(object sender, EventArgs e)
        {
            display_datagridSortFreight();
        }

        private void btnStartFil_Click(object sender, EventArgs e)
        {
            display_datagridODFrom();
        }

        private void btnFilterFreight_Click(object sender, EventArgs e)
        {
            display_datagridODTo();
        }

        private void cbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            LoadDataSup();
        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataCus();
        }
    }
}