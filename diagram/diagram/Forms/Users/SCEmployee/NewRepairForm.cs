using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Users.SCEmployee
{
    public partial class NewRepairForm : Form
    {
        my_db_for_db_2Entities db;
        public NewRepairForm(my_db_for_db_2Entities _db)
        {
            db = _db;
            InitializeComponent();
        }

        private void NewRepairForm_Load(object sender, EventArgs e)
        {
            serviceTransportationBindingSource.DataSource = db.ServiceTransportation.ToList();

            int serviceID = (db.ServiceTransportation as IEnumerable<ServiceTransportation>)
                    .Where(x => x.ServiceTransportation_ID.Equals((int)STComboBox.SelectedValue))
                    .Select(x => x.Service_ID)
                    .FirstOrDefault();
            int status = (db.Service as IEnumerable<Service>)
                .Where(x => x.Service_ID.Equals(serviceID))
                .Select(x => x.Status_ID)
                .FirstOrDefault();
            statusBindingSource.DataSource = db.Status.ToList();
            updateTableContent();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Repair repair = new Repair()
            {
                ServiceTransportation_ID = (int) STComboBox.SelectedValue,
                Comment = CommentTextBox.Text,
                Date = DateTime.Now
            };
            int serviceID = (db.ServiceTransportation as IEnumerable<ServiceTransportation>)
                .Where(x => x.ServiceTransportation_ID.Equals((int)STComboBox.SelectedValue))
                .Select(x => x.Service_ID)
                .FirstOrDefault();
            Service service = (db.Service as IEnumerable<Service>)
                .Where(x => x.Service_ID.Equals(serviceID))
                .FirstOrDefault();
            if (!service.Status_ID.Equals(StatusComboBox.SelectedValue))
            {
                db.Service.Attach(service);
                service.Status_ID = (int) StatusComboBox.SelectedValue;
            }
            db.Repair.Add(repair);
            db.SaveChanges();
            updateTableContent();
        }



        private void STComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTableContent();
        }

        private void updateTableContent()
        {
            dataGridView1.Rows.Clear();
            List<Repair> repairs = (db.Repair as IEnumerable<Repair>)
                .Where(x => x.ServiceTransportation_ID.Equals(STComboBox.SelectedValue))
                .ToList();
            int serviceID = 0;
            int status = 0;
            foreach (Repair repair in repairs)
            {
                serviceID = (db.ServiceTransportation as IEnumerable<ServiceTransportation>)
                    .Where(x => x.ServiceTransportation_ID.Equals((int)STComboBox.SelectedValue))
                    .Select(x => x.Service_ID)
                    .FirstOrDefault();
                status = (db.Service as IEnumerable<Service>)
                    .Where(x => x.Service_ID.Equals(serviceID))
                    .Select(x => x.Status_ID)
                    .FirstOrDefault();
                dataGridView1.Rows.Add(repair.Comment, repair.Date, status);
            }
            StatusComboBox.SelectedValue = status;
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
