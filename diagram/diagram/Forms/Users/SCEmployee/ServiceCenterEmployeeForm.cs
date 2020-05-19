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
            // TODO: This line of code loads data into the 'advancedDataSet.Repair' table. You can move, or remove it, as needed.
            this.repairTableAdapter.Fill(this.advancedDataSet.Repair);
            // TODO: This line of code loads data into the 'advancedDataSet.ServiceTransportation' table. You can move, or remove it, as needed.
            this.serviceTransportationTableAdapter.Fill(this.advancedDataSet.ServiceTransportation);
            // TODO: This line of code loads data into the 'advancedDataSet.Service' table. You can move, or remove it, as needed.
            this.serviceTableAdapter.Fill(this.advancedDataSet.Service);
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
            this.Hide();
            Classes.FormState.PreviousPage = this;
            new InsernEdit.UserInfo(employee, db).Show();
        }

        private void changeUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Forms.login.LoginForm(db).Show();
        }
    }
}
