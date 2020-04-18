using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class GoodsShopsForm : Form
    {
        my_db_for_db_2Entities db;
        public GoodsShopsForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void GoodsShopsForm_Load(object sender, EventArgs e)
        {
            goodsBindingSource.DataSource = db.Goods.ToList();
            shopsBindingSource.DataSource = db.Shops.ToList();
            goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (GoodsShopsIEF frm = new GoodsShopsIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (goodsShopsBindingSource.Current == null)
            {
                return;
            }
            using (GoodsShopsIEF frm = new GoodsShopsIEF(goodsShopsBindingSource.Current as GoodsShops, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (goodsShopsBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.GoodsShops.Remove(goodsShopsBindingSource.Current as GoodsShops);
                    goodsShopsBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
