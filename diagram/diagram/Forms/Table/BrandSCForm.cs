﻿using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class BrandSCForm : Form
    {
        my_db_for_db_2Entities db;
        public BrandSCForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void BrandSCForm_Load(object sender, EventArgs e)
        {
            brandBindingSource.DataSource = db.Brand.ToList();
            serviceCenterBindingSource.DataSource = db.ServiceCenter.ToList();
            brandSCBindingSource.DataSource = db.BrandSC.ToList();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (BrandSCIEF frm = new BrandSCIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    brandSCBindingSource.DataSource = db.BrandSC.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (brandSCBindingSource.Current == null)
            {
                return;
            }
            using (BrandSCIEF frm = new BrandSCIEF(brandSCBindingSource.Current as BrandSC, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    brandSCBindingSource.DataSource = db.BrandSC.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (brandSCBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.BrandSC.Remove(brandSCBindingSource.Current as BrandSC);
                    brandSCBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}