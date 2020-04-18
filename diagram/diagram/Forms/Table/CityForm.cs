﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram
{
    public partial class CityForm : Form
    {
        my_db_for_db_2Entities db;
        public CityForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            countriesBindingSource.DataSource = db.Countries.ToList();
            cityBindingSource.DataSource = db.City.ToList();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (CityIEF frm = new CityIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    cityBindingSource.DataSource = db.City.ToList();
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (cityBindingSource.Current == null)
            {
                return;
            }
            using (CityIEF frm = new CityIEF(cityBindingSource.Current as City, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    cityBindingSource.DataSource = db.City.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (cityBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.City.Remove(cityBindingSource.Current as City);
                    cityBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
