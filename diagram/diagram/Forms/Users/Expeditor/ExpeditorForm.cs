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
            deliveryBindingSource.DataSource = db.Delivery.ToList();//може знадобитися 2
            goodsBindingSource.DataSource = db.Goods.ToList();
            provideOrderBindingSource.DataSource = db.ProvideOrder.ToList();
            shipmentBindingSource.DataSource = db.Shipment.ToList();
            goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
            employeeBindingSource.DataSource = db.Employee.ToList();
        }

        private void NewProvideOrder_Click(object sender, EventArgs e)
        {
            NewDeliveryForm form = new NewDeliveryForm(db, employee);
            form.Show();
        }

        private void NewShipment_Click(object sender, EventArgs e)
        {
            NewShipmentForm form = new NewShipmentForm(db);
            form.Show();
        }

        private void NewService_Click(object sender, EventArgs e)
        {
            NewServiceForm form = new NewServiceForm(db);
            form.Show();
        }
    }
}
