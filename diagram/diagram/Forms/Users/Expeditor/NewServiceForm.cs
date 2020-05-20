using diagram.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Users.Expeditor
{
    public partial class NewServiceForm : Form
    {
        const int MONEY_STATUS = 6;//TODO вставити ID статусу - Повернути гроші 
        const int EXCHANGE_STATUS = 7;//TODO вставити ID статусу - Підлягає поверненю 
        Employee employee;
        my_db_for_db_2Entities db;
        public NewServiceForm(my_db_for_db_2Entities _db, Employee _employee)
        {
            db = _db;
            employee = _employee;
            InitializeComponent();
        }

        private void NewServiceForm_Load(object sender, EventArgs e)
        {
            salesBindingSource.DataSource = db.Sales.ToList();
            breakageBindingSource.DataSource = db.Breakage.ToList();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            createService(5);// Очікує перевезення 
            this.Close();
        }

        private void SalesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> baskets = (db.Basket as IEnumerable<Basket>)
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewServiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void MoneyBtn_Click(object sender, EventArgs e)
        {
            twoWeekTerm(MONEY_STATUS, "Товар не підлягає поверненю після 14 днів після купівлі");
        }

        private void ExchangeBtn_Click(object sender, EventArgs e)
        {
            twoWeekTerm(EXCHANGE_STATUS, "Товар не підлягає заміні після 14 днів після купівлі");
        }

        private void createService(int status)
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
                Status_ID = status,
                Basket_ID = basket,
                Date = DateTime.Now
            };
            db.Service.Add(service);
            db.SaveChanges();
            MessageBox.Show(service.Code, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void twoWeekTerm(int code, string message)
        {
            Sales sales = (db.Sales as IEnumerable<Sales>)
                .Where(x => x.Sales_ID.Equals(SalesComboBox.SelectedValue))
                .FirstOrDefault();
            DateTime dt = sales.Date;

            if (DateTime.Now > dt.AddDays(14))
            {
                if (sales.Guarante)
                {
                    if (DateTime.Now > dt.AddYears(1))
                    {
                        MessageBox.Show("Гарантійний термін вийшов", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CheckExchangesStatus(code);
                    }
                }
                else
                {
                    MessageBox.Show(message, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                CheckExchangesStatus(code);
            }
        }

        private void CheckExchangesStatus(int code)
        {
            if (code.Equals(EXCHANGE_STATUS))
            {
                // провірити чи є товар в даний момент на складі
                try
                {
                    GoodsShops goodsShop = (db.GoodsShops as IEnumerable<GoodsShops>)
                        .Where(x => x.Good_ID.Equals(GoodsComboBox.SelectedValue) &&
                        x.Shop_ID.Equals(employee.Shop_ID))
                        .FirstOrDefault();
                    if (goodsShop.Count > 0)
                    {
                        db.GoodsShops.Attach(goodsShop);
                        goodsShop.Count -= 1;
                        db.SaveChanges();
                        createService(code);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("В даний момент у магазині немає цього товару", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(NullReferenceException)
                {
                    MessageBox.Show("В даний момент у магазині немає цього товару", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                createService(code);
                this.Close();
            }
        }
    }
}
