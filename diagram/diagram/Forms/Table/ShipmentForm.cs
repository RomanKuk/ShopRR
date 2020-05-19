using diagram.Forms.InsernEdit;
using diagram.Forms.Users;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class ShipmentForm : Form
    {
        my_db_for_db_2Entities db;
        public ShipmentForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void ShipmentForm_Load(object sender, EventArgs e)
        {
            deliveryBindingSource.DataSource = db.Delivery.ToList();
            goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
            employeeBindingSource.DataSource = db.Employee.ToList();
            shipmentBindingSource.DataSource = db.Shipment.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (ShipmentIEF frm = new ShipmentIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    shipmentBindingSource.DataSource = db.Shipment.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (shipmentBindingSource.Current == null)
            {
                return;
            }
            using (ShipmentIEF frm = new ShipmentIEF(shipmentBindingSource.Current as Shipment, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    shipmentBindingSource.DataSource = db.Shipment.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (shipmentBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Shipment.Remove(shipmentBindingSource.Current as Shipment);
                    shipmentBindingSource.RemoveCurrent();
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
            this.Hide();
            Classes.FormState.PreviousPage = this;
            new TableControlForm(db).Show();
        }

        private void changeUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Forms.login.LoginForm(db).Show();
        }
    }
}
