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
    public partial class StatusIEF : Form
    {
        my_db_for_db_2Entities db;
        public StatusIEF(Status obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            statusBindingSource.DataSource = db.Countries.ToList();
            if (obj == null)
            {
                statusBindingSource.DataSource = new Status();
                db.Status.Add(statusBindingSource.Current as Status);

            }
            else
            {
                statusBindingSource.DataSource = obj;
                db.Status.Attach(statusBindingSource.Current as Status);
            }
        }

        private void StatusIEF_FormClosing(object sender, FormClosingEventArgs e)
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
