using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class BasketIEF : Form
    {
        my_db_for_db_2Entities db;
        public BasketIEF(Basket obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
            salesBindingSource.DataSource = db.Sales.ToList();
            if (obj == null)
            {
                basketBindingSource.DataSource = new Basket();
                db.Basket.Add(basketBindingSource.Current as Basket);

            }
            else
            {
                basketBindingSource.DataSource = obj;
                db.Basket.Attach(basketBindingSource.Current as Basket);
            }
        }


        private void BasketIEF_FormClosing(object sender, FormClosingEventArgs e)
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
