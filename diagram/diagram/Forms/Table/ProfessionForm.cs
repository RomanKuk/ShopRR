using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class ProfessionForm : Form
    {
        my_db_for_db_2Entities db;
        public ProfessionForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void ProfessionForm_Load(object sender, EventArgs e)
        {
            professionBindingSource.DataSource = db.Profession.ToList();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (ProfessionIEF frm = new ProfessionIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    professionBindingSource.DataSource = db.Profession.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (professionBindingSource.Current == null)
            {
                return;
            }
            using (ProfessionIEF frm = new ProfessionIEF(professionBindingSource.Current as Profession, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    professionBindingSource.DataSource = db.Profession.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (professionBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Profession.Remove(professionBindingSource.Current as Profession);
                    professionBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
