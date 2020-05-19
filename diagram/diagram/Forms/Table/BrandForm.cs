using diagram.Forms.InsernEdit;
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

namespace diagram.Forms.Table
{
    public partial class BrandForm : Form
    {
        my_db_for_db_2Entities db;
        public BrandForm(my_db_for_db_2Entities _db)
        {
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
                if (MessageBox.Show("Ви впевнені ?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        db.Brand.Remove(brandBindingSource.Current as Brand);
                        db.SaveChanges();
                        brandBindingSource.RemoveCurrent();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Дані не можливо видалити, оскільки це порушить цілісність бази даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
            new login.LoginForm(db).Show();
        }
    }
}
