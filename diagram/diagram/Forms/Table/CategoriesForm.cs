using diagram.Forms.InsernEdit;
using diagram.Forms.Users;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class CategoriesForm : Form
    {
        my_db_for_db_2Entities db;
        public CategoriesForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            categoriesBindingSource1.DataSource = db.Categories.ToList();
            categoriesBindingSource.DataSource = db.Categories.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (CategoriesIEF frm = new CategoriesIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    categoriesBindingSource.DataSource = db.Categories.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (categoriesBindingSource.Current == null)
            {
                return;
            }
            using (CategoriesIEF frm = new CategoriesIEF(categoriesBindingSource.Current as Categories, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    categoriesBindingSource.DataSource = db.Categories.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (categoriesBindingSource.Current != null)
            {
                if (MessageBox.Show("Ви впевнені ?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        db.Categories.Remove(categoriesBindingSource.Current as Categories);
                        db.SaveChanges();
                        categoriesBindingSource.RemoveCurrent();
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
