using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class ServiceCenterIEF : Form
    {
        my_db_for_db_2Entities db;
        public ServiceCenterIEF(ServiceCenter obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            addressBindingSource.DataSource = db.Address.ToList();
            serviceCenterBindingSource.DataSource = db.ServiceCenter.ToList();
            if (obj == null)
            {
                serviceCenterBindingSource.DataSource = new ServiceCenter();
                db.ServiceCenter.Add(serviceCenterBindingSource.Current as ServiceCenter);

            }
            else
            {
                serviceCenterBindingSource.DataSource = obj;
                db.ServiceCenter.Attach(serviceCenterBindingSource.Current as ServiceCenter);
            }
        }

        private void ServiceCenterIEF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
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
