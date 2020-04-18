using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class TransportationIEF : Form
    {
        my_db_for_db_2Entities db;
        public TransportationIEF(Transportation obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
            goodsShopsBindingSource1.DataSource = db.GoodsShops.ToList();
            employeeBindingSource.DataSource = db.Employee.ToList();
            transportationBindingSource.DataSource = db.Transportation.ToList();
            if (obj == null)
            {
                transportationBindingSource.DataSource = new Transportation();
                db.Transportation.Add(transportationBindingSource.Current as Transportation);

            }
            else
            {
                transportationBindingSource.DataSource = obj;
                db.Transportation.Attach(transportationBindingSource.Current as Transportation);
            }
        }

        private void TransportationIEF_FormClosing(object sender, FormClosingEventArgs e)
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
