using diagram.Forms.InsernEdit;
using diagram.Forms.Users;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class CategoriesSCForm : Form
    {
        my_db_for_db_2Entities db;
        public CategoriesSCForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void CategoriesSCForm_Load(object sender, EventArgs e)
        {
            categoriesBindingSource.DataSource = db.Categories.ToList();
            serviceCenterBindingSource.DataSource = db.ServiceCenter.ToList();
            categoriesSCBindingSource.DataSource = db.CategoriesSC.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (CategoriesSCIEF frm = new CategoriesSCIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    categoriesSCBindingSource.DataSource = db.CategoriesSC.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (categoriesSCBindingSource.Current == null)
            {
                return;
            }
            using (CategoriesSCIEF frm = new CategoriesSCIEF(categoriesSCBindingSource.Current as CategoriesSC, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    categoriesSCBindingSource.DataSource = db.CategoriesSC.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (categoriesSCBindingSource.Current != null)
            {
                if (MessageBox.Show("Ви впевнені ?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        db.CategoriesSC.Remove(categoriesSCBindingSource.Current as CategoriesSC);
                        db.SaveChanges();
                        categoriesSCBindingSource.RemoveCurrent();
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
