using diagram.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.expeditor
{
    public partial class NewServiceForm : Form
    {
        my_db_for_db_2Entities db;
        public NewServiceForm(my_db_for_db_2Entities _db)
        {
            db = _db;
            InitializeComponent();
        }

        private void NewServiceForm_Load(object sender, EventArgs e)
        {
            salesBindingSource.DataSource = db.Sales.ToList();
            breakageBindingSource.DataSource = db.Breakage.ToList();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void SalesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> baskets =  (db.Basket as IEnumerable<Basket>)
                .Where(x => x.Sales_ID.Equals(SalesComboBox.SelectedValue))
                .Select(x => x.GoodsShops_ID)
                .ToList();
            List<int> goods = (db.GoodsShops as IEnumerable<GoodsShops>)
                .Where(x => baskets.Contains(x.GoodsShops_ID))
                .Select(x => x.Good_ID)
                .ToList();
            goodsBindingSource.DataSource = (db.Goods as IEnumerable<Goods>)
                .Where(x => goods.Contains(x.Good_ID))
                .ToList();
        }

        private void NewServiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                List<int> goodsShop = (db.GoodsShops as IEnumerable<GoodsShops>)
                    .Where(x => x.Good_ID.Equals(GoodsComboBox.SelectedValue))
                    .Select(x => x.GoodsShops_ID)
                    .ToList();
                int basket = (db.Basket as IEnumerable<Basket>)
                    .Where(x => x.Sales_ID.Equals(SalesComboBox.SelectedValue) && goodsShop.Contains(x.GoodsShops_ID))
                    .Select(x => x.Basket_ID)
                    .FirstOrDefault();
                //TODO
                Service service = new Service()
                {
                    Code = CodeGenerator.GenerateCode("Service", "se"),
                    Breakage_ID = (int)BreakageComboBox.SelectedValue,
                    Status_ID = 5,// Очікує перевезення 
                    Basket_ID = basket,
                    Date = DateTime.Now
                };
                db.Service.Add(service);
                db.SaveChanges();
                MessageBox.Show(service.Code, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            e.Cancel = false;
        }
    }
}
