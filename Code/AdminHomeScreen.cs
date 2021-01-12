using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS
{
    public partial class AdminHomeScreen : Sample
    {
        public AdminHomeScreen()
        {
            InitializeComponent();
        }

        private void AddChef_btn_click_Click(object sender, EventArgs e)
        {
            Addchef rw = new Addchef();
            Mainclass.ShowWindow(rw, this, MDI.ActiveForm);
        }

        private void Customer_btn_click_Click(object sender, EventArgs e)
        {
            Customers rw = new Customers();
            Mainclass.ShowWindow(rw, this, MDI.ActiveForm);
        }

        private void Menu_btn_click_Click(object sender, EventArgs e)
        {
            Menuwindow rw = new Menuwindow();
            Mainclass.ShowWindow(rw, this, MDI.ActiveForm);

        }

        private void Orders_btn_click_Click(object sender, EventArgs e)
        {
            OrdersWindow rw = new OrdersWindow();
            Mainclass.ShowWindow(rw, this, MDI.ActiveForm);

        }

        private void Tables_btn_click_Click(object sender, EventArgs e)
        {
            TablesWindow rw = new TablesWindow();
            Mainclass.ShowWindow(rw, this, MDI.ActiveForm);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChefsOrdersWindow2 cw = new ChefsOrdersWindow2();
            Mainclass.ShowWindow(cw, this, MDI.ActiveForm);
        }
    }
}
