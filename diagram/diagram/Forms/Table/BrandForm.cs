using diagram.Classes;
using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class BrandForm : Form
    {
        my_db_for_db_2Entities db;
        Employee employee;
        public BrandForm(my_db_for_db_2Entities _db, Employee _employee)
        {
            employee = _employee;
            if (employee.Employee_ID.Equals(4))//якщо адмін
            {
                MenuStrip menuStrip = AdminMenu.getMenu(db, employee);
                this.MainMenuStrip = menuStrip;
                this.Controls.Add(menuStrip);
            }
            InitializeComponent();
            db = _db;
        }

        private void BrandForm_Load(object sender, EventArgs e)
        {
            countriesBindingSource.DataSource = db.Countries.ToList();
            brandBindingSource.DataSource = db.Brand.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (BrandIEF frm = new BrandIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    brandBindingSource.DataSource = db.Brand.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (brandBindingSource.Current == null)
            {
                return;
            }
            using (BrandIEF frm = new BrandIEF(brandBindingSource.Current as Brand, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    brandBindingSource.DataSource = db.Brand.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (brandBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Brand.Remove(brandBindingSource.Current as Brand);
                    brandBindingSource.RemoveCurrent();
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
