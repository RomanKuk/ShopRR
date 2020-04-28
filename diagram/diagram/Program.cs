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
            Application.Run(new EmployeeForm(db));

            ///Application.Run(new BrandForm(db));
        }
    }
}
