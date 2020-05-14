using diagram.Forms.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diagram
{
    public partial class CountriesForm : Form
    {
        my_db_for_db_2Entities db;
        public CountriesForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            countriesBindingSource.DataSource = db.Countries.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (CountriesIEF frm = new CountriesIEF(null,db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    countriesBindingSource.DataSource = db.Countries.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (countriesBindingSource.Current == null)
            {
                return;
            }
            using (CountriesIEF frm = new CountriesIEF(countriesBindingSource.Current as Countries,db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    countriesBindingSource.DataSource = db.Countries.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (countriesBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Countries.Remove(countriesBindingSource.Current as Countries);
                    countriesBindingSource.RemoveCurrent();
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
