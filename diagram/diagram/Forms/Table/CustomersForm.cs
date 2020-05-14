﻿using diagram.Forms.InsernEdit;
using diagram.Forms.Users;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class CustomersForm : Form
    {
        my_db_for_db_2Entities db;
        public CustomersForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            addressBindingSource.DataSource = db.Address.ToList();
            customersBindingSource.DataSource = db.Customers.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (CustomersIEF frm = new CustomersIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    customersBindingSource.DataSource = db.Customers.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (customersBindingSource.Current == null)
            {
                return;
            }
            using (CustomersIEF frm = new CustomersIEF(customersBindingSource.Current as Customers, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    customersBindingSource.DataSource = db.Customers.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (customersBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Customers.Remove(customersBindingSource.Current as Customers);
                    customersBindingSource.RemoveCurrent();
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
            new TableControlForm(db).Show();
            this.Close();
        }
    }
}
