using diagram.Forms.Table;
using diagram.Forms.Users.Seller.Transportations;
using System;
using System.Linq;
using System.Windows.Forms;
using diagram.Forms.Users.SCEmployee;
using diagram.Forms.Users.Seller;
using diagram.Forms.Users.Expeditor;

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
            //Application.Run(new ServiceCenterEmployeeForm(db, employee));
            //Application.Run(new NewRepairForm(db));
            //Application.Run(new NewServiceTransportationForm(db));
            //Application.Run(new ExpeditorForm(db,employee));
            //Application.Run(new NewServiceForm(db));
            //Application.Run(new NewShipmentForm(db));
            //Application.Run(new NewDeliveryForm(db,employee));
            //Application.Run(new NewTransportationForm(db,employee));
            //Application.Run(new NewSalesForm(db,employee));
            Application.Run(new SellerForm(db, employee));

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
            //Application.Run(new RepairForm(db));
            //Application.Run(new SalesForm(db));
            //Application.Run(new ServiceCenterForm(db));
            //Application.Run(new ServiceForm(db));
            //Application.Run(new ServiceTransportationForm(db));
            //Application.Run(new ShipmentForm(db));
            //Application.Run(new ShopsForm(db));
            //Application.Run(new StatusForm(db));
            //Application.Run(new TransportationForm(db));

        }
    }
}
