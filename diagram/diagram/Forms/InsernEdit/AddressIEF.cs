using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class AddressIEF : Form
    {
        my_db_for_db_2Entities db;
        public AddressIEF(Address obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            //db = _db;
            db = new my_db_for_db_2Entities();
            cityBindingSource.DataSource = db.City.ToList();
            if (obj == null)
            {
                addressBindingSource.DataSource = new Address();
                db.Address.Add(addressBindingSource.Current as Address);

            }
            else
            {
                addressBindingSource.DataSource = obj;
                db.Address.Attach(addressBindingSource.Current as Address);
            }
        }

        private void AddressEIF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(addressNameTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    addressNameTB.Focus();
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
