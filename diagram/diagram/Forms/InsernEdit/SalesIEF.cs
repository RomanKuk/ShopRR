using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class SalesIEF : Form
    {
        my_db_for_db_2Entities db;
        public SalesIEF(Sales obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            employeeBindingSource.DataSource = db.Employee.ToList();
            customersBindingSource.DataSource = db.Customers.ToList();
            salesBindingSource.DataSource = db.Sales.ToList();
            if (obj == null)
            {
                salesBindingSource.DataSource = new Sales();
                db.Sales.Add(salesBindingSource.Current as Sales);

            }
            else
            {
                salesBindingSource.DataSource = obj;
                db.Sales.Attach(salesBindingSource.Current as Sales);
            }
        }

        private void SalesIEF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(codeTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    codeTB.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
