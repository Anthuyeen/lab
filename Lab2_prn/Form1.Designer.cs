namespace Lab2_prn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFilterFreight = new System.Windows.Forms.Button();
            this.btnStartFil = new System.Windows.Forms.Button();
            this.rBtnSortFreight = new System.Windows.Forms.RadioButton();
            this.rBtnSortOD = new System.Windows.Forms.RadioButton();
            this.rBtnSortCus = new System.Windows.Forms.RadioButton();
            this.rbtnSortEm = new System.Windows.Forms.RadioButton();
            this.numFrTo = new System.Windows.Forms.NumericUpDown();
            this.numFrFrom = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpOderDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderDateFrom = new System.Windows.Forms.DateTimePicker();
            this.cbCustomers = new System.Windows.Forms.ComboBox();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.cbEmployees = new System.Windows.Forms.ComboBox();
            this.LbSort = new System.Windows.Forms.Label();
            this.LbFreight = new System.Windows.Forms.Label();
            this.LbOrderDate = new System.Windows.Forms.Label();
            this.LbCustomers = new System.Windows.Forms.Label();
            this.LbSuppliers = new System.Windows.Forms.Label();
            this.LbEmployees = new System.Windows.Forms.Label();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(21, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1026, 612);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 612);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFilterFreight);
            this.groupBox2.Controls.Add(this.btnStartFil);
            this.groupBox2.Controls.Add(this.rBtnSortFreight);
            this.groupBox2.Controls.Add(this.rBtnSortOD);
            this.groupBox2.Controls.Add(this.rBtnSortCus);
            this.groupBox2.Controls.Add(this.rbtnSortEm);
            this.groupBox2.Controls.Add(this.numFrTo);
            this.groupBox2.Controls.Add(this.numFrFrom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpOderDateTo);
            this.groupBox2.Controls.Add(this.dtpOrderDateFrom);
            this.groupBox2.Controls.Add(this.cbCustomers);
            this.groupBox2.Controls.Add(this.cbSuppliers);
            this.groupBox2.Controls.Add(this.cbEmployees);
            this.groupBox2.Controls.Add(this.LbSort);
            this.groupBox2.Controls.Add(this.LbFreight);
            this.groupBox2.Controls.Add(this.LbOrderDate);
            this.groupBox2.Controls.Add(this.LbCustomers);
            this.groupBox2.Controls.Add(this.LbSuppliers);
            this.groupBox2.Controls.Add(this.LbEmployees);
            this.groupBox2.Location = new System.Drawing.Point(1053, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 612);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // btnFilterFreight
            // 
            this.btnFilterFreight.Location = new System.Drawing.Point(393, 506);
            this.btnFilterFreight.Name = "btnFilterFreight";
            this.btnFilterFreight.Size = new System.Drawing.Size(106, 29);
            this.btnFilterFreight.TabIndex = 17;
            this.btnFilterFreight.Text = "Filter";
            this.btnFilterFreight.UseVisualStyleBackColor = true;
            this.btnFilterFreight.Click += new System.EventHandler(this.btnFilterFreight_Click);
            // 
            // btnStartFil
            // 
            this.btnStartFil.Location = new System.Drawing.Point(393, 317);
            this.btnStartFil.Name = "btnStartFil";
            this.btnStartFil.Size = new System.Drawing.Size(106, 29);
            this.btnStartFil.TabIndex = 11;
            this.btnStartFil.Text = "Filter";
            this.btnStartFil.UseVisualStyleBackColor = true;
            this.btnStartFil.Click += new System.EventHandler(this.btnStartFil_Click);
            // 
            // rBtnSortFreight
            // 
            this.rBtnSortFreight.AutoSize = true;
            this.rBtnSortFreight.Location = new System.Drawing.Point(375, 584);
            this.rBtnSortFreight.Name = "rBtnSortFreight";
            this.rBtnSortFreight.Size = new System.Drawing.Size(96, 24);
            this.rBtnSortFreight.TabIndex = 10;
            this.rBtnSortFreight.Text = "By Freight";
            this.rBtnSortFreight.UseVisualStyleBackColor = true;
            this.rBtnSortFreight.CheckedChanged += new System.EventHandler(this.rBtnSortFreight_CheckedChanged);
            // 
            // rBtnSortOD
            // 
            this.rBtnSortOD.AutoSize = true;
            this.rBtnSortOD.Location = new System.Drawing.Point(375, 541);
            this.rBtnSortOD.Name = "rBtnSortOD";
            this.rBtnSortOD.Size = new System.Drawing.Size(124, 24);
            this.rBtnSortOD.TabIndex = 8;
            this.rBtnSortOD.Text = "By Order Date";
            this.rBtnSortOD.UseVisualStyleBackColor = true;
            this.rBtnSortOD.CheckedChanged += new System.EventHandler(this.rBtnSortOD_CheckedChanged);
            // 
            // rBtnSortCus
            // 
            this.rBtnSortCus.AutoSize = true;
            this.rBtnSortCus.Location = new System.Drawing.Point(172, 584);
            this.rBtnSortCus.Name = "rBtnSortCus";
            this.rBtnSortCus.Size = new System.Drawing.Size(119, 24);
            this.rBtnSortCus.TabIndex = 9;
            this.rBtnSortCus.Text = "By Customers";
            this.rBtnSortCus.UseVisualStyleBackColor = true;
            this.rBtnSortCus.CheckedChanged += new System.EventHandler(this.rBtnSortCus_CheckedChanged);
            // 
            // rbtnSortEm
            // 
            this.rbtnSortEm.AutoSize = true;
            this.rbtnSortEm.Location = new System.Drawing.Point(172, 541);
            this.rbtnSortEm.Name = "rbtnSortEm";
            this.rbtnSortEm.Size = new System.Drawing.Size(122, 24);
            this.rbtnSortEm.TabIndex = 7;
            this.rbtnSortEm.Text = "By Employees";
            this.rbtnSortEm.UseVisualStyleBackColor = true;
            this.rbtnSortEm.CheckedChanged += new System.EventHandler(this.rbtnSortEm_CheckedChanged);
            // 
            // numFrTo
            // 
            this.numFrTo.DecimalPlaces = 2;
            this.numFrTo.Increment = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.numFrTo.Location = new System.Drawing.Point(172, 448);
            this.numFrTo.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numFrTo.Name = "numFrTo";
            this.numFrTo.Size = new System.Drawing.Size(327, 27);
            this.numFrTo.TabIndex = 6;
            // 
            // numFrFrom
            // 
            this.numFrFrom.DecimalPlaces = 2;
            this.numFrFrom.Increment = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.numFrFrom.Location = new System.Drawing.Point(172, 405);
            this.numFrFrom.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numFrFrom.Name = "numFrFrom";
            this.numFrFrom.Size = new System.Drawing.Size(327, 27);
            this.numFrFrom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "From";
            // 
            // dtpOderDateTo
            // 
            this.dtpOderDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOderDateTo.Location = new System.Drawing.Point(172, 273);
            this.dtpOderDateTo.Name = "dtpOderDateTo";
            this.dtpOderDateTo.Size = new System.Drawing.Size(327, 27);
            this.dtpOderDateTo.TabIndex = 4;
            // 
            // dtpOrderDateFrom
            // 
            this.dtpOrderDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderDateFrom.Location = new System.Drawing.Point(172, 226);
            this.dtpOrderDateFrom.Name = "dtpOrderDateFrom";
            this.dtpOrderDateFrom.Size = new System.Drawing.Size(327, 27);
            this.dtpOrderDateFrom.TabIndex = 3;
            // 
            // cbCustomers
            // 
            this.cbCustomers.FormattingEnabled = true;
            this.cbCustomers.Location = new System.Drawing.Point(172, 135);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.Size = new System.Drawing.Size(327, 28);
            this.cbCustomers.TabIndex = 2;
            this.cbCustomers.SelectedIndexChanged += new System.EventHandler(this.cbCustomers_SelectedIndexChanged);
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(172, 81);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(327, 28);
            this.cbSuppliers.TabIndex = 1;
            this.cbSuppliers.SelectedIndexChanged += new System.EventHandler(this.cbSuppliers_SelectedIndexChanged);
            // 
            // cbEmployees
            // 
            this.cbEmployees.FormattingEnabled = true;
            this.cbEmployees.Location = new System.Drawing.Point(172, 26);
            this.cbEmployees.Name = "cbEmployees";
            this.cbEmployees.Size = new System.Drawing.Size(327, 28);
            this.cbEmployees.TabIndex = 0;
            this.cbEmployees.SelectedIndexChanged += new System.EventHandler(this.cbEmployees_SelectedIndexChanged);
            // 
            // LbSort
            // 
            this.LbSort.AutoSize = true;
            this.LbSort.Location = new System.Drawing.Point(22, 526);
            this.LbSort.Name = "LbSort";
            this.LbSort.Size = new System.Drawing.Size(36, 20);
            this.LbSort.TabIndex = 6;
            this.LbSort.Text = "Sort";
            // 
            // LbFreight
            // 
            this.LbFreight.AutoSize = true;
            this.LbFreight.Location = new System.Drawing.Point(22, 373);
            this.LbFreight.Name = "LbFreight";
            this.LbFreight.Size = new System.Drawing.Size(55, 20);
            this.LbFreight.TabIndex = 5;
            this.LbFreight.Text = "Freight";
            // 
            // LbOrderDate
            // 
            this.LbOrderDate.AutoSize = true;
            this.LbOrderDate.Location = new System.Drawing.Point(22, 190);
            this.LbOrderDate.Name = "LbOrderDate";
            this.LbOrderDate.Size = new System.Drawing.Size(81, 20);
            this.LbOrderDate.TabIndex = 4;
            this.LbOrderDate.Text = "Order date";
            // 
            // LbCustomers
            // 
            this.LbCustomers.AutoSize = true;
            this.LbCustomers.Location = new System.Drawing.Point(22, 133);
            this.LbCustomers.Name = "LbCustomers";
            this.LbCustomers.Size = new System.Drawing.Size(78, 20);
            this.LbCustomers.TabIndex = 3;
            this.LbCustomers.Text = "Customers";
            // 
            // LbSuppliers
            // 
            this.LbSuppliers.AutoSize = true;
            this.LbSuppliers.Location = new System.Drawing.Point(22, 79);
            this.LbSuppliers.Name = "LbSuppliers";
            this.LbSuppliers.Size = new System.Drawing.Size(70, 20);
            this.LbSuppliers.TabIndex = 2;
            this.LbSuppliers.Text = "Suppliers";
            // 
            // LbEmployees
            // 
            this.LbEmployees.AutoSize = true;
            this.LbEmployees.Location = new System.Drawing.Point(22, 24);
            this.LbEmployees.Name = "LbEmployees";
            this.LbEmployees.Size = new System.Drawing.Size(81, 20);
            this.LbEmployees.TabIndex = 1;
            this.LbEmployees.Text = "Employees";
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 705);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown numFrTo;
        private NumericUpDown numFrFrom;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpOderDateTo;
        private DateTimePicker dtpOrderDateFrom;
        private ComboBox cbCustomers;
        private ComboBox cbSuppliers;
        private ComboBox cbEmployees;
        private Label LbSort;
        private Label LbFreight;
        private Label LbOrderDate;
        private Label LbCustomers;
        private Label LbSuppliers;
        private Label LbEmployees;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnStartFil;
        private RadioButton rBtnSortFreight;
        private RadioButton rBtnSortOD;
        private RadioButton rBtnSortCus;
        private RadioButton rbtnSortEm;
        private DataGridView dataGridView1;
        private Button btnFilterFreight;
    }
}