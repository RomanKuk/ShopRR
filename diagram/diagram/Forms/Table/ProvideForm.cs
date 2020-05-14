using diagram.Forms.InsernEdit;
using diagram.Forms.Users;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class ProvideForm : Form
    {
        my_db_for_db_2Entities db;
        public ProvideForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void ProvideForm_Load(object sender, EventArgs e)
        {
            addressBindingSource.DataSource = db.Address.ToList();
            provideBindingSource.DataSource = db.Provide.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (ProvideIEF frm = new ProvideIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    provideBindingSource.DataSource = db.Provide.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (provideBindingSource.Current == null)
            {
                return;
            }
            using (ProvideIEF frm = new ProvideIEF(provideBindingSource.Current as Provide, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    provideBindingSource.DataSource = db.Provide.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (provideBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Provide.Remove(provideBindingSource.Current as Provide);
                    provideBindingSource.RemoveCurrent();
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
