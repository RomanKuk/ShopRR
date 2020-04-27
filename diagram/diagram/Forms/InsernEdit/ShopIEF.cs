using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class ShopIEF : Form
    {
        my_db_for_db_2Entities db;
        public ShopIEF(Shops obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            addressBindingSource.DataSource = db.Address.ToList();
            shopsBindingSource.DataSource = db.Shops.ToList();
            if (obj == null)
            {
                shopsBindingSource.DataSource = new Shops();
                db.Shops.Add(shopsBindingSource.Current as Shops);

            }
            else
            {
                shopsBindingSource.DataSource = obj;
                db.Shops.Attach(shopsBindingSource.Current as Shops);
            }
        }

        private void ShopIEF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
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
