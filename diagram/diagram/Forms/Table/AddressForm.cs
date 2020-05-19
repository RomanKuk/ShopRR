using diagram.Classes;
using diagram.Forms.InsernEdit;
using diagram.Forms.Users;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class AddressForm : Form
    {
        my_db_for_db_2Entities db;
        public AddressForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {
            cityBindingSource.DataSource = db.City.ToList();
            addressBindingSource.DataSource = db.Address.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (AddressIEF frm = new AddressIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    addressBindingSource.DataSource = db.Address.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (addressBindingSource.Current == null)
            {
                return;
            }
            using (AddressIEF frm = new AddressIEF(addressBindingSource.Current as Address, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    addressBindingSource.DataSource = db.Address.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (addressBindingSource.Current != null)
            {
                if (MessageBox.Show("Ви впевнені ?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        db.Address.Remove(addressBindingSource.Current as Address);
                        db.SaveChanges();
                        addressBindingSource.RemoveCurrent();
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
            FormState.PreviousPage = this;
            new TableControlForm(db).Show();
        }

        private void changeUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login.LoginForm(db).Show();
        }
    }
}
