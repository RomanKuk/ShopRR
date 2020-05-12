using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Users.Seller.Transportations
{
    public partial class NewTransportationForm : Form
    {
        my_db_for_db_2Entities db;
        Employee employee;
        public NewTransportationForm(my_db_for_db_2Entities _db, Employee _employee)
        {
            db = _db;
            employee = _employee;
            InitializeComponent();
        }

        private void NewTransportationForm_Load(object sender, EventArgs e)
        {
            goodsBindingSource.DataSource = db.Goods.ToList();
            shopsBindingSource.DataSource = db.Shops.ToList();
            shopsBindingSource1.DataSource = db.Shops.ToList();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (ShopFromComboBox.SelectedValue.Equals(ShopToComboBox.SelectedValue))
            {
                MessageBox.Show("Оберіть різні магазини", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (countNUD.Value < 1)
                {
                    MessageBox.Show("Оберіть кількість", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GoodsShops GS_To = (db.GoodsShops as IEnumerable<GoodsShops>)
                    .Where(x => x.Good_ID.Equals((int)(goodsComboBox.SelectedValue != null ? goodsComboBox.SelectedValue : 0))
                    && x.Shop_ID.Equals(ShopToComboBox.SelectedValue != null ? ShopToComboBox.SelectedValue : 0))
                    .Select(x => x)
                    .FirstOrDefault();
                    GoodsShops GS_From = (db.GoodsShops as IEnumerable<GoodsShops>)
                        .Where(x => x.Good_ID.Equals((int)(goodsComboBox.SelectedValue != null ? goodsComboBox.SelectedValue : 0))
                        && x.Shop_ID.Equals(ShopFromComboBox.SelectedValue != null ? ShopFromComboBox.SelectedValue : 0))
                        .Select(x => x)
                        .FirstOrDefault();
                    int count = (int)countNUD.Value;
                    Transportation transportation = new Transportation()
                    {
                        GS_from_ID = GS_From.GoodsShops_ID,
                        GS_in_ID = GS_To.GoodsShops_ID,
                        Employee_ID = employee.Employee_ID,
                        Date = DateTime.Now,
                        Count = count
                    };

                    db.Transportation.Add(transportation);
                    db.GoodsShops.Attach(GS_From);
                    GS_From.Count -= count;
                    db.GoodsShops.Attach(GS_To);
                    GS_To.Count += count;
                    db.SaveChanges();
                    this.Close();
                }
            }
        }

        private void GoodsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeCount();
        }

        private void ShopFromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeCount();
        }

        private void ShopToComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeCount();
        }

        private void changeCount()
        {
            //обмежую кількість товарів до наявної в магазині
            int fromCount = (db.GoodsShops as IEnumerable<GoodsShops>)
                .Where(x => x.Good_ID.Equals((int)(goodsComboBox.SelectedValue != null ? goodsComboBox.SelectedValue : 0))
                && x.Shop_ID.Equals(ShopFromComboBox.SelectedValue != null ? ShopFromComboBox.SelectedValue : 0))
                .Select(x => x.Count)
                .FirstOrDefault();
            int toCount = (db.GoodsShops as IEnumerable<GoodsShops>)
                .Where(x => x.Good_ID.Equals((int)(goodsComboBox.SelectedValue != null ? goodsComboBox.SelectedValue : 0))
                && x.Shop_ID.Equals(ShopToComboBox.SelectedValue != null ? ShopToComboBox.SelectedValue : 0))
                .Select(x => x.Count)
                .FirstOrDefault();
            countNUD.Maximum = fromCount;
            fromLabel.Text = "В наявності:" + fromCount;
            toLabel.Text = "В наявності:" + toCount; 
        }


    }
}
