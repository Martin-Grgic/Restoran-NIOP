
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

            private void InitializeComponent()
            {
                this.Text = "Order Management";
                this.Size = new System.Drawing.Size(820, 620);

                // Panel za upravljanje narudžbama
                Panel orderManagementPanel = new Panel
                {
                    Location = new System.Drawing.Point(20, 20),
                    Size = new System.Drawing.Size(760, 560),
                    BorderStyle = BorderStyle.FixedSingle
                };
                this.Controls.Add(orderManagementPanel);

                // Kreiranje narudžbi
                int orderCount = 3; // Prikazano su tri narudžbe na slici
                int orderHeight = 150;
                int padding = 10;

                for (int i = 0; i < orderCount; i++)
                {
                    Panel orderPanel = CreateOrderPanel(i + 1);
                    orderPanel.Location = new System.Drawing.Point(20, i * (orderHeight + padding));
                    orderPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                    orderManagementPanel.Controls.Add(orderPanel);
                }
            }

            private Panel CreateOrderPanel(int orderId)
            {
                Panel panel = new Panel
                {
                    Size = new System.Drawing.Size(720, 150),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label orderIdLabel = new Label
                {
                    Text = $"Order ID: {12344 + orderId}",
                    Location = new System.Drawing.Point(10, 10),
                    Size = new System.Drawing.Size(200, 20),
                    Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold)
                };
                panel.Controls.Add(orderIdLabel);

                Label tableLabel = new Label
                {
                    Text = $"Table: {15 - orderId * 4}",
                    Location = new System.Drawing.Point(10, 40),
                    Size = new System.Drawing.Size(200, 20),
                    Font = new System.Drawing.Font("Arial", 12)
                };
                panel.Controls.Add(tableLabel);

                Label orderTimeLabel = new Label
                {
                    Text = $"Order Time: {DateTime.Now.AddHours(-orderId * 0.5):MM/dd/yyyy h:mm tt}",
                    Location = new System.Drawing.Point(10, 70),
                    Size = new System.Drawing.Size(300, 20),
                    Font = new System.Drawing.Font("Arial", 12)
                };
                panel.Controls.Add(orderTimeLabel);

                Label totalPriceLabel = new Label
                {
                    Text = $"Total Price: ${(100 - orderId * 20):0.00}",
                    Location = new System.Drawing.Point(10, 100),
                    Size = new System.Drawing.Size(200, 20),
                    Font = new System.Drawing.Font("Arial", 12)
                };
                panel.Controls.Add(totalPriceLabel);

                Label statusLabel = new Label
                {
                    Text = "Status: In Progress",
                    Location = new System.Drawing.Point(500, 10),
                    Size = new System.Drawing.Size(200, 20),
                    Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold)
                };
                panel.Controls.Add(statusLabel);

                Button viewButton = new Button
                {
                    Text = "View",
                    Location = new System.Drawing.Point(500, 70),
                    Size = new System.Drawing.Size(200, 30)
                };
                panel.Controls.Add(viewButton);

                return panel;
            }


        }
    }
