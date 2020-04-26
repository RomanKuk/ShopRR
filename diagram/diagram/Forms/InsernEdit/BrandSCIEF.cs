using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class BrandSCIEF : Form
    {
        my_db_for_db_2Entities db;
        public BrandSCIEF(BrandSC obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            brandBindingSource.DataSource = db.Brand.ToList();
            serviceCenterBindingSource.DataSource = db.ServiceCenter.ToList();
            brandSCBindingSource.DataSource = db.BrandSC.ToList();
            if (obj == null)
            {
                brandSCBindingSource.DataSource = new BrandSC();
                db.BrandSC.Add(brandSCBindingSource.Current as BrandSC);

            }
            else
            {
                brandSCBindingSource.DataSource = obj;
                db.BrandSC.Attach(brandSCBindingSource.Current as BrandSC);
            }
        }

        private void BrandSCIEF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
