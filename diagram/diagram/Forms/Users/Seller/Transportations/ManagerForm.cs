using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Users.Seller.Transportations
{
    public partial class ManagerForm : Form
    {
        my_db_for_db_2Entities db;
        Employee employee;
        public ManagerForm(my_db_for_db_2Entities _db, Employee _employee)
        {
            db = _db;
            employee = _employee;
            InitializeComponent();
        }
        private void ManagerForm_Load(object sender, EventArgs e)
        {
            transportationBindingSource.DataSource = db.Transportation.ToList();
            goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
            employeeBindingSource1.DataSource = db.Employee.ToList();


            employeeBindingSource.DataSource = db.Employee
                .Where(x => x.Profession_ID.Equals(1))//лише продавці
                .ToList();

            SalesShopChartUpdate();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }
        private void SellerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //статистика по продавцям за останій тиждень
            SellerChart.Series["Продажі"].Points.Clear();
            List<Sales> sales = (db.Sales as IEnumerable<Sales>)
                .Where(x => x.Employee_ID.Equals(SellerComboBox.SelectedValue))
                .ToList();
            DateTime date = DateTime.Now;
            for (int i = 6; i >= 0; i--)
            {
                date = DateTime.Now.AddDays(-i);
                int count = sales
                    .Where(x => x.Date.ToString("dd.MM").Equals(date.ToString("dd.MM")))
                    .Count();
                SellerChart.Series["Продажі"].Points.AddXY(date.ToString("dd.MM"), count);
            }

        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SalesShopChartUpdate();
        }

        private void StopDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SalesShopChartUpdate();
        }

        private void SalesShopChartUpdate()
        {
            //статистика по за останій місяць
            SalesShopChart.Series["Продаж"].Points.Clear();
            SalesShopChart.Series["Продаж"].IsValueShownAsLabel = true;
            List<int> employeersID;
            int count;
            foreach (Shops shops in db.Shops.ToList())
            {
                employeersID = (db.Employee as IEnumerable<Employee>)
                    .Where(x => x.Shop_ID.Equals(shops.Shop_ID))
                    .Select(x => x.Employee_ID)
                    .ToList();

                count = (db.Sales as IEnumerable<Sales>)
                .Where(x => employeersID.Contains(x.Employee_ID) &&
                (x.Date >= StartDateTimePicker.Value) &&
                (x.Date <= StopDateTimePicker.Value) )
                .Count();
                if (count > 0)
                {
                    SalesShopChart.Series["Продаж"].Points.AddXY(shops.Code, count);
                }
            }
        }

        private void NewTransportation_Click(object sender, EventArgs e)
        {
            using (NewTransportationForm form = new NewTransportationForm(db, employee))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    goodsShopsBindingSource.DataSource = db.GoodsShops.ToList();
                    transportationBindingSource.DataSource = db.Transportation.ToList();
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

        }
    }
}
