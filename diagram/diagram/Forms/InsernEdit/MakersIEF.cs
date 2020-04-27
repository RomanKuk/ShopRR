using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class MakersIEF : Form
    {
        my_db_for_db_2Entities db;
        public MakersIEF(Makers obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            countriesBindingSource.DataSource = db.Countries.ToList();
            brandBindingSource.DataSource = db.Brand.ToList();
            makersBindingSource.DataSource = db.Makers.ToList();
            if (obj == null)
            {
                makersBindingSource.DataSource = new Makers();
                db.Makers.Add(makersBindingSource.Current as Makers);

            }
            else
            {
                makersBindingSource.DataSource = obj;
                db.Makers.Attach(makersBindingSource.Current as Makers);
            }
        }

        private void Makers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(codeTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    codeTB.Focus();
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
