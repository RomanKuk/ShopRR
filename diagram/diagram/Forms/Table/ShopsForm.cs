using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class ShopsForm : Form
    {
        my_db_for_db_2Entities db;
        public ShopsForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void ShopsForm_Load(object sender, EventArgs e)
        {
            addressBindingSource.DataSource = db.Address.ToList();
            shopsBindingSource.DataSource = db.Shops.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (ShopIEF frm = new ShopIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    shopsBindingSource.DataSource = db.Shops.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (shopsBindingSource.Current == null)
            {
                return;
            }
            using (ShopIEF frm = new ShopIEF(shopsBindingSource.Current as Shops, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    shopsBindingSource.DataSource = db.Shops.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (shopsBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Shops.Remove(shopsBindingSource.Current as Shops);
                    shopsBindingSource.RemoveCurrent();
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
