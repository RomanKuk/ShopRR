using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class RepairIEF : Form
    {
        my_db_for_db_2Entities db;
        public RepairIEF(Repair obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            serviceTransportationBindingSource.DataSource = db.ServiceTransportation.ToList();
            repairBindingSource.DataSource = db.Repair.ToList();
            if (obj == null)
            {
                repairBindingSource.DataSource = new Repair();
                db.Repair.Add(repairBindingSource.Current as Repair);

            }
            else
            {
                repairBindingSource.DataSource = obj;
                db.Repair.Attach(repairBindingSource.Current as Repair);
            }
        }

        private void RepairIEF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(commentTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    commentTB.Focus();
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
    }
}
