﻿using diagram.Forms.expeditor;
using diagram.Forms.seller;
using diagram.Forms.transportation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.login
{
    public partial class LoginForm : Form
    {
        my_db_for_db_2Entities db;
        Employee employee;
        public LoginForm(my_db_for_db_2Entities _db)
        {
            db = _db;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                employee = (db.Employee as IEnumerable<Employee>)
                    .Where(x => x.LoginName.Equals(loginTextBox.Text) &&
                    x.Password.Equals(passwordTextBox.Text)).First();
                login();
            } catch (InvalidOperationException exc)
            {
                MessageBox.Show("Введіть коректні логін та пароль", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                passwordTextBox.Text = "";
            }
        }

        private void login()
        {
            switch (employee.Profession_ID)
            {
                case 1 ://Продавець
                    new SellerForm(db, employee).Show();
                    break;
                case 2://Водій
                    MessageBox.Show("даний користувач неіснує", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3://Менеджер
                    new ManagerForm(db,employee).Show();
                    break;
                case 4://Адмін
                    MessageBox.Show("даний користувач неіснує", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 5://Консультант
                    MessageBox.Show("даний користувач неіснує", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 6://Експедитор
                    new ExpeditorForm(db, employee).Show();
                    break;
                case 7://Працівник сервісного центру
                    new service.ServiceCenterForm(db, employee).Show();
                    break;
            }
            this.Hide();
        }
    }
}
