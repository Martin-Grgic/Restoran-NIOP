
using System;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class TablesForm : Form
    {
        public TablesForm()
        {
            InitializeComponent();
        }

            private void InitializeComponent()
            {
                this.Text = "Restaurant Manager";
                this.Size = new System.Drawing.Size(1024, 768); // Pove?ana veli?ina prozora

                // Panel za upravljanje stolovima
                Panel tableManagementPanel = new Panel
                {
                    Dock = DockStyle.Fill,
                    BorderStyle = BorderStyle.FixedSingle
                };
                this.Controls.Add(tableManagementPanel);

                // Kreiranje stolova
                int tableCount = 16;
                int rows = 4;
                int columns = 4;
                int tableWidth = 200;
                int tableHeight = 150;
                int padding = 10;

                for (int i = 0; i < tableCount; i++)
                {
                    int row = i / columns;
                    int col = i % columns;

                    Panel tablePanel = CreateTablePanel($"Table {i + 1}");
                    tablePanel.Location = new System.Drawing.Point(
                        col * (tableWidth + padding),
                        row * (tableHeight + padding)
                    );
                    tablePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                    tableManagementPanel.Controls.Add(tablePanel);
                }
            }

            private Panel CreateTablePanel(string tableName)
            {
                Panel panel = new Panel
                {
                    Size = new System.Drawing.Size(200, 150),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = System.Drawing.Color.LightGreen // Boja stola
                };

                Label tableLabel = new Label
                {
                    Text = tableName,
                    Location = new System.Drawing.Point(10, 10),
                    Size = new System.Drawing.Size(180, 20),
                    Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold)
                };
                panel.Controls.Add(tableLabel);

                Button openOrderButton = new Button
                {
                    Text = "Open Order",
                    Location = new System.Drawing.Point(10, 40),
                    Size = new System.Drawing.Size(180, 20)
                };
                panel.Controls.Add(openOrderButton);

                Button closeBillButton = new Button
                {
                    Text = "Close Bill",
                    Location = new System.Drawing.Point(10, 70),
                    Size = new System.Drawing.Size(180, 20)
                };
                panel.Controls.Add(closeBillButton);

                Button assignGuestsButton = new Button
                {
                    Text = "Assign Guests",
                    Location = new System.Drawing.Point(10, 100),
                    Size = new System.Drawing.Size(180, 20)
                };
                panel.Controls.Add(assignGuestsButton);

                return panel;
            }

        
        }
    }
