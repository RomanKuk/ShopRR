using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class CategoriesSCIEF : Form
    {
        my_db_for_db_2Entities db;
        public CategoriesSCIEF(CategoriesSC obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            serviceCenterBindingSource.DataSource = db.ServiceCenter.ToList();
            categoriesBindingSource.DataSource = db.Categories.ToList();
            categoriesSCBindingSource.DataSource = db.CategoriesSC.ToList();
            if (obj == null)
            {
                categoriesSCBindingSource.DataSource = new CategoriesSC();
                db.CategoriesSC.Add(categoriesSCBindingSource.Current as CategoriesSC);

            }
            else
            {
                categoriesSCBindingSource.DataSource = obj;
                db.CategoriesSC.Attach(categoriesSCBindingSource.Current as CategoriesSC);
            }
        }

        private void CategoriesSCIEF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
