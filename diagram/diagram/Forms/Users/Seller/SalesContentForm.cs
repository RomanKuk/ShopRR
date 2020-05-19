using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Users.Seller
{
    public partial class SalesContentForm : Form
    {
        string sales;
        my_db_for_db_2Entities db;
        public SalesContentForm(string _sales,my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            sales = _sales;
            db = _db;
        }

        private void SalesContentForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int salesID = (db.Sales as IEnumerable<Sales>)
                .Where(x => x.SalesCode.Equals(sales))
                .Select(x => x.Sales_ID).FirstOrDefault();
            List<Basket> baskets = (db.Basket as IEnumerable<Basket>)
                .Where(x => x.Sales_ID.Equals(salesID))
                .ToList();
            foreach (Basket b in baskets)
            {
                int goodID = (db.GoodsShops as IEnumerable<GoodsShops>)
                    .Where(x => x.GoodsShops_ID.Equals(b.GoodsShops_ID))
                    .Select( x => x.Good_ID)
                    .FirstOrDefault();
                string model = (db.Goods as IEnumerable<Goods>)
                    .Where(x => x.Good_ID.Equals(goodID))
                    .Select(x => x.Model)
                    .FirstOrDefault();
                dataGridView1.Rows.Add(model, b.Count);
            }
            salesCodeLabel.Text = "Продаж номер : " + sales;

        }
    }
}
