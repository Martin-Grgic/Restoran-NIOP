
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

            private void InitializeComponent()
            {
                this.Text = "Restaurant Management System";
                this.Size = new System.Drawing.Size(1024, 768);
                this.BackgroundImage = System.Drawing.Image.FromFile("restoran.jpg"); // Promijeni na stvarnu putanju tvoje slike
                this.BackgroundImageLayout = ImageLayout.Zoom;

                Label welcomeLabel = new Label
                {
                    Text = "Welcome to the Restaurant Management System",
                    Font = new System.Drawing.Font("Arial", 24, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.White,
                    BackColor = System.Drawing.Color.Transparent,
                    AutoSize = true,
                    Location = new System.Drawing.Point(200, 50)
                };
                this.Controls.Add(welcomeLabel);

                // Kreiranje gumba
                Button tablesButton = new Button
                {
                    Text = "Tables",
                    Font = new System.Drawing.Font("Arial", 16),
                    Size = new System.Drawing.Size(200, 60),
                    Location = new System.Drawing.Point(412, 200),
                    BackColor = System.Drawing.Color.Teal,
                    ForeColor = System.Drawing.Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                tablesButton.Click += (sender, e) => { new TablesForm().Show(); };
                this.Controls.Add(tablesButton);

                Button menuButton = new Button
                {
                    Text = "Menu",
                    Font = new System.Drawing.Font("Arial", 16),
                    Size = new System.Drawing.Size(200, 60),
                    Location = new System.Drawing.Point(412, 300),
                    BackColor = System.Drawing.Color.Teal,
                    ForeColor = System.Drawing.Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                menuButton.Click += (sender, e) => { new MenuForm().Show(); };
                this.Controls.Add(menuButton);

                Button ordersButton = new Button
                {
                    Text = "Orders",
                    Font = new System.Drawing.Font("Arial", 16),
                    Size = new System.Drawing.Size(200, 60),
                    Location = new System.Drawing.Point(412, 400),
                    BackColor = System.Drawing.Color.Teal,
                    ForeColor = System.Drawing.Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                ordersButton.Click += (sender, e) => { new OrdersForm().Show(); };
                this.Controls.Add(ordersButton);
            }

       
        }
    }
