using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.InsernEdit
{
    public partial class GoodsIEF : Form
    {
        my_db_for_db_2Entities db;
        public GoodsIEF(Goods obj, my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            makersBindingSource.DataSource = db.Makers.ToList();
            categoriesBindingSource.DataSource = db.Categories.ToList();
            goodsBindingSource.DataSource = db.Goods.ToList();
            if (obj == null)
            {
                goodsBindingSource.DataSource = new Goods();
                db.Goods.Add(goodsBindingSource.Current as Goods);

            }
            else
            {
                goodsBindingSource.DataSource = obj;
                db.Goods.Attach(goodsBindingSource.Current as Goods);
            }
        }

        private void GoodsIEF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(modelTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    modelTB.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(codeTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    codeTB.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(descriptionTB.Text))
                {
                    MessageBox.Show("Please ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    descriptionTB.Focus();
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
