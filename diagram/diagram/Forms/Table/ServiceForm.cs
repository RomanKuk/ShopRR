using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class ServiceForm : Form
    {
        my_db_for_db_2Entities db;
        public ServiceForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            breakageBindingSource.DataSource = db.Breakage.ToList();
            statusBindingSource.DataSource = db.Status.ToList();
            basketBindingSource.DataSource = db.Basket.ToList();
            serviceBindingSource.DataSource = db.Service.ToList();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (ServiceIEF frm = new ServiceIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    serviceBindingSource.DataSource = db.Service.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (serviceBindingSource.Current == null)
            {
                return;
            }
            using (ServiceIEF frm = new ServiceIEF(serviceBindingSource.Current as Service, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    serviceBindingSource.DataSource = db.Service.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (serviceBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Service.Remove(serviceBindingSource.Current as Service);
                    serviceBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
