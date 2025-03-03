
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

            private void InitializeComponent()
            {
                this.Text = "Gourmet Menu";
                this.Size = new System.Drawing.Size(800, 600);

                // Panel za upravljanje jelima
                Panel manageDishesPanel = new Panel
                {
                    Location = new System.Drawing.Point(20, 20),
                    Size = new System.Drawing.Size(760, 500),
                    BorderStyle = BorderStyle.FixedSingle
                };
                this.Controls.Add(manageDishesPanel);

                // Gumb za dodavanje novog jela
                Button addNewDishButton = new Button
                {
                    Text = "Add New Dish",
                    Location = new System.Drawing.Point(650, 10),
                    Size = new System.Drawing.Size(100, 30)
                };
                manageDishesPanel.Controls.Add(addNewDishButton);

                // Herb-Crusted Salmon
                Panel salmonPanel = CreateDishPanel("Herb-Crusted Salmon", "Delicious salmon fillet with a crispy herb crust served with seasonal vegetables.", "$24.99", "salmon.jpeg");
                salmonPanel.Location = new System.Drawing.Point(20, 50);
                manageDishesPanel.Controls.Add(salmonPanel);

                // Truffle Pasta
                Panel pastaPanel = CreateDishPanel("Truffle Pasta", "Creamy truffle pasta with parmesan cheese and a hint of garlic, topped with fresh basil.", "$19.99", "trufflePasta.jpg");
                pastaPanel.Location = new System.Drawing.Point(260, 50);
                manageDishesPanel.Controls.Add(pastaPanel);

                // Chocolate Fondant
                Panel fondantPanel = CreateDishPanel("Chocolate Fondant", "Rich chocolate fondant with a gooey center, served with vanilla ice cream.", "$8.99", "cake.jpg");
                fondantPanel.Location = new System.Drawing.Point(500, 50);
                manageDishesPanel.Controls.Add(fondantPanel);
            }

            private Panel CreateDishPanel(string title, string description, string price, string imagePath)
            {
                Panel panel = new Panel
                {
                    Size = new System.Drawing.Size(220, 400),
                    BorderStyle = BorderStyle.FixedSingle
                };

                PictureBox pictureBox = new PictureBox
                {
                    ImageLocation = imagePath,
                    Size = new System.Drawing.Size(200, 150),
                    Location = new System.Drawing.Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                panel.Controls.Add(pictureBox);

                Label titleLabel = new Label
                {
                    Text = title,
                    Location = new System.Drawing.Point(10, 170),
                    Size = new System.Drawing.Size(200, 20),
                    Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold)
                };
                panel.Controls.Add(titleLabel);

                Label descriptionLabel = new Label
                {
                    Text = description,
                    Location = new System.Drawing.Point(10, 200),
                    Size = new System.Drawing.Size(200, 60),
                    Font = new System.Drawing.Font("Arial", 10)
                };
                panel.Controls.Add(descriptionLabel);

                Label priceLabel = new Label
                {
                    Text = price,
                    Location = new System.Drawing.Point(10, 270),
                    Size = new System.Drawing.Size(200, 20),
                    Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold)
                };
                panel.Controls.Add(priceLabel);

                Button editButton = new Button
                {
                    Text = "Edit",
                    Location = new System.Drawing.Point(10, 300),
                    Size = new System.Drawing.Size(80, 30)
                };
                panel.Controls.Add(editButton);

                Button removeButton = new Button
                {
                    Text = "Remove",
                    Location = new System.Drawing.Point(130, 300),
                    Size = new System.Drawing.Size(80, 30)
                };
                panel.Controls.Add(removeButton);

                return panel;
            }

        }
    }

