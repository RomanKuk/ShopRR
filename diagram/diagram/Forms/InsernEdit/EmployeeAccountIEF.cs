using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class EmployeeAccountIEF : Form
    {
        my_db_for_db_2Entities db;
        public EmployeeAccountIEF(EmployeeAccount obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            employeeBindingSource.DataSource = db.Employee.ToList();
            employeeAccountBindingSource.DataSource = db.EmployeeAccount.ToList();
            if (obj == null)
            {
                employeeAccountBindingSource.DataSource = new EmployeeAccount();
                db.EmployeeAccount.Add(employeeAccountBindingSource.Current as EmployeeAccount);

            }
            else
            {
                employeeAccountBindingSource.DataSource = obj;
                db.EmployeeAccount.Attach(employeeAccountBindingSource.Current as EmployeeAccount);
            }
        }

        private void EmployeeAccountIEF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
