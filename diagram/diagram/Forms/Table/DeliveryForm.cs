using diagram.Forms.InsernEdit;
using diagram.Forms.Users;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class DeliveryForm : Form
    {
        my_db_for_db_2Entities db;
        public DeliveryForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            goodsBindingSource.DataSource = db.Goods.ToList();
            provideOrderBindingSource.DataSource = db.ProvideOrder.ToList();
            deliveryBindingSource.DataSource = db.Delivery.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (DeliveryIEF frm = new DeliveryIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    deliveryBindingSource.DataSource = db.Delivery.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (deliveryBindingSource.Current == null)
            {
                return;
            }
            using (DeliveryIEF frm = new DeliveryIEF(deliveryBindingSource.Current as Delivery, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    deliveryBindingSource.DataSource = db.Delivery.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (deliveryBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Delivery.Remove(deliveryBindingSource.Current as Delivery);
                    deliveryBindingSource.RemoveCurrent();
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
