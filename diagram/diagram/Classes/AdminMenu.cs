using diagram.Forms.Table;
using System;

using System.Windows.Forms;

namespace diagram.Classes
{
    static class AdminMenu
    {
        public static MenuStrip getMenu(my_db_for_db_2Entities db, Employee employee)
        {
            MenuStrip menu = new MenuStrip();

            ToolStripMenuItem windowMenu = new ToolStripMenuItem("Обрати таблицю");

            //ПО ІТЕМУ НА КОЖНУ ТАБЛИЦЮ
            ToolStripMenuItem Address = new ToolStripMenuItem("AddressForm");
            ToolStripMenuItem Basket = new ToolStripMenuItem("BasketForm");
            ToolStripMenuItem Brand = new ToolStripMenuItem("BrandForm");
            ToolStripMenuItem BrandSC = new ToolStripMenuItem("BrandSCForm");
            ToolStripMenuItem Breakage = new ToolStripMenuItem("BreakageForm");
            ToolStripMenuItem Categories = new ToolStripMenuItem("CategoriesForm");
            ToolStripMenuItem CategoriesSC = new ToolStripMenuItem("CategoriesSCForm");
            ToolStripMenuItem City= new ToolStripMenuItem("CityForm");
            ToolStripMenuItem Countries= new ToolStripMenuItem("CountriesForm");
            ToolStripMenuItem Customers = new ToolStripMenuItem("CustomersForm");
            ToolStripMenuItem Delivery = new ToolStripMenuItem("DeliveryForm");
            ToolStripMenuItem Employee = new ToolStripMenuItem("EmployeeForm");
            ToolStripMenuItem Goods= new ToolStripMenuItem("GoodsForm");
            ToolStripMenuItem GoodsShops = new ToolStripMenuItem("GoodsShopsForm");
            ToolStripMenuItem Makers = new ToolStripMenuItem("MakersForm");
            ToolStripMenuItem Profession= new ToolStripMenuItem("ProfessionForm");
            ToolStripMenuItem Provide= new ToolStripMenuItem("ProvideForm");
            ToolStripMenuItem ProvideOrder = new ToolStripMenuItem("ProvideOrderForm");
            ToolStripMenuItem Repair= new ToolStripMenuItem("RepairForm");
            ToolStripMenuItem Sales = new ToolStripMenuItem("SalesForm");
            ToolStripMenuItem ServiceCenter = new ToolStripMenuItem("ServiceCenterForm");
            ToolStripMenuItem Service = new ToolStripMenuItem("ServiceForm");
            ToolStripMenuItem ServiceTransportation = new ToolStripMenuItem("ServiceTransportationForm");
            ToolStripMenuItem Shipment = new ToolStripMenuItem("Shipment ");
            ToolStripMenuItem Shops= new ToolStripMenuItem("ShopsForm");
            ToolStripMenuItem Status = new ToolStripMenuItem("StatusForm");
            ToolStripMenuItem Transportation = new ToolStripMenuItem("TransportationForm");
            //cghfw.dfyyz ryjgrb
            Address.Click += new EventHandler((s,e) => Click(s,new MyArgs(new AddressForm(db,employee))));
            Basket.Click += new EventHandler((s, e) => Click(s, new MyArgs(new BasketForm(db, employee))));
            Brand.Click += new EventHandler((s, e) => Click(s, new MyArgs(new BrandForm(db, employee))));
            BrandSC.Click += new EventHandler((s, e) => Click(s, new MyArgs(new BrandSCForm(db, employee))));
            Breakage.Click += new EventHandler((s, e) => Click(s, new MyArgs(new BreakageForm(db, employee))));
            Categories.Click += new EventHandler((s, e) => Click(s, new MyArgs(new CategoriesForm(db, employee))));
            CategoriesSC.Click += new EventHandler((s, e) => Click(s, new MyArgs(new CategoriesSCForm(db, employee))));
            City.Click += new EventHandler((s, e) => Click(s, new MyArgs(new CityForm(db, employee))));
            Countries.Click += new EventHandler((s, e) => Click(s, new MyArgs(new CountriesForm(db, employee))));
            Customers.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));
            Delivery.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));
            Employee.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));
            Goods.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));
            GoodsShops.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));
            Makers.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));
            Profession.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));
            Provide.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));
            ProvideOrder.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));
            Repair.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));
            Sales.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));
            ServiceCenter.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));
            Service.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));
            ServiceTransportation.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));
            Shipment.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));
            Shops.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));
            Status.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));
            Transportation.Click += new EventHandler((s, e) => Click(s, new MyArgs(new AddressForm(db, employee))));


            menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                windowMenu
            });
            windowMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                //Додати усі меню ітеми
                Address,
                Basket,
                Brand,
                BrandSC,
                Breakage,
                Categories,
                CategoriesSC,
                City,
                Countries,
                Customers,
                Delivery,
                Employee,
                Goods,
                GoodsShops,
                Makers,
                Profession,
                Provide,
                ProvideOrder,
                Repair,
                Sales,
                ServiceCenter,
                Service,
                ServiceTransportation,
                Shipment,
                Shops,
                Status,
                Transportation
            });
            return menu;
        }
        private static void Click( object sender, MyArgs e)
        {
            e.Form.Show();
        }
    }
    public class MyArgs : EventArgs
    {
        public Form Form;
        public MyArgs(Form _form)
        {
            Form = _form;
        }
    }
}
