using diagram.Forms.InsernEdit;
using diagram.Forms.Users;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class StatusForm : Form
    {
        my_db_for_db_2Entities db;
        public StatusForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void StatusForm_Load(object sender, EventArgs e)
        {
            statusBindingSource.DataSource = db.Status.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (StatusIEF frm = new StatusIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    statusBindingSource.DataSource = db.Status.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (statusBindingSource.Current == null)
            {
                return;
            }
            using (StatusIEF frm = new StatusIEF(statusBindingSource.Current as Status, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    statusBindingSource.DataSource = db.Status.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (statusBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Status.Remove(statusBindingSource.Current as Status);
                    statusBindingSource.RemoveCurrent();
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
            this.Hide();
            Classes.FormState.PreviousPage = this;
            new TableControlForm(db).Show();
        }
    }
}
