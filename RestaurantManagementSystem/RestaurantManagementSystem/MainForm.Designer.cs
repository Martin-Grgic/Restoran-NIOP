namespace RestaurantManagementSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button tablesButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button ordersButton;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Text = "Restaurant Management System";
            this.Size = new System.Drawing.Size(1024, 768);

            try
            {
                this.BackgroundImage = System.Drawing.Image.FromFile("restoran.jpg");
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error loading background image: " + ex.Message);
            }

            // Initialize welcomeLabel
            this.welcomeLabel = new System.Windows.Forms.Label
            {
                Text = "Welcome to the Restaurant Management System",
                Font = new System.Drawing.Font("Arial", 24, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White,
                BackColor = System.Drawing.Color.Transparent,
                AutoSize = true,
                Location = new System.Drawing.Point(200, 50)
            };
            this.Controls.Add(this.welcomeLabel);

            // Initialize tablesButton
            this.tablesButton = new System.Windows.Forms.Button
            {
                Text = "Tables",
                Font = new System.Drawing.Font("Arial", 16),
                Size = new System.Drawing.Size(200, 60),
                Location = new System.Drawing.Point(412, 200),
                BackColor = System.Drawing.Color.Teal,
                ForeColor = System.Drawing.Color.White,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat
            };
            this.tablesButton.Click += new System.EventHandler(this.TablesButton_Click);
            this.Controls.Add(this.tablesButton);

            // Initialize menuButton
            this.menuButton = new System.Windows.Forms.Button
            {
                Text = "Menu",
                Font = new System.Drawing.Font("Arial", 16),
                Size = new System.Drawing.Size(200, 60),
                Location = new System.Drawing.Point(412, 300),
                BackColor = System.Drawing.Color.Teal,
                ForeColor = System.Drawing.Color.White,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat
            };
            this.menuButton.Click += new System.EventHandler(this.MenuButton_Click);
            this.Controls.Add(this.menuButton);

            // Initialize ordersButton
            this.ordersButton = new System.Windows.Forms.Button
            {
                Text = "Orders",
                Font = new System.Drawing.Font("Arial", 16),
                Size = new System.Drawing.Size(200, 60),
                Location = new System.Drawing.Point(412, 400),
                BackColor = System.Drawing.Color.Teal,
                ForeColor = System.Drawing.Color.White,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat
            };
            this.ordersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            this.Controls.Add(this.ordersButton);
        }
    }
}
