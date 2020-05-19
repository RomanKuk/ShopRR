using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Users.Expeditor
{
    public partial class ExpeditorForm : Form
    {
        my_db_for_db_2Entities db;
        Employee employee;
        public ExpeditorForm(my_db_for_db_2Entities _db, Employee _employee)
        {
            db = _db;
            employee = _employee;
            InitializeComponent();
        }

        private void ExpeditorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'advancedDataSet.Shipment' table. You can move, or remove it, as needed.
            this.shipmentTableAdapter.Fill(this.advancedDataSet.Shipment);
            // TODO: This line of code loads data into the 'advancedDataSet.Delivery' table. You can move, or remove it, as needed.
            this.deliveryTableAdapter.Fill(this.advancedDataSet.Delivery);
            // TODO: This line of code loads data into the 'advancedDataSet.Shipment' table. You can move, or remove it, as needed.
            this.shipmentTableAdapter.Fill(this.advancedDataSet.Shipment);
            // TODO: This line of code loads data into the 'advancedDataSet.Delivery' table. You can move, or remove it, as needed.
            this.deliveryTableAdapter.Fill(this.advancedDataSet.Delivery);
            deliveryBindingSource1.DataSource = db.Delivery.ToList();//може знадобитися 2
            goodsBindingSource.DataSource = db.Goods.ToList();
            provideOrderBindingSource.DataSource = db.ProvideOrder.ToList();
            //shipmentBindingSource.DataSource = db.Shipment.ToList();
            goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
            employeeBindingSource.DataSource = db.Employee.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void NewProvideOrder_Click(object sender, EventArgs e)
        {
            using (NewDeliveryForm form = new NewDeliveryForm(db, employee))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    provideOrderBindingSource.DataSource = db.ProvideOrder.ToList();
                    deliveryBindingSource.DataSource = db.Delivery.ToList();
                }
            }

        }

        private void NewShipment_Click(object sender, EventArgs e)
        {
            using (NewShipmentForm form = new NewShipmentForm(db))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
                    shipmentBindingSource.DataSource = db.Shipment.ToList();
                }
            }

        }

        private void NewService_Click(object sender, EventArgs e)
        {
            using (NewServiceForm form = new NewServiceForm(db,employee))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
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
            new InsernEdit.UserInfo(employee, db).Show();
        }

        private void changeUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Forms.login.LoginForm(db).Show();
        }
    }
}
