using diagram.Classes;
using diagram.Forms.InsernEdit;
using System;
using System.Linq;
using System.Windows.Forms;

namespace diagram.Forms.Table
{
    public partial class BreakageForm : Form
    {
        my_db_for_db_2Entities db;
        Employee employee;
        public BreakageForm(my_db_for_db_2Entities _db, Employee _employee)
        {
            employee = _employee;
            if (employee.Employee_ID.Equals(4))//якщо адмін
            {
                MenuStrip menuStrip = AdminMenu.getMenu(db, employee);
                this.MainMenuStrip = menuStrip;
                this.Controls.Add(menuStrip);
            }
            InitializeComponent();
            db = _db;
        }

        private void BreakageForm_Load(object sender, EventArgs e)
        {
            breakageBindingSource.DataSource = db.Breakage.ToList();

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int barWidth = Width - panel4.Width;
            panel3.Width = panel5.Width = barWidth / 2;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (BreakageIEF frm = new BreakageIEF(null, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    breakageBindingSource.DataSource = db.Breakage.ToList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (breakageBindingSource.Current == null)
            {
                return;
            }
            using (BreakageIEF frm = new BreakageIEF(breakageBindingSource.Current as Breakage, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    breakageBindingSource.DataSource = db.Breakage.ToList();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (breakageBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Breakage.Remove(breakageBindingSource.Current as Breakage);
                    breakageBindingSource.RemoveCurrent();
                    db.SaveChanges();
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
