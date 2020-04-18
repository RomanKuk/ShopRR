using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class TransportationForm : Form
    {
        my_db_for_db_2Entities db;
        public TransportationForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void TransportationForm_Load(object sender, EventArgs e)
        {
            goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
            employeeBindingSource.DataSource = db.Employee.ToList();
            transportationBindingSource.DataSource = db.Transportation.ToList();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (TransportationIEF frm = new TransportationIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    transportationBindingSource.DataSource = db.Transportation.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (transportationBindingSource.Current == null)
            {
                return;
            }
            using (TransportationIEF frm = new TransportationIEF(transportationBindingSource.Current as Transportation, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    transportationBindingSource.DataSource = db.Transportation.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (transportationBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Transportation.Remove(transportationBindingSource.Current as Transportation);
                    transportationBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
