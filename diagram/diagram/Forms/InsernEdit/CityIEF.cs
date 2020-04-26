using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diagram
{
    public partial class CityIEF : Form
    {
        my_db_for_db_2Entities db;
        public CityIEF(City obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            countriesBindingSource.DataSource = db.Countries.ToList();
            if (obj == null)
            {
                cityBindingSource.DataSource = new City();
                db.City.Add(cityBindingSource.Current as City);

            }
            else
            {
                cityBindingSource.DataSource = obj;
                db.City.Attach(cityBindingSource.Current as City);
            }
        }

        private void CityIEF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(cityNameTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cityNameTB.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
