using diagram.Forms.InsernEdit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class BrandForm : Form
    {
        my_db_for_db_2Entities db;
        public BrandForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void BrandForm_Load(object sender, EventArgs e)
        {
            countriesBindingSource.DataSource = db.Countries.ToList();
            brandBindingSource.DataSource = db.Brand.ToList();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (BrandIEF frm = new BrandIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    brandBindingSource.DataSource = db.Brand.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (brandBindingSource.Current == null)
            {
                return;
            }
            using (BrandIEF frm = new BrandIEF(brandBindingSource.Current as Brand, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    brandBindingSource.DataSource = db.Brand.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (brandBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Brand.Remove(brandBindingSource.Current as Brand);
                    brandBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
