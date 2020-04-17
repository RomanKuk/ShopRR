using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class AddressForm : Form
    {
        my_db_for_db_2Entities db;
        public AddressForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {
            cityBindingSource.DataSource = db.City.ToList();
            addressBindingSource.DataSource = db.Address.ToList();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (AddressIEF frm = new AddressIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    addressBindingSource.DataSource = db.Address.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (addressBindingSource.Current == null)
            {
                return;
            }
            using (AddressIEF frm = new AddressIEF(addressBindingSource.Current as Address, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    addressBindingSource.DataSource = db.Address.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (addressBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Address.Remove(addressBindingSource.Current as Address);
                    addressBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
