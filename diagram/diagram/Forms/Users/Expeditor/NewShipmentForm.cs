using diagram.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Users.Expeditor
{
    public partial class NewShipmentForm : Form
    {
        my_db_for_db_2Entities db;
        public NewShipmentForm(my_db_for_db_2Entities _db)
        {
            db = _db;
            InitializeComponent();
        }

        private void NewShipmentForm_Load(object sender, EventArgs e)
        {
            List<int> shipments = (db.Shipment as IEnumerable<Shipment>)
                .Select( x => x.Deliver_ID)
                .ToList();
            deliveryBindingSource.DataSource = (db.Delivery as IEnumerable<Delivery>)
                .Where(x => !shipments.Contains(x.Deliver_ID))
                .ToList();
            shopsBindingSource.DataSource = db.Shops.ToList();
            employeeBindingSource.DataSource = db.Employee.ToList();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Delivery delivery = (db.Delivery as IEnumerable<Delivery>)
                .Where(x => x.Deliver_ID.Equals(DeliveryComboBox.SelectedValue))
                .FirstOrDefault();
            GoodsShops gs = (db.GoodsShops as IEnumerable<GoodsShops>)
                .Where(x => x.Shop_ID.Equals(ShopComboBox.SelectedValue != null ? ShopComboBox.SelectedValue : 0 ) &&
                x.Good_ID.Equals(delivery.Good_ID))
                .FirstOrDefault();
            if (gs != null)
            {
                db.GoodsShops.Attach(gs);
                gs.Count += delivery.Count;
            }
            else
            {
                gs = new GoodsShops()
                {
                    Code = CodeGenerator.GenerateCode("GoodsShops", "gs"),
                    Good_ID = delivery.Good_ID,
                    Shop_ID = (int)ShopComboBox.SelectedValue,
                    Count = delivery.Count
                };
                db.GoodsShops.Add(gs);
                db.SaveChanges();
                gs = (db.GoodsShops as IEnumerable<GoodsShops>)
                .Where(x => x.Shop_ID.Equals(ShopComboBox.SelectedValue != null ? ShopComboBox.SelectedValue : 0) &&
                x.Good_ID.Equals(delivery.Good_ID))
                .FirstOrDefault();
            }

            Shipment shipment = new Shipment()
            {
                Deliver_ID = delivery.Deliver_ID,
                GoodsShops_ID = gs.GoodsShops_ID,
                Employee_ID = (int)EmployeeComboBox.SelectedValue,
                Date = DateTime.Now
            };
            db.Shipment.Add(shipment);
            db.SaveChanges();
            this.Close();
        }
    }
}
