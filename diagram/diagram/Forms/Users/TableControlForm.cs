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
                {"Бренди Сервісні Центри",new BrandSCForm(db) },
                {"Поломки",new BreakageForm(db) },
                {"Категорії",new CategoriesForm(db) },
                {"Катеорії Сервісні Центри",new CategoriesSCForm(db) },
                {"Міста",new CityForm(db) },
                {"Кріїни",new CountriesForm(db) },
                {"Покупці",new CustomersForm(db) },
                {"Доставка",new DeliveryForm(db) },
                {"Працівники",new EmployeeForm(db) },
                {"Товари",new GoodsForm(db) },
                {"ТОварив магазинач",new GoodsShopsForm(db) },
                {"Виробники",new MakersForm(db) },
                {"Професії",new ProfessionForm(db) },
                {"Постачалники",new ProvideForm(db) },
                {"Поставки",new ProvideOrderForm(db) },
                {"Ремонт",new RepairForm(db) },
                {"Продажі",new SalesForm(db) },
                {"Сервісні Центри",new ServiceCenterForm(db) },
                {"Сервіси",new ServiceForm(db) },
                {"Сервісні перевезення",new ServiceTransportationForm(db) },
                {"Відвантаження",new ShipmentForm(db) },
                {"Магазини",new ShopsForm(db) },
                {"Статоси ремонту",new StatusForm(db) },
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
    }
}
