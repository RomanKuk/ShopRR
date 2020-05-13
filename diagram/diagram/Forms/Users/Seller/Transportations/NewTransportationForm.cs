using diagram.Classes;
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
                .Where(x => x.Good_ID.Equals((int)(goodsComboBox.SelectedValue ?? 0))
                && x.Shop_ID.Equals(ShopFromComboBox.SelectedValue ?? 0))
                .Select(x => x.Count)
                .FirstOrDefault();
            int toCount = (db.GoodsShops as IEnumerable<GoodsShops>)
                .Where(x => x.Good_ID.Equals((int)(goodsComboBox.SelectedValue ?? 0))
                && x.Shop_ID.Equals(ShopToComboBox.SelectedValue ?? 0))
                .Select(x => x.Count)
                .FirstOrDefault();
            countNUD.Maximum = fromCount;
            fromLabel.Text = "В наявності (звідки): " + fromCount;
            toLabel.Text = "В наявності (куди): " + toCount; 
        }

        private void NewTransportationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if ( !ShopFromComboBox.SelectedValue.Equals(ShopToComboBox.SelectedValue))
                {
                    if (countNUD.Value < 1)
                    {
                        MessageBox.Show("Оберіть кількість", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        int goodID = (int)(goodsComboBox.SelectedValue ?? 0);
                        int shopTo = (int)(ShopToComboBox.SelectedValue ?? 0);
                        GoodsShops GS_To = (db.GoodsShops as IEnumerable<GoodsShops>)
                            .Where(x => x.Good_ID.Equals(goodID)
                            && x.Shop_ID.Equals(shopTo))
                            .Select(x => x)
                            .FirstOrDefault();
                        if (GS_To == null)
                        {
                            GS_To = new GoodsShops()
                            {
                                Code = CodeGenerator.GenerateCode("GoodsShops", "gs"),
                                Good_ID = goodID,
                                Shop_ID = shopTo,
                                Count = 0
                            };
                            db.GoodsShops.Add(GS_To);
                            db.SaveChanges();
                            GS_To = (db.GoodsShops as IEnumerable<GoodsShops>)
                                .Where(x => x.Good_ID.Equals(goodID)
                                && x.Shop_ID.Equals(shopTo))
                                .Select(x => x)
                                .FirstOrDefault();

                        }
                        GoodsShops GS_From = (db.GoodsShops as IEnumerable<GoodsShops>)
                            .Where(x => x.Good_ID.Equals(goodID)
                            && x.Shop_ID.Equals(ShopFromComboBox.SelectedValue ?? 0))
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
                        //this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Оберіть різні магазини", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                    return;
                }
            }
            e.Cancel = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
