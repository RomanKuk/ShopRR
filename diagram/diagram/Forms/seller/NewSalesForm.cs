﻿using System;
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
    public partial class NewSalesForm : Form
    {
        my_db_for_db_2Entities db;
        Employee employee;
        Dictionary<String,Basket> basketsContain;
        public NewSalesForm(my_db_for_db_2Entities _db, Employee _employee)
        {
            db = _db;
            employee = _employee;
            InitializeComponent();
            basketsContain = new Dictionary<String, Basket>();

        }

        private void NewSalesForm_Load(object sender, EventArgs e)
        {
            customersBindingSource.DataSource = db.Customers.ToList();
            //вибираю айдішки товарів які є в наявності в даному магазині
            List<int> goods = (db.GoodsShops as IEnumerable<GoodsShops>)
                .Where(x => x.Shop_ID.Equals(employee.Shop_ID) && x.Count > 0)
                .Select(x => x.Good_ID)
                .ToList();

            //відображаю відповідні товари в комбо боксі
            goodsBindingSource.DataSource =
                (db.Goods as IEnumerable<Goods>)
                .Where(g => goods.Contains(g.Good_ID))
                .ToList();
            //TODO при запуску форми обирати значення в комбобокс
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int count = (int)goodCount.Value;
            if (count > 0)
            {
                if (!basketsContain.ContainsKey(goodsComboBox.Text))
                {
                    int goodID = (int)goodsComboBox.SelectedValue;
                    int GS_ID = (db.GoodsShops as IEnumerable<GoodsShops>)
                            .Where(x => x.Shop_ID.Equals(employee.Shop_ID) && x.Good_ID.Equals(goodID))
                            .First().GoodsShops_ID;

                    string basketCode = "t0001";//TODO генераток кодів

                    basketsContain.Add(goodsComboBox.Text, new Basket()
                    {
                        Code = basketCode,
                        GoodsShops_ID = GS_ID,
                        //Sales_ID = salesID,
                        Count = count
                    });
                    //Відобразити в таблиці
                    dataGridView1.Rows.Add(goodsComboBox.Text, count);
                }
                else
                {
                    //повідомлення що товар уже є в списку
                }
            }
            else
            {
                // повідомлення що потрібно обрати кількість
            }
        }

        private void GoodsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //обмежую кількість товарів до наявної в магазині
            int maxCount = (db.GoodsShops as IEnumerable<GoodsShops>)
                .Where(x => x.Good_ID.Equals((int)(goodsComboBox.SelectedValue != null ? goodsComboBox.SelectedValue:0)))
                .Select(x => x.Count)
                .FirstOrDefault();
            goodCount.Maximum = maxCount;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                basketsContain.Remove(dataGridView1.CurrentRow.Cells["Goods"].Value.ToString());
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //TODO провірки

            int goodID;
            decimal price = 0;
            decimal totalPrice = 0;
            //ціна 
            foreach (Basket basket in basketsContain.Values)
            {
                goodID = db.GoodsShops
                    .Where(x => x.GoodsShops_ID.Equals(basket.GoodsShops_ID))
                    .Select(x => x.Good_ID)
                    .First();
                price = db.Goods
                    .Where(x => x.Good_ID.Equals(goodID))
                    .Select(x => x.Price)
                    .First();
                totalPrice += price * basket.Count;
            }
            //генеруємо продажу
            Sales sales = new Sales()
            {
                SalesCode = "test01",//TODO generate
                Employee_ID = employee.Employee_ID,
                Customer_ID = (int)customerComboBox.SelectedValue,
                Date = DateTime.Now,
                Total = totalPrice
            };

            db.Sales.Add(sales);
            db.SaveChanges();
            sales = (db.Sales as IEnumerable<Sales>)
                .Where(x => x.SalesCode.Equals(sales.SalesCode))
                .First();

            GoodsShops gs;
            foreach (Basket basket in basketsContain.Values)
            {
                // записуємо вмістиме корзини в бд
                basket.Sales_ID = sales.Sales_ID;
                db.Basket.Add(basket);
                    gs = db.GoodsShops
                    .Where(x => x.GoodsShops_ID.Equals(basket.GoodsShops_ID))
                    .First();
                // зменшити кількість товарів
                db.GoodsShops.Attach(gs);
                gs.Count -= basket.Count;
                db.SaveChanges();
            }
            //db.SaveChanges();
            //TODO закриття форми і вивести загальну суму
        }
    }
}
