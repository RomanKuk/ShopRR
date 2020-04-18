using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class ProvideOrderForm : Form
    {
        my_db_for_db_2Entities db;
        public ProvideOrderForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void ProvideOrderForm_Load(object sender, EventArgs e)
        {
            provideBindingSource.DataSource = db.Provide.ToList();
            provideOrderBindingSource.DataSource = db.ProvideOrder.ToList();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (ProvideOrderIEF frm = new ProvideOrderIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    provideOrderBindingSource.DataSource = db.ProvideOrder.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (provideOrderBindingSource.Current == null)
            {
                return;
            }
            using (ProvideOrderIEF frm = new ProvideOrderIEF(provideOrderBindingSource.Current as ProvideOrder, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    provideOrderBindingSource.DataSource = db.ProvideOrder.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (provideOrderBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.ProvideOrder.Remove(provideOrderBindingSource.Current as ProvideOrder);
                    provideOrderBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
