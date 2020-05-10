using diagram.Forms.expeditor;
using diagram.Forms.seller;
using diagram.Forms.service;
using diagram.Forms.Table;
using diagram.Forms.transportation;
using System;
using System.Linq;
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
            var employee =
                db.Employee
                .Where(e => e.Employee_ID.Equals(4))
                .First();
            Application.Run(new Forms.service.ServiceCenterForm(db, employee));
            //Application.Run(new NewRepairForm(db));
            //Application.Run(new NewServiceTransportationForm(db));
            //Application.Run(new ExpeditorForm(db,employee));
            //Application.Run(new NewServiceForm(db));
            //Application.Run(new NewShipmentForm(db));
            //Application.Run(new NewDeliveryForm(db,employee));
            //Application.Run(new NewTransportationForm(db,employee));
            //Application.Run(new NewSalesForm(db,employee));

            //Application.Run(new EmployeeForm(db));
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
            //Application.Run(new ProvideOrderForm(db));
        }
    }
}
