﻿using diagram.Forms.InsernEdit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Users.Seller
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

        private void SellerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'advancedDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.advancedDataSet.Sales);
            // TODO: This line of code loads data into the 'advancedDataSet.GoodsShops' table. You can move, or remove it, as needed.
            this.goodsShopsTableAdapter.Fill(this.advancedDataSet.GoodsShops);
            goodsBindingSource.DataSource = db.Goods.ToList();
            shopsBindingSource.DataSource = db.Shops.ToList();
            goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
            customersBindingSource.DataSource = db.Customers.ToList();
            salesBindingSource.DataSource = 
                (db.Sales as IEnumerable<Sales>)
                .Where(x => x.Employee_ID.Equals(employee.Employee_ID))
                .ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void OnlyThisShopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
        }

        private void newSalesBtn_Click(object sender, EventArgs e)
        {
            using (NewSalesForm form = new NewSalesForm(db, employee))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    salesBindingSource.DataSource = db.Sales.ToList();
                    this.salesTableAdapter.Fill(this.advancedDataSet.Sales);
                }
            }
            goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
            this.goodsShopsTableAdapter.Fill(this.advancedDataSet.GoodsShops);

        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Classes.FormState.PreviousPage = this;
            new InsernEdit.UserInfo(employee, db).Show();
        }

        private void NewConsumerBtn_Click(object sender, EventArgs e)
        {
            using (CustomersIEF frm = new CustomersIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    customersBindingSource.DataSource = db.Customers.ToList();
                }
            }
        }

        private void changeUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Forms.login.LoginForm(db).Show();
        }

        private void SalesContentBtn_Click(object sender, EventArgs e)
        {

        }

        private void showPasswordBtn_Click(object sender, EventArgs e)
        {
            if (advancedDataGridView2.CurrentRow != null)
            {
                string code = advancedDataGridView2.CurrentRow.Cells["salesCodeDataGridViewTextBoxColumn"].Value.ToString();
                using (SalesContentForm frm = new SalesContentForm(code, db))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show("оберіть продажу", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
