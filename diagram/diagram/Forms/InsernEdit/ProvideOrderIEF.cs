using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class ProvideOrderIEF : Form
    {
        my_db_for_db_2Entities db;
        public ProvideOrderIEF(ProvideOrder obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            provideBindingSource.DataSource = db.Provide.ToList();
            provideOrderBindingSource.DataSource = db.ProvideOrder.ToList();
            if (obj == null)
            {
                provideOrderBindingSource.DataSource = new ProvideOrder();
                db.ProvideOrder.Add(provideOrderBindingSource.Current as ProvideOrder);

            }
            else
            {
                provideOrderBindingSource.DataSource = obj;
                db.ProvideOrder.Attach(provideOrderBindingSource.Current as ProvideOrder);
            }
        }

        private void ProvideOrderIEF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
