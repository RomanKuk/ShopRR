using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class BrandIEF : Form
    {
        my_db_for_db_2Entities db;
        public BrandIEF(Brand obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            countriesBindingSource.DataSource = db.Countries.ToList();
            if (obj == null)
            {
                brandBindingSource.DataSource = new Brand();
                db.Brand.Add(brandBindingSource.Current as Brand);

            }
            else
            {
                brandBindingSource.DataSource = obj;
                db.Brand.Attach(brandBindingSource.Current as Brand);
            }
        }

        private void BrandIEF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(brandNameTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    brandNameTB.Focus();
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
