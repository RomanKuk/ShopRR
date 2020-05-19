﻿using diagram.Forms.InsernEdit;
using diagram.Forms.Users;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class TransportationForm : Form
    {
        my_db_for_db_2Entities db;
        public TransportationForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void TransportationForm_Load(object sender, EventArgs e)
        {
            goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
            employeeBindingSource.DataSource = db.Employee.ToList();
            transportationBindingSource.DataSource = db.Transportation.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (TransportationIEF frm = new TransportationIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    transportationBindingSource.DataSource = db.Transportation.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (transportationBindingSource.Current == null)
            {
                return;
            }
            using (TransportationIEF frm = new TransportationIEF(transportationBindingSource.Current as Transportation, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    transportationBindingSource.DataSource = db.Transportation.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (transportationBindingSource.Current != null)
            {
                if (MessageBox.Show("Ви впевнені ?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        db.Transportation.Remove(transportationBindingSource.Current as Transportation);
                        db.SaveChanges();
                        transportationBindingSource.RemoveCurrent();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Дані не можливо видалити, оскільки це порушить цілісність бази даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
            Classes.FormState.PreviousPage = this;
            new TableControlForm(db).Show();
        }

        private void changeUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Forms.login.LoginForm(db).Show();
        }
    }
}
