using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class GoodsShopsIEF : Form
    {
        my_db_for_db_2Entities db;
        public GoodsShopsIEF(GoodsShops obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            goodsBindingSource.DataSource = db.Goods.ToList();
            shopsBindingSource.DataSource = db.Shops.ToList();
            goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
            if (obj == null)
            {
                goodsShopsBindingSource.DataSource = new GoodsShops();
                db.GoodsShops.Add(goodsShopsBindingSource.Current as GoodsShops);

            }
            else
            {
                goodsShopsBindingSource.DataSource = obj;
                db.GoodsShops.Attach(goodsShopsBindingSource.Current as GoodsShops);
            }
        }

        private void GoodsShopsIEF_FormClosing(object sender, FormClosingEventArgs e)
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
