using diagram.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Users.Expeditor
{
    public partial class NewDeliveryForm : Form
    {
        my_db_for_db_2Entities db;
        Employee employee;
        Dictionary<String, Delivery> deliveryContain;
        public NewDeliveryForm(my_db_for_db_2Entities _db, Employee _employee)
        {
            db = _db;
            employee = _employee;
            InitializeComponent();
            deliveryContain = new Dictionary<string, Delivery>();
        }

        private void NewDeliveryForm_Load(object sender, EventArgs e)
        {
            provideBindingSource.DataSource = db.Provide.ToList();
            goodsBindingSource.DataSource = db.Goods.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int count = (int) countNUD.Value;
            if (count > 0)
            {
                if (!deliveryContain.ContainsKey(goodsComboBox.Text))
                {
                    int goodID = (int)goodsComboBox.SelectedValue;

                    string deliveryCode = CodeGenerator.GenerateCode("Delivery", "d");
                    deliveryContain.Add(goodsComboBox.Text, new Delivery()
                    {
                        Good_ID = goodID,
                        Count = count
                    });
                    //Відобразити в таблиці
                    dataGridView1.Rows.Add(goodsComboBox.Text, count);
                    TotalPrice();
                }
                else
                {
                    MessageBox.Show("Current goods, presence in delivery ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select count", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                deliveryContain.Remove(dataGridView1.CurrentRow.Cells["Goods"].Value.ToString());
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                TotalPrice();
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            //TODO провірки
            ProvideOrder provideOrder = new ProvideOrder()
            {
                Code = CodeGenerator.GenerateCode("ProvideOrder", "po"),
                Date = DateTime.Now,
                TotalCost = (int) TotalPrice(),
                Provide_ID = (int) ProviderComboBox.SelectedValue
            };

            db.ProvideOrder.Add(provideOrder);
            db.SaveChanges();
            provideOrder = (db.ProvideOrder as IEnumerable<ProvideOrder>)
                .Where(x => x.Code.Equals(provideOrder.Code))
                .First();

            foreach (Delivery delivery in deliveryContain.Values)
            {
                // записуємо вмістиме корзини в бд
                delivery.Code = CodeGenerator.GenerateCode("Delivery", "d");
                delivery.ProvideOrder_ID = provideOrder.ProvideOrder_ID;
                delivery.Date = DateTime.Now;
                db.Delivery.Add(delivery);
                db.SaveChanges();
            }
            //db.SaveChanges();
            MessageBox.Show(totalPriceLabel.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal TotalPrice()
        {
            decimal price = 0;
            decimal totalPrice = 0;
            //ціна 
            foreach (Delivery delivery in deliveryContain.Values)
            {
                price = db.Goods
                    .Where(x => x.Good_ID.Equals(delivery.Good_ID))
                    .Select(x => x.RevenuePrice)
                    .First();
                totalPrice += price * delivery.Count;
            }
            totalPriceLabel.Text = "Загальна сума : " + totalPrice;
            return totalPrice;
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
