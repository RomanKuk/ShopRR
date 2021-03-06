﻿using diagram.Forms.InsernEdit;
using diagram.Forms.Users;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class EmployeeForm : Form
    {
        my_db_for_db_2Entities db;
        public EmployeeForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'advancedDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.advancedDataSet.Employee);
            addressBindingSource.DataSource = db.Address.ToList();
            professionBindingSource.DataSource = db.Profession.ToList();
            shopsBindingSource.DataSource = db.Shops.ToList();
            serviceCenterBindingSource.DataSource = db.ServiceCenter.ToList();
            employeeBindingSource.DataSource = db.Employee.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (EmployeeIEF frm = new EmployeeIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    employeeBindingSource.DataSource = db.Employee.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (employeeBindingSource.Current == null)
            {
                return;
            }
            using (EmployeeIEF frm = new EmployeeIEF(employeeBindingSource.Current as Employee, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    employeeBindingSource.DataSource = db.Employee.ToList();
                }
                else
                {
                    db = new my_db_for_db_2Entities();
                    employeeBindingSource.DataSource = db.Employee.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (employeeBindingSource.Current != null)
            {
                if (MessageBox.Show("Ви впевнені ?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        db.Employee.Remove(employeeBindingSource.Current as Employee);
                        db.SaveChanges();
                        employeeBindingSource.RemoveCurrent();
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
