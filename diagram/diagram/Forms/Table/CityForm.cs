using diagram.Forms.Users;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram
{
    public partial class CityForm : Form
    {
        my_db_for_db_2Entities db;
        public CityForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void CityForm_Load(object sender, EventArgs e)
        {
            countriesBindingSource.DataSource = db.Countries.ToList();
            cityBindingSource.DataSource = db.City.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (CityIEF frm = new CityIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    cityBindingSource.DataSource = db.City.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (cityBindingSource.Current == null)
            {
                return;
            }
            using (CityIEF frm = new CityIEF(cityBindingSource.Current as City, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    cityBindingSource.DataSource = db.City.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (cityBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.City.Remove(cityBindingSource.Current as City);
                    cityBindingSource.RemoveCurrent();
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
            new TableControlForm(db).Show();
            this.Close();
        }
    }
}
