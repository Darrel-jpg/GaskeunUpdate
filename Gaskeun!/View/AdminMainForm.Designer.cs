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
            vehicleContainer = new Panel();
            panel10 = new Panel();
            btnMobil = new Button();
            panel9 = new Panel();
            btnMotor = new Button();
            panel4 = new Panel();
            btnVehicle = new Button();
            btnUsers = new Button();
            btnTransaction = new Button();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            panel3 = new Panel();
            btnDashboard = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            panel8 = new Panel();
            VehicleTimer = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel11 = new Panel();
            panel7 = new Panel();
            dashboard1 = new Dashboard();
            mobilData1 = new MobilData();
            vehicleData1 = new VehicleData();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            vehicleContainer.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
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
            // vehicleContainer
            // 
            vehicleContainer.BackColor = Color.Transparent;
            vehicleContainer.Controls.Add(panel10);
            vehicleContainer.Controls.Add(panel9);
            vehicleContainer.Controls.Add(panel4);
            vehicleContainer.Location = new Point(3, 275);
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
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 172);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
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
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(btnDashboard);
            panel3.Location = new Point(3, 181);
            panel3.Name = "panel3";
            panel3.Size = new Size(283, 88);
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
            panel5.Location = new Point(3, 369);
            panel5.Name = "panel5";
            panel5.Size = new Size(283, 88);
            panel5.TabIndex = 18;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(btnTransaction);
            panel6.Location = new Point(3, 463);
            panel6.Name = "panel6";
            panel6.Size = new Size(283, 88);
            panel6.TabIndex = 16;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(22, 17, 121);
            panel8.Controls.Add(btnLogout);
            panel8.Location = new Point(3, 917);
            panel8.Name = "panel8";
            panel8.Size = new Size(283, 78);
            panel8.TabIndex = 16;
            // 
            // VehicleTimer
            // 
            VehicleTimer.Interval = 10;
            VehicleTimer.Tick += VehicleTimer_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(22, 17, 121);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(vehicleContainer);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel11);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 60);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(283, 995);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 172);
            panel2.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Location = new Point(3, 557);
            panel11.Name = "panel11";
            panel11.Size = new Size(283, 354);
            panel11.TabIndex = 19;
            // 
            // panel7
            // 
            panel7.Controls.Add(dashboard1);
            panel7.Controls.Add(mobilData1);
            panel7.Controls.Add(vehicleData1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(283, 60);
            panel7.Name = "panel7";
            panel7.Size = new Size(1637, 995);
            panel7.TabIndex = 17;
            // 
            // dashboard1
            // 
            dashboard1.Dock = DockStyle.Fill;
            dashboard1.Location = new Point(0, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1637, 995);
            dashboard1.TabIndex = 2;
            // 
            // mobilData1
            // 
            mobilData1.Dock = DockStyle.Fill;
            mobilData1.Location = new Point(0, 0);
            mobilData1.Name = "mobilData1";
            mobilData1.Size = new Size(1637, 995);
            mobilData1.TabIndex = 1;
            // 
            // vehicleData1
            // 
            vehicleData1.Dock = DockStyle.Fill;
            vehicleData1.Location = new Point(0, 0);
            vehicleData1.Name = "vehicleData1";
            vehicleData1.Size = new Size(1637, 995);
            vehicleData1.TabIndex = 0;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1920, 1055);
            Controls.Add(panel7);
            Controls.Add(flowLayoutPanel1);
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
            vehicleContainer.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel3;
        private Button btnLogout;
        private Button btnDashboard;
        private Button btnVehicle;
        private Button btnUsers;
        private Button btnTransaction;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Panel vehicleContainer;
        private Panel panel9;
        private Button btnMotor;
        private Panel panel10;
        private Button btnMobil;
        private System.Windows.Forms.Timer VehicleTimer;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel8;
        private Panel panel11;
        private Panel panel7;
        private Dashboard dashboard1;
        private MobilData mobilData1;
        private VehicleData vehicleData1;
    }
}