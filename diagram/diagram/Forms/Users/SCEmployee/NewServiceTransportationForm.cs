using diagram.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Users.SCEmployee
{
    public partial class NewServiceTransportationForm : Form
    {
        my_db_for_db_2Entities db;
        public NewServiceTransportationForm(my_db_for_db_2Entities _db)
        {
            db = _db;
            InitializeComponent();
        }

        private void NewServiceTransportationForm_Load(object sender, EventArgs e)
        {
            serviceBindingSource.DataSource = db.Service
                .Where(x => x.Status_ID.Equals(5))//Лише не направлені заявки
                .ToList();
            if (serviceBindingSource.Count.Equals(0))
            {
                MessageBox.Show("немає нових заявок на ремонт", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            SelectSC();
        }

        private void ServiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectSC();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectSC()
        {
            int basketID = (db.Service as IEnumerable<Service>)
                .Where(x => x.Service_ID.Equals(ServiceComboBox.SelectedValue))
                .Select(x => x.Basket_ID)
                .FirstOrDefault();
            int GSID = (db.Basket as IEnumerable<Basket>)
                .Where(x => x.Basket_ID.Equals(basketID))
                .Select(x => x.GoodsShops_ID)
                .FirstOrDefault();
            int GoodsID = (db.GoodsShops as IEnumerable<GoodsShops>)
                .Where(x => x.GoodsShops_ID.Equals(GSID))
                .Select(x => x.Good_ID)
                .FirstOrDefault();
            Goods goods = (db.Goods as IEnumerable<Goods>)
                .Where(x => x.Good_ID.Equals(GoodsID))
                .FirstOrDefault();
            try
            {
                int brandID = (db.Makers as IEnumerable<Makers>)
                .Where(x => x.Maker_ID.Equals(goods.Maker_ID))
                .Select(x => x.Brand_ID)
                .FirstOrDefault();
                List<int> BSCID = (db.BrandSC as IEnumerable<BrandSC>)
                    .Where(x => x.Brand_ID.Equals(brandID))
                    .Select(x => x.SC_ID)
                    .ToList();
                List<int> CSCID = (db.CategoriesSC as IEnumerable<CategoriesSC>)
                    .Where(x => x.Category_ID.Equals(goods.Category_ID))
                    .Select(x => x.SC_ID)
                    .ToList();

                serviceCenterBindingSource.DataSource = db.ServiceCenter
                    .Where(x => BSCID.Contains(x.SC_ID) &&
                    CSCID.Contains(x.SC_ID))
                    .ToList();
            }
            catch(Exception exc){ }
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewServiceTransportationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (ServiceComboBox.SelectedValue != null)
                {
                    if (SCComboBox.SelectedValue != null)
                    {
                        ServiceTransportation serviceTransportation = new ServiceTransportation()
                        {
                            Code = CodeGenerator.GenerateCode("ServiceTransportation", "st"),
                            Service_ID = (int)ServiceComboBox.SelectedValue,
                            SC_ID = (int)SCComboBox.SelectedValue,
                            Date = DateTime.Now
                        };

                        Service service = db.Service
                            .Where(x => x.Service_ID.Equals((int)ServiceComboBox.SelectedValue))
                            .FirstOrDefault();
                        db.Service.Attach(service);
                        service.Status_ID = 4;//у перевезені
                        db.ServiceTransportation.Add(serviceTransportation);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Оберіть сервісний центр", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("оберіть заявку на ремонт", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                    return;
                }
            }
            e.Cancel = false;

        }
    }
}
