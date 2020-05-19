using diagram.Forms.InsernEdit;
using diagram.Forms.Users;
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

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
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

        private void changeUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Forms.login.LoginForm(db).Show();
        }
    }
}
