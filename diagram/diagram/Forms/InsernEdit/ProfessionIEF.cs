using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class ProfessionIEF : Form
    {
        my_db_for_db_2Entities db;
        public ProfessionIEF(Profession obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            professionBindingSource.DataSource = db.Profession.ToList();
            if (obj == null)
            {
                professionBindingSource.DataSource = new Profession();
                db.Profession.Add(professionBindingSource.Current as Profession);

            }
            else
            {
                professionBindingSource.DataSource = obj;
                db.Profession.Attach(professionBindingSource.Current as Profession);
            }
        }

        private void ProfessionIEF_FormClosing(object sender, FormClosingEventArgs e)
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
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
