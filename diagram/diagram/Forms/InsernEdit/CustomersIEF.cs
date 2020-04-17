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
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox3.Focus();
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
