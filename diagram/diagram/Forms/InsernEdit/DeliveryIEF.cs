using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class DeliveryIEF : Form
    {
        my_db_for_db_2Entities db;
        public DeliveryIEF(Delivery obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            goodsBindingSource.DataSource = db.Goods.ToList();
            provideOrderBindingSource.DataSource = db.ProvideOrder.ToList();
            deliveryBindingSource.DataSource = db.Delivery.ToList();
            if (obj == null)
            {
                deliveryBindingSource.DataSource = new Delivery();
                db.Delivery.Add(deliveryBindingSource.Current as Delivery);

            }
            else
            {
                deliveryBindingSource.DataSource = obj;
                db.Delivery.Attach(deliveryBindingSource.Current as Delivery);
            }
        }

        private void DeliveryIEF_FormClosing(object sender, FormClosingEventArgs e)
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
