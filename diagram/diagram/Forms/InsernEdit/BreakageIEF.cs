using System;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class BreakageIEF : Form
    {
        my_db_for_db_2Entities db;
        public BreakageIEF(Breakage obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            if (obj == null)
            {
                breakageBindingSource.DataSource = new Breakage();
                db.Breakage.Add(breakageBindingSource.Current as Breakage);

            }
            else
            {
                breakageBindingSource.DataSource = obj;
                db.Breakage.Attach(breakageBindingSource.Current as Breakage);
            }
        }

        private void BreakageIEF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(breakageNameTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    breakageNameTB.Focus();
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
