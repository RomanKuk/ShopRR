using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class ServiceTransportationIEF : Form
    {
        my_db_for_db_2Entities db;
        public ServiceTransportationIEF(ServiceTransportation obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            serviceBindingSource.DataSource = db.Service.ToList();
            serviceCenterBindingSource.DataSource = db.ServiceCenter.ToList();
            serviceTransportationBindingSource.DataSource = db.ServiceTransportation.ToList();
            if (obj == null)
            {
                serviceTransportationBindingSource.DataSource = new ServiceTransportation();
                db.ServiceTransportation.Add(serviceTransportationBindingSource.Current as ServiceTransportation);

            }
            else
            {
                serviceTransportationBindingSource.DataSource = obj;
                db.ServiceTransportation.Attach(serviceTransportationBindingSource.Current as ServiceTransportation);
            }
        }

        private void ServiceTransportationIEF_FormClosing(object sender, FormClosingEventArgs e)
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
