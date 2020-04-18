using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class SalesForm : Form
    {
        my_db_for_db_2Entities db;
        public SalesForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = db.Employee.ToList();
            customersBindingSource.DataSource = db.Customers.ToList();
            salesBindingSource.DataSource = db.Sales.ToList();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (SalesIEF frm = new SalesIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    salesBindingSource.DataSource = db.Sales.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (salesBindingSource.Current == null)
            {
                return;
            }
            using (SalesIEF frm = new SalesIEF(salesBindingSource.Current as Sales, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    salesBindingSource.DataSource = db.Sales.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (salesBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Sales.Remove(salesBindingSource.Current as Sales);
                    salesBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
