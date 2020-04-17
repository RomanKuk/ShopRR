using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class BreakageForm : Form
    {
        my_db_for_db_2Entities db;
        public BreakageForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void BreakageForm_Load(object sender, EventArgs e)
        {
            breakageBindingSource.DataSource = db.Brand.ToList();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (BreakageIEF frm = new BreakageIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    breakageBindingSource.DataSource = db.Breakage.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (breakageBindingSource.Current == null)
            {
                return;
            }
            using (BreakageIEF frm = new BreakageIEF(breakageBindingSource.Current as Breakage, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    breakageBindingSource.DataSource = db.Breakage.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (breakageBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Breakage.Remove(breakageBindingSource.Current as Breakage);
                    breakageBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
