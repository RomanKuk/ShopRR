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
    public partial class Form2 : Form
    {
        my_db_for_db_2Entities db;
        public Form2(Countries obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            if (obj == null)
            {
                countriesBindingSource.DataSource = new Countries();
                db.Countries.Add(countriesBindingSource.Current as Countries);
            }
            else
            {
                countriesBindingSource.DataSource = obj;
                db.Countries.Attach(countriesBindingSource.Current as Countries);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
