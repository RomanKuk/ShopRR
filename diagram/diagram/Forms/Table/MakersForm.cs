using diagram.Forms.InsernEdit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class MakersForm : Form
    {
        my_db_for_db_2Entities db;
        public MakersForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void MakersForm_Load(object sender, EventArgs e)
        {
            countriesBindingSource.DataSource = db.Countries.ToList();
            makersBindingSource.DataSource = db.Makers.ToList();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (MakersIEF frm = new MakersIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    makersBindingSource.DataSource = db.Makers.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (makersBindingSource.Current == null)
            {
                return;
            }
            using (MakersIEF frm = new MakersIEF(makersBindingSource.Current as Makers, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    makersBindingSource.DataSource = db.Makers.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (makersBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Makers.Remove(makersBindingSource.Current as Makers);
                    makersBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
