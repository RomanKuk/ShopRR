using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class ProvideForm : Form
    {
        my_db_for_db_2Entities db;
        public ProvideForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void ProvideForm_Load(object sender, EventArgs e)
        {
            addressBindingSource.DataSource = db.Address.ToList();
            provideBindingSource.DataSource = db.Provide.ToList();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (ProvideIEF frm = new ProvideIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    provideBindingSource.DataSource = db.Provide.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (provideBindingSource.Current == null)
            {
                return;
            }
            using (ProvideIEF frm = new ProvideIEF(provideBindingSource.Current as Provide, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    provideBindingSource.DataSource = db.Provide.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (provideBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Provide.Remove(provideBindingSource.Current as Provide);
                    provideBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
