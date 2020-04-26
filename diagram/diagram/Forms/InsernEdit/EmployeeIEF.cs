using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class EmployeeIEF : Form
    {
        my_db_for_db_2Entities db;
        public EmployeeIEF(Employee obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            addressBindingSource.DataSource = db.Address.ToList();
            professionBindingSource.DataSource = db.Profession.ToList();
            shopsBindingSource.DataSource = db.Shops.ToList();
            employeeBindingSource.DataSource = db.Employee.ToList();
            if (obj == null)
            {
                employeeBindingSource.DataSource = new Employee();
                db.Employee.Add(employeeBindingSource.Current as Employee);

            }
            else
            {
                employeeBindingSource.DataSource = obj;
                db.Employee.Attach(employeeBindingSource.Current as Employee);
            }
        }

        private void EmployeeIEF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(phoneTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    firstNameTB.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(phoneTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    firstNameTB.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(phoneTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    phoneTB.Focus();
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
