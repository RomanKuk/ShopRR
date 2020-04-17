using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class ProvideIEF : Form
    {
        my_db_for_db_2Entities db;
        public ProvideIEF(City obj, my_db_for_db_2Entities _db)
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
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox3.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
