﻿using diagram.Classes;
using diagram.Forms.InsernEdit;
using diagram.Forms.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class BasketForm : Form
    {
        my_db_for_db_2Entities db;
        public BasketForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void BasketForm_Load(object sender, EventArgs e)
        {
            goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
            salesBindingSource.DataSource = db.Sales.ToList();
            basketBindingSource.DataSource = db.Basket.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (BasketIEF frm = new BasketIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    basketBindingSource.DataSource = db.Basket.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (basketBindingSource.Current == null)
            {
                return;
            }
            using (BasketIEF frm = new BasketIEF(basketBindingSource.Current as Basket, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    basketBindingSource.DataSource = db.Basket.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (basketBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Basket.Remove(basketBindingSource.Current as Basket);
                    basketBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
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
            FormState.PreviousPage = this;
            new TableControlForm(db).Show();
        }

        private void changeUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login.LoginForm(db).Show();
        }
    }
}
