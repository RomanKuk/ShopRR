using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class CustomersIEF : Form
    {
        my_db_for_db_2Entities db;
        public CustomersIEF(Customers obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            addressBindingSource.DataSource = db.Address.ToList();
            customersBindingSource.DataSource = db.Countries.ToList();
            if (obj == null)
            {
                customersBindingSource.DataSource = new Customers();
                db.Customers.Add(customersBindingSource.Current as Customers);

            }
            else
            {
                customersBindingSource.DataSource = obj;
                db.Customers.Attach(customersBindingSource.Current as Customers);
            }
        }

        private void CustomersIEF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(firstNameTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    firstNameTB.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(lastNameTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lastNameTB.Focus();
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
