﻿using diagram.Classes;
using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class CategoriesSCForm : Form
    {
        my_db_for_db_2Entities db;
        Employee employee;
        public CategoriesSCForm(my_db_for_db_2Entities _db, Employee _employee)
        {
            employee = _employee;
            if (employee.Employee_ID.Equals(4))//якщо адмін
            {
                MenuStrip menuStrip = AdminMenu.getMenu(db, employee);
                this.MainMenuStrip = menuStrip;
                this.Controls.Add(menuStrip);
            }
            InitializeComponent();
            db = _db;
        }

        private void CategoriesSCForm_Load(object sender, EventArgs e)
        {
            categoriesBindingSource.DataSource = db.Categories.ToList();
            serviceCenterBindingSource.DataSource = db.ServiceCenter.ToList();
            categoriesSCBindingSource.DataSource = db.CategoriesSC.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (CategoriesSCIEF frm = new CategoriesSCIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    categoriesSCBindingSource.DataSource = db.CategoriesSC.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (categoriesSCBindingSource.Current == null)
            {
                return;
            }
            using (CategoriesSCIEF frm = new CategoriesSCIEF(categoriesSCBindingSource.Current as CategoriesSC, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    categoriesSCBindingSource.DataSource = db.CategoriesSC.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (categoriesSCBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.CategoriesSC.Remove(categoriesSCBindingSource.Current as CategoriesSC);
                    categoriesSCBindingSource.RemoveCurrent();
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

        }
    }
}
