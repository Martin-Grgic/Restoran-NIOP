using System;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TablesButton_Click(object sender, EventArgs e)
        {
            new TablesForm().Show();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            new OrdersForm().Show();
        }
    }
}
