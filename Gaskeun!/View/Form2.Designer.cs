namespace Gaskeun_.View
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            button1 = new Button();
            vehicleContainer = new Panel();
            panel10 = new Panel();
            btnMobil = new Button();
            panel9 = new Panel();
            btnMotor = new Button();
            panel4 = new Panel();
            btnVehicle = new Button();
            panel3 = new Panel();
            btnDashboard = new Button();
            panel8 = new Panel();
            btnLogout = new Button();
            VehicleTimer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            vehicleContainer.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(vehicleContainer, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel8, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(283, 1055);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 191);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 88);
            panel1.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 31, 179);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 31, 179);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 14F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-10, -8);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(306, 100);
            button1.TabIndex = 16;
            button1.Text = "        Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // vehicleContainer
            // 
            vehicleContainer.BackColor = Color.Transparent;
            vehicleContainer.Controls.Add(panel10);
            vehicleContainer.Controls.Add(panel9);
            vehicleContainer.Controls.Add(panel4);
            vehicleContainer.Location = new Point(3, 97);
            vehicleContainer.MaximumSize = new Size(283, 264);
            vehicleContainer.MinimumSize = new Size(283, 88);
            vehicleContainer.Name = "vehicleContainer";
            vehicleContainer.Size = new Size(283, 88);
            vehicleContainer.TabIndex = 14;
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
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(btnDashboard);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(277, 88);
            panel3.TabIndex = 15;
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
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel8.BackColor = SystemColors.ButtonShadow;
            panel8.Controls.Add(btnLogout);
            panel8.Location = new Point(3, 974);
            panel8.Name = "panel8";
            panel8.Size = new Size(277, 78);
            panel8.TabIndex = 17;
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
            // VehicleTimer
            // 
            VehicleTimer.Interval = 10;
            VehicleTimer.Tick += bikeTimer_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1924, 1055);
            Controls.Add(tableLayoutPanel1);
            Name = "Form2";
            Text = "x";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            vehicleContainer.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Button btnDashboard;
        private Panel vehicleContainer;
        private Panel panel10;
        private Button btnMobil;
        private Panel panel9;
        private Button btnMotor;
        private Panel panel4;
        private Button btnVehicle;
        private Panel panel8;
        private Button btnLogout;
        private System.Windows.Forms.Timer VehicleTimer;
        private Panel panel1;
        private Button button1;
    }
}