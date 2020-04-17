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
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Focus();
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
