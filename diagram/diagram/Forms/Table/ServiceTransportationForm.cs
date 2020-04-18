using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class ServiceTransportationForm : Form
    {
        my_db_for_db_2Entities db;
        public ServiceTransportationForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void ServiceTransportationForm_Load(object sender, EventArgs e)
        {
            serviceBindingSource.DataSource = db.Service.ToList();
            serviceCenterBindingSource.DataSource = db.ServiceCenter.ToList();
            serviceTransportationBindingSource.DataSource = db.ServiceTransportation.ToList();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (ServiceTransportationIEF frm = new ServiceTransportationIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    serviceTransportationBindingSource.DataSource = db.ServiceTransportation.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (serviceTransportationBindingSource.Current == null)
            {
                return;
            }
            using (ServiceTransportationIEF frm = new ServiceTransportationIEF(serviceTransportationBindingSource.Current as ServiceTransportation, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    serviceTransportationBindingSource.DataSource = db.ServiceTransportation.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (serviceTransportationBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.ServiceTransportation.Remove(serviceTransportationBindingSource.Current as ServiceTransportation);
                    serviceTransportationBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
