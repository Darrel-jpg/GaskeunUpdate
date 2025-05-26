namespace Gaskeun_.View
{
    partial class AdminMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            VehicleTimer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            vehicleContainer = new Panel();
            panel10 = new Panel();
            btnMobil = new Button();
            panel9 = new Panel();
            btnMotor = new Button();
            panel4 = new Panel();
            btnVehicle = new Button();
            panel8 = new Panel();
            btnLogout = new Button();
            panel3 = new Panel();
            btnDashboard = new Button();
            panel5 = new Panel();
            btnUsers = new Button();
            panel6 = new Panel();
            btnTransaction = new Button();
            panel7 = new Panel();
            dashboard1 = new Dashboard();
            transaksiPelanggan2 = new TransaksiPelanggan();
            usersData3 = new UsersData();
            mobilData3 = new MobilData();
            vehicleData3 = new VehicleData();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            vehicleContainer.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1880, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 28);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 17, 121);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 60);
            panel1.TabIndex = 13;
            // 
            // VehicleTimer
            // 
            VehicleTimer.Interval = 10;
            VehicleTimer.Tick += VehicleTimer_Tick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(22, 17, 121);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(vehicleContainer, 0, 2);
            tableLayoutPanel1.Controls.Add(panel8, 0, 5);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel5, 0, 3);
            tableLayoutPanel1.Controls.Add(panel6, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(283, 995);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 3);
            pictureBox1.Margin = new Padding(37, 3, 3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 170);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // vehicleContainer
            // 
            vehicleContainer.BackColor = Color.Transparent;
            vehicleContainer.Controls.Add(panel10);
            vehicleContainer.Controls.Add(panel9);
            vehicleContainer.Controls.Add(panel4);
            vehicleContainer.Location = new Point(3, 273);
            vehicleContainer.MaximumSize = new Size(283, 264);
            vehicleContainer.MinimumSize = new Size(283, 88);
            vehicleContainer.Name = "vehicleContainer";
            vehicleContainer.Size = new Size(283, 88);
            vehicleContainer.TabIndex = 13;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.Controls.Add(btnMobil);
            panel10.Location = new Point(0, 174);
            panel10.Name = "panel10";
            panel10.Size = new Size(283, 88);
            panel10.TabIndex = 19;
            // 
            // btnMobil
            // 
            btnMobil.BackColor = Color.FromArgb(59, 61, 155);
            btnMobil.Cursor = Cursors.Hand;
            btnMobil.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 31, 179);
            btnMobil.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 31, 179);
            btnMobil.FlatStyle = FlatStyle.Flat;
            btnMobil.Font = new Font("Arial Rounded MT Bold", 14F);
            btnMobil.Image = (Image)resources.GetObject("btnMobil.Image");
            btnMobil.ImageAlign = ContentAlignment.MiddleLeft;
            btnMobil.Location = new Point(-10, -8);
            btnMobil.Name = "btnMobil";
            btnMobil.Padding = new Padding(30, 0, 0, 0);
            btnMobil.Size = new Size(306, 100);
            btnMobil.TabIndex = 18;
            btnMobil.Text = "        Cars";
            btnMobil.TextAlign = ContentAlignment.MiddleLeft;
            btnMobil.UseVisualStyleBackColor = false;
            btnMobil.Click += btnMobil_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Transparent;
            panel9.Controls.Add(btnMotor);
            panel9.Location = new Point(0, 90);
            panel9.Name = "panel9";
            panel9.Size = new Size(283, 88);
            panel9.TabIndex = 19;
            // 
            // btnMotor
            // 
            btnMotor.BackColor = Color.FromArgb(59, 61, 155);
            btnMotor.Cursor = Cursors.Hand;
            btnMotor.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 31, 179);
            btnMotor.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 31, 179);
            btnMotor.FlatStyle = FlatStyle.Flat;
            btnMotor.Font = new Font("Arial Rounded MT Bold", 14F);
            btnMotor.Image = (Image)resources.GetObject("btnMotor.Image");
            btnMotor.ImageAlign = ContentAlignment.MiddleLeft;
            btnMotor.Location = new Point(-10, -8);
            btnMotor.Name = "btnMotor";
            btnMotor.Padding = new Padding(30, 0, 0, 0);
            btnMotor.Size = new Size(306, 100);
            btnMotor.TabIndex = 18;
            btnMotor.Text = "        Motorcycles";
            btnMotor.TextAlign = ContentAlignment.MiddleLeft;
            btnMotor.UseVisualStyleBackColor = false;
            btnMotor.Click += btnMotor_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(btnVehicle);
            panel4.Location = new Point(0, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(283, 88);
            panel4.TabIndex = 15;
            // 
            // btnVehicle
            // 
            btnVehicle.BackColor = Color.Transparent;
            btnVehicle.Cursor = Cursors.Hand;
            btnVehicle.FlatAppearance.CheckedBackColor = Color.FromArgb(35, 36, 40);
            btnVehicle.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 31, 179);
            btnVehicle.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 31, 179);
            btnVehicle.FlatStyle = FlatStyle.Flat;
            btnVehicle.Font = new Font("Arial Rounded MT Bold", 14F);
            btnVehicle.Image = (Image)resources.GetObject("btnVehicle.Image");
            btnVehicle.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehicle.Location = new Point(-14, -6);
            btnVehicle.Name = "btnVehicle";
            btnVehicle.Padding = new Padding(30, 0, 0, 0);
            btnVehicle.Size = new Size(306, 100);
            btnVehicle.TabIndex = 17;
            btnVehicle.Text = "         Vehicle Data";
            btnVehicle.TextAlign = ContentAlignment.MiddleLeft;
            btnVehicle.UseVisualStyleBackColor = false;
            btnVehicle.Click += btnVehicle_Click;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(btnLogout);
            panel8.Location = new Point(3, 921);
            panel8.Name = "panel8";
            panel8.Size = new Size(277, 71);
            panel8.TabIndex = 16;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 31, 179);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 31, 179);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(12, 14);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(173, 50);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "         Sign Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(btnDashboard);
            panel3.Location = new Point(3, 179);
            panel3.Name = "panel3";
            panel3.Size = new Size(277, 88);
            panel3.TabIndex = 14;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 31, 179);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 31, 179);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial Rounded MT Bold", 14F);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(-10, -8);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(30, 0, 0, 0);
            btnDashboard.Size = new Size(306, 100);
            btnDashboard.TabIndex = 16;
            btnDashboard.Text = "        Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(btnUsers);
            panel5.Location = new Point(3, 367);
            panel5.Name = "panel5";
            panel5.Size = new Size(277, 88);
            panel5.TabIndex = 18;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Transparent;
            btnUsers.Cursor = Cursors.Hand;
            btnUsers.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 31, 179);
            btnUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 31, 179);
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Arial Rounded MT Bold", 14F);
            btnUsers.Image = (Image)resources.GetObject("btnUsers.Image");
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(-10, -8);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(30, 0, 0, 0);
            btnUsers.Size = new Size(306, 100);
            btnUsers.TabIndex = 18;
            btnUsers.Text = "        Customer Data";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(btnTransaction);
            panel6.Location = new Point(3, 461);
            panel6.Name = "panel6";
            panel6.Size = new Size(277, 88);
            panel6.TabIndex = 16;
            // 
            // btnTransaction
            // 
            btnTransaction.BackColor = Color.Transparent;
            btnTransaction.Cursor = Cursors.Hand;
            btnTransaction.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 31, 179);
            btnTransaction.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 31, 179);
            btnTransaction.FlatStyle = FlatStyle.Flat;
            btnTransaction.Font = new Font("Arial Rounded MT Bold", 14F);
            btnTransaction.Image = (Image)resources.GetObject("btnTransaction.Image");
            btnTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransaction.Location = new Point(-10, -4);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Padding = new Padding(30, 0, 0, 0);
            btnTransaction.Size = new Size(308, 100);
            btnTransaction.TabIndex = 19;
            btnTransaction.Text = "        Transaction";
            btnTransaction.TextAlign = ContentAlignment.MiddleLeft;
            btnTransaction.UseVisualStyleBackColor = false;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlLight;
            panel7.Controls.Add(dashboard1);
            panel7.Controls.Add(transaksiPelanggan2);
            panel7.Controls.Add(usersData3);
            panel7.Controls.Add(mobilData3);
            panel7.Controls.Add(vehicleData3);
            panel7.Controls.Add(tableLayoutPanel1);
            panel7.Location = new Point(0, 60);
            panel7.Name = "panel7";
            panel7.Size = new Size(1920, 995);
            panel7.TabIndex = 17;
            // 
            // dashboard1
            // 
            dashboard1.BackColor = SystemColors.ControlLight;
            dashboard1.Dock = DockStyle.Fill;
            dashboard1.ForeColor = Color.Black;
            dashboard1.Location = new Point(283, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1637, 995);
            dashboard1.TabIndex = 24;
            // 
            // transaksiPelanggan2
            // 
            transaksiPelanggan2.BackColor = SystemColors.ControlLight;
            transaksiPelanggan2.Dock = DockStyle.Fill;
            transaksiPelanggan2.ForeColor = Color.Black;
            transaksiPelanggan2.Location = new Point(283, 0);
            transaksiPelanggan2.Name = "transaksiPelanggan2";
            transaksiPelanggan2.Size = new Size(1637, 995);
            transaksiPelanggan2.TabIndex = 23;
            // 
            // usersData3
            // 
            usersData3.BackColor = SystemColors.ControlLight;
            usersData3.Dock = DockStyle.Fill;
            usersData3.ForeColor = Color.Black;
            usersData3.Location = new Point(283, 0);
            usersData3.Name = "usersData3";
            usersData3.Size = new Size(1637, 995);
            usersData3.TabIndex = 22;
            // 
            // mobilData3
            // 
            mobilData3.BackColor = SystemColors.ControlLight;
            mobilData3.Dock = DockStyle.Fill;
            mobilData3.ForeColor = Color.Black;
            mobilData3.Location = new Point(283, 0);
            mobilData3.Name = "mobilData3";
            mobilData3.Size = new Size(1637, 995);
            mobilData3.TabIndex = 21;
            // 
            // vehicleData3
            // 
            vehicleData3.BackColor = SystemColors.ControlLight;
            vehicleData3.Dock = DockStyle.Fill;
            vehicleData3.ForeColor = Color.Black;
            vehicleData3.Location = new Point(283, 0);
            vehicleData3.Name = "vehicleData3";
            vehicleData3.Size = new Size(1637, 995);
            vehicleData3.TabIndex = 20;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1920, 1055);
            Controls.Add(panel7);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMainForm";
            WindowState = FormWindowState.Maximized;
            Load += AdminMainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            vehicleContainer.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel1;
        private System.Windows.Forms.Timer VehicleTimer;
        private VehicleData vehicleData1;
        private UsersData usersData1;
        private MobilData mobilData1;
        private TransaksiPelanggan transaksiPelanggan1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Panel vehicleContainer;
        private Panel panel10;
        private Button btnMobil;
        private Panel panel9;
        private Button btnMotor;
        private Panel panel4;
        private Button btnVehicle;
        private Panel panel8;
        private Button btnLogout;
        private Panel panel3;
        private Button btnDashboard;
        private Panel panel5;
        private Button btnUsers;
        private Panel panel6;
        private Button btnTransaction;
        private VehicleData vehicleData2;
        private MobilData mobilData2;
        private UsersData usersData2;
        private Panel panel7;
        private Dashboard dashboard1;
        private TransaksiPelanggan transaksiPelanggan2;
        private UsersData usersData3;
        private MobilData mobilData3;
        private VehicleData vehicleData3;
    }
}