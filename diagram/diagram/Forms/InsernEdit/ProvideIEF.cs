using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class ProvideIEF : Form
    {
        my_db_for_db_2Entities db;
        public ProvideIEF(Provide obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            addressBindingSource.DataSource = db.Address.ToList();
            provideBindingSource.DataSource = db.Provide.ToList();
            if (obj == null)
            {
                provideBindingSource.DataSource = new Provide();
                db.Provide.Add(provideBindingSource.Current as Provide);

            }
            else
            {
                provideBindingSource.DataSource = obj;
                db.Provide.Attach(provideBindingSource.Current as Provide);
            }
        }

        private void ProvideIEF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(provideNameTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    provideNameTB.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(contactPersonTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    contactPersonTB.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(phoneTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    phoneTB.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
