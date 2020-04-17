using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class ShipmentIEF : Form
    {
        my_db_for_db_2Entities db;
        public ShipmentIEF(Shipment obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            deliveryBindingSource.DataSource = db.Delivery.ToList();
            goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
            employeeBindingSource.DataSource = db.Employee.ToList();
            shipmentBindingSource.DataSource = db.Shipment.ToList();
            if (obj == null)
            {
                shipmentBindingSource.DataSource = new Shipment();
                db.Shipment.Add(shipmentBindingSource.Current as Shipment);

            }
            else
            {
                shipmentBindingSource.DataSource = obj;
                db.Shipment.Attach(shipmentBindingSource.Current as Shipment);
            }
        }

        private void ShipmentIEF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
