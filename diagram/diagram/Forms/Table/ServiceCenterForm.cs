using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class ServiceCenterForm : Form
    {
        my_db_for_db_2Entities db;
        public ServiceCenterForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void ServiceCenterForm_Load(object sender, EventArgs e)
        {
            addressBindingSource.DataSource = db.Address.ToList();
            serviceCenterBindingSource.DataSource = db.ServiceCenter.ToList();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (ServiceCenterIEF frm = new ServiceCenterIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    serviceCenterBindingSource.DataSource = db.ServiceCenter.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (serviceCenterBindingSource.Current == null)
            {
                return;
            }
            using (ServiceCenterIEF frm = new ServiceCenterIEF(serviceCenterBindingSource.Current as ServiceCenter, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    serviceCenterBindingSource.DataSource = db.ServiceCenter.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (serviceCenterBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.ServiceCenter.Remove(serviceCenterBindingSource.Current as ServiceCenter);
                    serviceCenterBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
