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
    public partial class Form1 : Form
    {
        my_db_for_db_2Entities db;
        public Form1(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            countriesBindingSource.DataSource = db.Countries.ToList();

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (Form2 frm = new Form2(null,db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    countriesBindingSource.DataSource = db.Countries.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (countriesBindingSource.Current == null)
            {
                return;
            }
            using (Form2 frm = new Form2(countriesBindingSource.Current as Countries,db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    countriesBindingSource.DataSource = db.Countries.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (countriesBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Countries.Remove(countriesBindingSource.Current as Countries);
                    countriesBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
