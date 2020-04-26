using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class RepairForm : Form
    {
        my_db_for_db_2Entities db;
        public RepairForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void RepairForm_Load(object sender, EventArgs e)
        {
            serviceTransportationBindingSource.DataSource = db.ServiceTransportation.ToList();
            repairBindingSource.DataSource = db.Repair.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (RepairIEF frm = new RepairIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    repairBindingSource.DataSource = db.Repair.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (repairBindingSource.Current == null)
            {
                return;
            }
            using (RepairIEF frm = new RepairIEF(repairBindingSource.Current as Repair, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    repairBindingSource.DataSource = db.Repair.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (repairBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Repair.Remove(repairBindingSource.Current as Repair);
                    repairBindingSource.RemoveCurrent();
                    db.SaveChanges();
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

        }
    }
}
