using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.service
{
    public partial class ServiceCenterForm : Form
    {
        my_db_for_db_2Entities db;
        Employee employee;
        public ServiceCenterForm(my_db_for_db_2Entities _db, Employee _employee)
        {
            db = _db;
            employee = _employee;
            InitializeComponent();
        }

        private void ServiceCenterForm_Load(object sender, EventArgs e)
        {
            serviceBindingSource.DataSource = db.Service.ToList();
            breakageBindingSource.DataSource = db.Breakage.ToList();
            statusBindingSource.DataSource = db.Status.ToList();
            basketBindingSource.DataSource = db.Basket.ToList();
            serviceTransportationBindingSource.DataSource = db.ServiceTransportation.ToList();
            serviceCenterBindingSource.DataSource = db.ServiceCenter.ToList();
            serviceBindingSource1.DataSource = db.Service.ToList();
            repairBindingSource.DataSource = db.Repair.ToList();
            serviceTransportationBindingSource1.DataSource = db.ServiceTransportation.ToList();

        }

        private void NewSTButton_Click(object sender, EventArgs e)
        {
            using (NewServiceTransportationForm form = new NewServiceTransportationForm(db))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    serviceTransportationBindingSource.DataSource = db.ServiceTransportation.ToList();
                }
            }
        }

        private void RepairButton_Click(object sender, EventArgs e)
        {
            using (NewRepairForm form = new NewRepairForm(db))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                }
                repairBindingSource.DataSource = db.Repair.ToList();
            }
        }

    }
}
