using diagram.Forms.Table;
using System;
using System.Windows.Forms;

namespace diagram
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var db = new my_db_for_db_2Entities();

            //Application.Run(new AddressForm(db));
            //Application.Run(new BasketForm(db));
            //Application.Run(new BrandForm(db));
            //Application.Run(new BrandSCForm(db));
            //Application.Run(new BreakageForm(db));
            //Application.Run(new CategoriesForm(db));
            //Application.Run(new CategoriesSCForm(db));
            //Application.Run(new CityForm(db));
            //Application.Run(new CountriesForm(db));
            //Application.Run(new CustomersForm(db));
            //Application.Run(new DeliveryForm(db));
            //Application.Run(new EmployeeForm(db));
            //Application.Run(new GoodsForm(db));
            //Application.Run(new GoodsShopsForm(db));
            //Application.Run(new MakersForm(db));
            //Application.Run(new ProfessionForm(db));
            //Application.Run(new ProvideForm(db));
            Application.Run(new ProvideOrderForm(db));
        }
    }
}
