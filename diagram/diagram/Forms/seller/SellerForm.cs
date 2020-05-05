using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diagram.Forms.seller
{
    public partial class SellerForm : Form
    {
        my_db_for_db_2Entities db;
        Employee employee;
        public SellerForm(my_db_for_db_2Entities _db,Employee _employee)
        {
            db = _db;
            employee = _employee;
            InitializeComponent();
        }

        private void UpdateGSTable()
        {
            if (OnlyThisShopCheckBox.Checked)
            {
                goodsShopsBindingSource.DataSource =
                    (db.GoodsShops as IEnumerable<GoodsShops>)
                    .Where(x => x.Shop_ID.Equals(employee.Shop_ID))
                    .ToList();
            }
            else
            {
                goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
            }
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            goodsBindingSource.DataSource = db.Goods.ToList();
            shopsBindingSource.DataSource = db.Shops.ToList();
            goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
            customersBindingSource.DataSource = db.Customers.ToList();
            salesBindingSource.DataSource = 
                (db.Sales as IEnumerable<Sales>)
                .Where(x => x.Employee_ID.Equals(employee.Employee_ID))
                .ToList();
        }

        private void OnlyThisShopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGSTable();
        }
    }
}
