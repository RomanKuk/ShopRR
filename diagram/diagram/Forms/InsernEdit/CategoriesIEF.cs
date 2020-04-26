using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class CategoriesIEF : Form
    {
        my_db_for_db_2Entities db;
        public CategoriesIEF(Categories obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            categoriesBindingSource1.DataSource = db.Categories.ToList();
            categoriesBindingSource.DataSource = db.Categories.ToList();
            if (obj == null)
            {
                categoriesBindingSource.DataSource = new Categories();
                db.Categories.Add(categoriesBindingSource.Current as Categories);

            }
            else
            {
                categoriesBindingSource.DataSource = obj;
                db.Categories.Attach(categoriesBindingSource.Current as Categories);
            }
        }

        private void CategoriesIEF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(categNameTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    categNameTB.Focus();
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
