namespace Gaskeun_.View
{
    partial class VehicleData
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnTambah = new Button();
            btnHapus = new Button();
            btnUpdate = new Button();
            panel1 = new Panel();
            btnUpload = new Button();
            btnChoose = new Button();
            image = new PictureBox();
            panel3 = new Panel();
            tbPlat = new TextBox();
            label4 = new Label();
            label2 = new Label();
            tbNamaMotor = new TextBox();
            label3 = new Label();
            tbTahun = new TextBox();
            tbMerk = new TextBox();
            label6 = new Label();
            panel4 = new Panel();
            label12 = new Label();
            tbBensin = new TextBox();
            label11 = new Label();
            tbGambar = new TextBox();
            cbStatus = new ComboBox();
            label7 = new Label();
            tbCC = new TextBox();
            label8 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            tbHari = new TextBox();
            tbBulan = new TextBox();
            label9 = new Label();
            label10 = new Label();
            tbMinggu = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Plat = new DataGridViewTextBoxColumn();
            NamaMotor = new DataGridViewTextBoxColumn();
            Merk = new DataGridViewTextBoxColumn();
            Tahun = new DataGridViewTextBoxColumn();
            CC = new DataGridViewTextBoxColumn();
            KapasitasBensin = new DataGridViewTextBoxColumn();
            Gambar = new DataGridViewTextBoxColumn();
            HargaHari = new DataGridViewTextBoxColumn();
            HargaMinggu = new DataGridViewTextBoxColumn();
            HargaBulan = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(33, 52, 72);
            btnTambah.Cursor = Cursors.Hand;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 114, 184);
            btnTambah.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 114, 184);
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Arial Rounded MT Bold", 14F);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(253, 288);
            btnTambah.Margin = new Padding(420, 3, 3, 3);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(120, 52);
            btnTambah.TabIndex = 11;
            btnTambah.Text = "Add";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(33, 52, 72);
            btnHapus.Cursor = Cursors.Hand;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 114, 184);
            btnHapus.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 114, 184);
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Arial Rounded MT Bold", 14F);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(824, 288);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(125, 52);
            btnHapus.TabIndex = 25;
            btnHapus.Text = "Remove";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(33, 52, 72);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 114, 184);
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 114, 184);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 14F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(537, 288);
            btnUpdate.Margin = new Padding(190, 3, 3, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 52);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(btnUpload);
            panel1.Controls.Add(btnChoose);
            panel1.Controls.Add(image);
            panel1.Controls.Add(btnHapus);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(29, 602);
            panel1.Name = "panel1";
            panel1.Size = new Size(1577, 397);
            panel1.TabIndex = 2;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.FromArgb(33, 52, 72);
            btnUpload.Cursor = Cursors.Hand;
            btnUpload.FlatAppearance.BorderSize = 0;
            btnUpload.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 114, 184);
            btnUpload.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 114, 184);
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Arial Rounded MT Bold", 14F);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(1395, 288);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(142, 52);
            btnUpload.TabIndex = 32;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnChoose
            // 
            btnChoose.BackColor = Color.FromArgb(33, 52, 72);
            btnChoose.Cursor = Cursors.Hand;
            btnChoose.FlatAppearance.BorderSize = 0;
            btnChoose.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 114, 184);
            btnChoose.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 114, 184);
            btnChoose.FlatStyle = FlatStyle.Flat;
            btnChoose.Font = new Font("Arial Rounded MT Bold", 14F);
            btnChoose.ForeColor = Color.White;
            btnChoose.Location = new Point(1230, 288);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(142, 52);
            btnChoose.TabIndex = 31;
            btnChoose.Text = "Choose";
            btnChoose.UseVisualStyleBackColor = false;
            btnChoose.Click += btnChoose_Click;
            // 
            // image
            // 
            image.BackColor = Color.Transparent;
            image.Location = new Point(1230, 44);
            image.Name = "image";
            image.Size = new Size(307, 223);
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.TabIndex = 30;
            image.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(tbPlat);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(tbNamaMotor);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(tbTahun);
            panel3.Controls.Add(tbMerk);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(40, 20);
            panel3.Margin = new Padding(180, 20, 30, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 235);
            panel3.TabIndex = 27;
            // 
            // tbPlat
            // 
            tbPlat.BorderStyle = BorderStyle.FixedSingle;
            tbPlat.Font = new Font("Tahoma", 12F);
            tbPlat.Location = new Point(156, 23);
            tbPlat.Multiline = true;
            tbPlat.Name = "tbPlat";
            tbPlat.Size = new Size(139, 31);
            tbPlat.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(72, 196);
            label4.Name = "label4";
            label4.Size = new Size(66, 24);
            label4.TabIndex = 7;
            label4.Text = "Tahun";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 83);
            label2.Name = "label2";
            label2.Size = new Size(119, 24);
            label2.TabIndex = 0;
            label2.Text = "Nama Motor";
            // 
            // tbNamaMotor
            // 
            tbNamaMotor.BorderStyle = BorderStyle.FixedSingle;
            tbNamaMotor.Font = new Font("Tahoma", 12F);
            tbNamaMotor.Location = new Point(156, 80);
            tbNamaMotor.Multiline = true;
            tbNamaMotor.Name = "tbNamaMotor";
            tbNamaMotor.Size = new Size(139, 31);
            tbNamaMotor.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(84, 139);
            label3.Name = "label3";
            label3.Size = new Size(53, 24);
            label3.TabIndex = 5;
            label3.Text = "Merk";
            // 
            // tbTahun
            // 
            tbTahun.BorderStyle = BorderStyle.FixedSingle;
            tbTahun.Font = new Font("Tahoma", 12F);
            tbTahun.Location = new Point(156, 192);
            tbTahun.Multiline = true;
            tbTahun.Name = "tbTahun";
            tbTahun.Size = new Size(139, 31);
            tbTahun.TabIndex = 8;
            // 
            // tbMerk
            // 
            tbMerk.BorderStyle = BorderStyle.FixedSingle;
            tbMerk.Font = new Font("Tahoma", 12F);
            tbMerk.Location = new Point(156, 135);
            tbMerk.Multiline = true;
            tbMerk.Name = "tbMerk";
            tbMerk.Size = new Size(139, 31);
            tbMerk.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(92, 26);
            label6.Name = "label6";
            label6.Size = new Size(44, 24);
            label6.TabIndex = 14;
            label6.Text = "Plat";
            // 
            // panel4
            // 
            panel4.Controls.Add(label12);
            panel4.Controls.Add(tbBensin);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(tbGambar);
            panel4.Controls.Add(cbStatus);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(tbCC);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(432, 20);
            panel4.Margin = new Padding(94, 20, 30, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(329, 235);
            panel4.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 12F);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(57, 81);
            label12.Name = "label12";
            label12.Size = new Size(69, 24);
            label12.TabIndex = 32;
            label12.Text = "Bensin";
            // 
            // tbBensin
            // 
            tbBensin.BorderStyle = BorderStyle.FixedSingle;
            tbBensin.Font = new Font("Tahoma", 12F);
            tbBensin.Location = new Point(145, 78);
            tbBensin.Multiline = true;
            tbBensin.Name = "tbBensin";
            tbBensin.Size = new Size(139, 31);
            tbBensin.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 12F);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(5, 138);
            label11.Name = "label11";
            label11.Size = new Size(121, 24);
            label11.TabIndex = 30;
            label11.Text = "URL Gambar";
            // 
            // tbGambar
            // 
            tbGambar.BorderStyle = BorderStyle.FixedSingle;
            tbGambar.Font = new Font("Tahoma", 12F);
            tbGambar.Location = new Point(145, 134);
            tbGambar.Multiline = true;
            tbGambar.Name = "tbGambar";
            tbGambar.Size = new Size(139, 31);
            tbGambar.TabIndex = 31;
            tbGambar.TextChanged += tbGambar_TextChanged;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Tahoma", 12F);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Tersedia", "Disewa" });
            cbStatus.Location = new Point(145, 191);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(139, 32);
            cbStatus.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(92, 25);
            label7.Name = "label7";
            label7.Size = new Size(34, 24);
            label7.TabIndex = 16;
            label7.Text = "CC";
            // 
            // tbCC
            // 
            tbCC.BorderStyle = BorderStyle.FixedSingle;
            tbCC.Font = new Font("Tahoma", 12F);
            tbCC.Location = new Point(145, 23);
            tbCC.Multiline = true;
            tbCC.Name = "tbCC";
            tbCC.Size = new Size(139, 31);
            tbCC.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(61, 194);
            label8.Name = "label8";
            label8.Size = new Size(66, 24);
            label8.TabIndex = 18;
            label8.Text = "Status";
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(tbHari);
            panel5.Controls.Add(tbBulan);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(tbMinggu);
            panel5.Location = new Point(824, 20);
            panel5.Margin = new Padding(3, 20, 30, 30);
            panel5.Name = "panel5";
            panel5.Size = new Size(363, 224);
            panel5.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(49, 29);
            label5.Name = "label5";
            label5.Size = new Size(142, 24);
            label5.TabIndex = 9;
            label5.Text = "Harga per Hari";
            // 
            // tbHari
            // 
            tbHari.BorderStyle = BorderStyle.FixedSingle;
            tbHari.Font = new Font("Tahoma", 12F);
            tbHari.Location = new Point(207, 25);
            tbHari.Multiline = true;
            tbHari.Name = "tbHari";
            tbHari.Size = new Size(139, 31);
            tbHari.TabIndex = 10;
            // 
            // tbBulan
            // 
            tbBulan.BorderStyle = BorderStyle.FixedSingle;
            tbBulan.Font = new Font("Tahoma", 12F);
            tbBulan.Location = new Point(207, 171);
            tbBulan.Multiline = true;
            tbBulan.Name = "tbBulan";
            tbBulan.Size = new Size(139, 31);
            tbBulan.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(20, 104);
            label9.Name = "label9";
            label9.Size = new Size(169, 24);
            label9.TabIndex = 20;
            label9.Text = "Harga per Minggu";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(35, 174);
            label10.Name = "label10";
            label10.Size = new Size(155, 24);
            label10.TabIndex = 22;
            label10.Text = "Harga per Bulan";
            // 
            // tbMinggu
            // 
            tbMinggu.BorderStyle = BorderStyle.FixedSingle;
            tbMinggu.Font = new Font("Tahoma", 12F);
            tbMinggu.Location = new Point(207, 101);
            tbMinggu.Multiline = true;
            tbMinggu.Name = "tbMinggu";
            tbMinggu.Size = new Size(139, 31);
            tbMinggu.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(29, 30);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(40, 65, 40, 40);
            panel2.Size = new Size(1577, 542);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(43, 32);
            label1.Name = "label1";
            label1.Size = new Size(136, 30);
            label1.TabIndex = 1;
            label1.Text = "Data Motor";
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Plat, NamaMotor, Merk, Tahun, CC, KapasitasBensin, Gambar, HargaHari, HargaMinggu, HargaBulan, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(40, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(1497, 437);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Plat
            // 
            Plat.DataPropertyName = "Plat";
            Plat.HeaderText = "Plat";
            Plat.MinimumWidth = 6;
            Plat.Name = "Plat";
            // 
            // NamaMotor
            // 
            NamaMotor.DataPropertyName = "NamaKendaraan";
            NamaMotor.HeaderText = "Nama Motor";
            NamaMotor.MinimumWidth = 6;
            NamaMotor.Name = "NamaMotor";
            // 
            // Merk
            // 
            Merk.DataPropertyName = "Merk";
            Merk.HeaderText = "Merk";
            Merk.MinimumWidth = 6;
            Merk.Name = "Merk";
            // 
            // Tahun
            // 
            Tahun.DataPropertyName = "Tahun";
            Tahun.HeaderText = "Tahun";
            Tahun.MinimumWidth = 6;
            Tahun.Name = "Tahun";
            // 
            // CC
            // 
            CC.DataPropertyName = "CC";
            CC.HeaderText = "CC";
            CC.MinimumWidth = 6;
            CC.Name = "CC";
            // 
            // KapasitasBensin
            // 
            KapasitasBensin.DataPropertyName = "KapasitasBensin";
            KapasitasBensin.HeaderText = "Bensin";
            KapasitasBensin.MinimumWidth = 6;
            KapasitasBensin.Name = "KapasitasBensin";
            // 
            // Gambar
            // 
            Gambar.DataPropertyName = "Gambar";
            Gambar.HeaderText = "URL Gambar";
            Gambar.MinimumWidth = 6;
            Gambar.Name = "Gambar";
            // 
            // HargaHari
            // 
            HargaHari.DataPropertyName = "HargaHari";
            HargaHari.HeaderText = "Harga/Hari";
            HargaHari.MinimumWidth = 6;
            HargaHari.Name = "HargaHari";
            // 
            // HargaMinggu
            // 
            HargaMinggu.DataPropertyName = "HargaMinggu";
            HargaMinggu.HeaderText = "Harga/Minggu";
            HargaMinggu.MinimumWidth = 6;
            HargaMinggu.Name = "HargaMinggu";
            // 
            // HargaBulan
            // 
            HargaBulan.DataPropertyName = "HargaBulan";
            HargaBulan.HeaderText = "Harga/Bulan";
            HargaBulan.MinimumWidth = 6;
            HargaBulan.Name = "HargaBulan";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // VehicleData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = SystemColors.ControlLight;
            Name = "VehicleData";
            Size = new Size(1637, 1025);
            Load += VehicleData_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTambah;
        private Button btnHapus;
        private Button btnUpdate;
        private Panel panel1;
        private Panel panel5;
        private Label label5;
        private TextBox tbHari;
        private TextBox tbBulan;
        private Label label9;
        private Label label10;
        private TextBox tbMinggu;
        private Panel panel4;
        private Label label4;
        private ComboBox cbStatus;
        private TextBox tbTahun;
        private Label label7;
        private TextBox tbCC;
        private Label label8;
        private Panel panel3;
        private TextBox tbPlat;
        private Label label2;
        private TextBox tbNamaMotor;
        private Label label3;
        private TextBox tbMerk;
        private Label label6;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label11;
        private TextBox tbGambar;
        private PictureBox image;
        private Label label12;
        private TextBox tbBensin;
        private DataGridViewTextBoxColumn Plat;
        private DataGridViewTextBoxColumn NamaMotor;
        private DataGridViewTextBoxColumn Merk;
        private DataGridViewTextBoxColumn Tahun;
        private DataGridViewTextBoxColumn CC;
        private DataGridViewTextBoxColumn KapasitasBensin;
        private DataGridViewTextBoxColumn Gambar;
        private DataGridViewTextBoxColumn HargaHari;
        private DataGridViewTextBoxColumn HargaMinggu;
        private DataGridViewTextBoxColumn HargaBulan;
        private DataGridViewTextBoxColumn Status;
        private Button btnUpload;
        private Button btnChoose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
