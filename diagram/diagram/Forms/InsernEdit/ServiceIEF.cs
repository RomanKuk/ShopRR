using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class ServiceIEF : Form
    {
        my_db_for_db_2Entities db;
        public ServiceIEF(Service obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            breakageBindingSource.DataSource = db.Breakage.ToList();
            statusBindingSource.DataSource = db.Status.ToList();
            basketBindingSource.DataSource = db.Basket.ToList();
            serviceBindingSource.DataSource = db.Service.ToList();
            if (obj == null)
            {
                serviceBindingSource.DataSource = new Service();
                db.Service.Add(serviceBindingSource.Current as Service);

            }
            else
            {
                serviceBindingSource.DataSource = obj;
                db.Service.Attach(serviceBindingSource.Current as Service);
            }
        }

        private void ServiceIEF_FormClosing(object sender, FormClosingEventArgs e)
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
