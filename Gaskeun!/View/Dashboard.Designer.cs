namespace Gaskeun_.View
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel5 = new Panel();
            lbIncome = new Label();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            panel6 = new Panel();
            lbJmlUser = new Label();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            panel3 = new Panel();
            lbJmlMobil = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            lbJmlMotor = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            dashboardBindingSource = new BindingSource(components);
            Username = new DataGridViewTextBoxColumn();
            JenisKendaraan = new DataGridViewTextBoxColumn();
            NamaKendaraan = new DataGridViewTextBoxColumn();
            Durasi = new DataGridViewTextBoxColumn();
            PaketSewa = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dashboardBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(32, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(1571, 278);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(77, 85, 204);
            panel5.Controls.Add(lbIncome);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(1194, 40);
            panel5.Margin = new Padding(70, 40, 65, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(340, 200);
            panel5.TabIndex = 1;
            // 
            // lbIncome
            // 
            lbIncome.AutoSize = true;
            lbIncome.Font = new Font("Arial Rounded MT Bold", 14F);
            lbIncome.ForeColor = Color.White;
            lbIncome.Location = new Point(118, 54);
            lbIncome.Name = "lbIncome";
            lbIncome.Size = new Size(40, 28);
            lbIncome.TabIndex = 8;
            lbIncome.Text = "12";
            lbIncome.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(24, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 63);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(24, 155);
            label6.Name = "label6";
            label6.Size = new Size(136, 23);
            label6.TabIndex = 7;
            label6.Text = "Total Income";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(77, 85, 204);
            panel6.Controls.Add(lbJmlUser);
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(label8);
            panel6.Location = new Point(806, 41);
            panel6.Margin = new Padding(70, 40, 65, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(340, 200);
            panel6.TabIndex = 1;
            // 
            // lbJmlUser
            // 
            lbJmlUser.AutoSize = true;
            lbJmlUser.Font = new Font("Arial Rounded MT Bold", 14F);
            lbJmlUser.ForeColor = Color.White;
            lbJmlUser.Location = new Point(220, 53);
            lbJmlUser.Name = "lbJmlUser";
            lbJmlUser.Size = new Size(54, 28);
            lbJmlUser.TabIndex = 11;
            lbJmlUser.Text = "120";
            lbJmlUser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(26, 32);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 63);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(26, 154);
            label8.Name = "label8";
            label8.Size = new Size(111, 23);
            label8.TabIndex = 10;
            label8.Text = "Total User";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(77, 85, 204);
            panel3.Controls.Add(lbJmlMobil);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(34, 41);
            panel3.Margin = new Padding(70, 40, 65, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(340, 200);
            panel3.TabIndex = 0;
            // 
            // lbJmlMobil
            // 
            lbJmlMobil.AutoSize = true;
            lbJmlMobil.Font = new Font("Arial Rounded MT Bold", 14F);
            lbJmlMobil.ForeColor = Color.White;
            lbJmlMobil.Location = new Point(217, 53);
            lbJmlMobil.Name = "lbJmlMobil";
            lbJmlMobil.Size = new Size(40, 28);
            lbJmlMobil.TabIndex = 2;
            lbJmlMobil.Text = "12";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 154);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 1;
            label1.Text = "Total Mobil";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 63);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(77, 85, 204);
            panel4.Controls.Add(lbJmlMotor);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(420, 41);
            panel4.Margin = new Padding(70, 40, 65, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(340, 200);
            panel4.TabIndex = 1;
            // 
            // lbJmlMotor
            // 
            lbJmlMotor.AutoSize = true;
            lbJmlMotor.Font = new Font("Arial Rounded MT Bold", 14F);
            lbJmlMotor.ForeColor = Color.White;
            lbJmlMotor.Location = new Point(222, 53);
            lbJmlMotor.Name = "lbJmlMotor";
            lbJmlMotor.Size = new Size(40, 28);
            lbJmlMotor.TabIndex = 5;
            lbJmlMotor.Text = "12";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 63);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 154);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 4;
            label4.Text = "Total Motor";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(32, 343);
            panel2.Name = "panel2";
            panel2.Size = new Size(1571, 647);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Username, JenisKendaraan, NamaKendaraan, Durasi, PaketSewa, Harga });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(37, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(1497, 531);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(36, 44);
            label2.Name = "label2";
            label2.Size = new Size(218, 30);
            label2.TabIndex = 2;
            label2.Text = "Pelanggan Hari Ini";
            // 
            // dashboardBindingSource
            // 
            dashboardBindingSource.DataSource = typeof(Models.Dashboard);
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            // 
            // JenisKendaraan
            // 
            JenisKendaraan.DataPropertyName = "JenisKendaraan";
            JenisKendaraan.HeaderText = "Jenis Kendaraan";
            JenisKendaraan.MinimumWidth = 6;
            JenisKendaraan.Name = "JenisKendaraan";
            // 
            // NamaKendaraan
            // 
            NamaKendaraan.DataPropertyName = "NamaKendaraan";
            NamaKendaraan.HeaderText = "Nama Kendaraan";
            NamaKendaraan.MinimumWidth = 6;
            NamaKendaraan.Name = "NamaKendaraan";
            // 
            // Durasi
            // 
            Durasi.DataPropertyName = "Durasi";
            Durasi.HeaderText = "Durasi";
            Durasi.MinimumWidth = 6;
            Durasi.Name = "Durasi";
            // 
            // PaketSewa
            // 
            PaketSewa.DataPropertyName = "PaketSewa";
            PaketSewa.HeaderText = "Paket Sewa";
            PaketSewa.MinimumWidth = 6;
            PaketSewa.Name = "PaketSewa";
            // 
            // Harga
            // 
            Harga.DataPropertyName = "Harga";
            Harga.HeaderText = "Total Harga";
            Harga.MinimumWidth = 6;
            Harga.Name = "Harga";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Size = new Size(1637, 1025);
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dashboardBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lbJmlMobil;
        private Label lbJmlUser;
        private PictureBox pictureBox4;
        private Label label8;
        private Label lbIncome;
        private PictureBox pictureBox3;
        private Label label6;
        private Label lbJmlMotor;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label2;
        private DataGridView dataGridView1;
        private BindingSource dashboardBindingSource;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn JenisKendaraan;
        private DataGridViewTextBoxColumn NamaKendaraan;
        private DataGridViewTextBoxColumn Durasi;
        private DataGridViewTextBoxColumn PaketSewa;
        private DataGridViewTextBoxColumn Harga;
    }
}
