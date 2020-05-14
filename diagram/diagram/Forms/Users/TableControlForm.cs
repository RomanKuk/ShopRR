using diagram.Forms.Table;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace diagram.Forms.Users
{
    public partial class TableControlForm : Form
    {
        my_db_for_db_2Entities db;
        Dictionary<String, Form> tables = new Dictionary<string, Form>();
        public TableControlForm(my_db_for_db_2Entities _db)
        {
            InitializeComponent();
            db = _db;
            //TODO дозаповнити
            tables = new Dictionary<string, Form>()
            {
                {"Адреси",new AddressForm(db) },
                {"Кошики покупок",new BasketForm(db) },
                {"Бренди",new BrandForm(db) },
                {"Бренди / Сервісні центри",new BrandSCForm(db) },
                {"Поломки",new BreakageForm(db) },
                {"Категорії",new CategoriesForm(db) },
                {"Категорії / Сервісні центри",new CategoriesSCForm(db) },
                {"Міста",new CityForm(db) },
                {"Країни",new CountriesForm(db) },
                {"Покупці",new CustomersForm(db) },
                {"Поставки",new DeliveryForm(db) },
                {"Працівники",new EmployeeForm(db) },
                {"Товари",new GoodsForm(db) },
                {"Товари / Магазини",new GoodsShopsForm(db) },
                {"Виробники",new MakersForm(db) },
                {"Професії",new ProfessionForm(db) },
                {"Постачальники",new ProvideForm(db) },
                {"Загальне замовлення (партії)",new ProvideOrderForm(db) },
                {"Ремонт",new RepairForm(db) },
                {"Продажі",new SalesForm(db) },
                {"Сервісні центри",new ServiceCenterForm(db) },
                {"Сервісні обслуговування",new ServiceForm(db) },
                {"Сервісні перевезення",new ServiceTransportationForm(db) },
                {"Відвантаження",new ShipmentForm(db) },
                {"Магазини",new ShopsForm(db) },
                {"Статуси ремонту",new StatusForm(db) },
                {"Перевезення",new TransportationForm(db) }
            };
            TableComboBox.Items.Clear();
            foreach (String s in tables.Keys)
            {
                TableComboBox.Items.Add(s);
            }
            TableComboBox.SelectedIndex = 0;

        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            Form form = tables[TableComboBox.Text];
            form.Show();
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
