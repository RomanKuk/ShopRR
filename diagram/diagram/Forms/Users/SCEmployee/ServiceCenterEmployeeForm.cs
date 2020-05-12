using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diagram.Forms.Users.SCEmployee
{
    public partial class ServiceCenterEmployeeForm : Form
    {
        my_db_for_db_2Entities db;
        Employee employee;
        public ServiceCenterEmployeeForm(my_db_for_db_2Entities _db, Employee _employee)
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

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;

        }

        private void NewServiceBtn_Click(object sender, EventArgs e)
        {
            NewServiceTransportationForm form = new NewServiceTransportationForm(db);
            form.Show();
        }

        private void RepairButton_Click(object sender, EventArgs e)
        {
            NewRepairForm form = new NewRepairForm(db);
            form.Show();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
