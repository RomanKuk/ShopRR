using diagram.Classes;
using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class AddressForm : Form
    {
        my_db_for_db_2Entities db;
        Employee employee;
        public AddressForm(my_db_for_db_2Entities _db, Employee _employee)
        {
            InitializeComponent();
            employee = _employee;
            db = _db;
            if (employee.Employee_ID.Equals(4))//якщо адмін
            {
                MenuStrip menuStrip = AdminMenu.getMenu(db, employee);
                this.MainMenuStrip = menuStrip;
                //this.Controls.Add(menuStrip);
                panel5.Controls.Add(menuStrip);
                menuStrip.Location = new System.Drawing.Point(79, 4);
                menuStrip.Name = "menuStrip";
                menuStrip.Size = new System.Drawing.Size(38, 38);
            }
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {
            cityBindingSource.DataSource = db.City.ToList();
            addressBindingSource.DataSource = db.Address.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (AddressIEF frm = new AddressIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    addressBindingSource.DataSource = db.Address.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (addressBindingSource.Current == null)
            {
                return;
            }
            using (AddressIEF frm = new AddressIEF(addressBindingSource.Current as Address, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    addressBindingSource.DataSource = db.Address.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (addressBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Address.Remove(addressBindingSource.Current as Address);
                    addressBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
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

        }
    }
}
