namespace Gaskeun_.View
{
    partial class MobilData
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
            panel1 = new Panel();
            cbStatus = new ComboBox();
            btnHapus = new Button();
            btnUpdate = new Button();
            tbBulan = new TextBox();
            label10 = new Label();
            tbMinggu = new TextBox();
            label9 = new Label();
            label8 = new Label();
            tbWarna = new TextBox();
            label7 = new Label();
            tbPlat = new TextBox();
            label6 = new Label();
            btnTambah = new Button();
            tbHari = new TextBox();
            label5 = new Label();
            tbTahun = new TextBox();
            label4 = new Label();
            tbMerk = new TextBox();
            label3 = new Label();
            tbNamaMobil = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Plat = new DataGridViewTextBoxColumn();
            NamaMobil = new DataGridViewTextBoxColumn();
            Merk = new DataGridViewTextBoxColumn();
            Tahun = new DataGridViewTextBoxColumn();
            Warna = new DataGridViewTextBoxColumn();
            HargaHari = new DataGridViewTextBoxColumn();
            HargaMinggu = new DataGridViewTextBoxColumn();
            HargaBulan = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(cbStatus);
            panel1.Controls.Add(btnHapus);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(tbBulan);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(tbMinggu);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(tbWarna);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(tbPlat);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(tbHari);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbTahun);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbMerk);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbNamaMobil);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Tahoma", 12F);
            panel1.Location = new Point(21, 604);
            panel1.Name = "panel1";
            panel1.Size = new Size(1595, 379);
            panel1.TabIndex = 4;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Segoe UI", 12F);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Tersedia", "Disewa" });
            cbStatus.Location = new Point(731, 191);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(139, 36);
            cbStatus.TabIndex = 26;
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
            btnHapus.Location = new Point(980, 287);
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
            btnUpdate.Location = new Point(712, 287);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 52);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbBulan
            // 
            tbBulan.BorderStyle = BorderStyle.FixedSingle;
            tbBulan.Font = new Font("Tahoma", 12F);
            tbBulan.Location = new Point(1174, 198);
            tbBulan.Multiline = true;
            tbBulan.Name = "tbBulan";
            tbBulan.Size = new Size(139, 31);
            tbBulan.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(1005, 201);
            label10.Name = "label10";
            label10.Size = new Size(155, 24);
            label10.TabIndex = 22;
            label10.Text = "Harga per Bulan";
            // 
            // tbMinggu
            // 
            tbMinggu.BorderStyle = BorderStyle.FixedSingle;
            tbMinggu.Font = new Font("Tahoma", 12F);
            tbMinggu.Location = new Point(1174, 124);
            tbMinggu.Multiline = true;
            tbMinggu.Name = "tbMinggu";
            tbMinggu.Size = new Size(139, 31);
            tbMinggu.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(989, 127);
            label9.Name = "label9";
            label9.Size = new Size(169, 24);
            label9.TabIndex = 20;
            label9.Text = "Harga per Minggu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(647, 198);
            label8.Name = "label8";
            label8.Size = new Size(66, 24);
            label8.TabIndex = 18;
            label8.Text = "Status";
            // 
            // tbWarna
            // 
            tbWarna.BorderStyle = BorderStyle.FixedSingle;
            tbWarna.Font = new Font("Tahoma", 12F);
            tbWarna.Location = new Point(731, 123);
            tbWarna.Multiline = true;
            tbWarna.Name = "tbWarna";
            tbWarna.Size = new Size(139, 31);
            tbWarna.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(646, 128);
            label7.Name = "label7";
            label7.Size = new Size(68, 24);
            label7.TabIndex = 16;
            label7.Text = "Warna";
            // 
            // tbPlat
            // 
            tbPlat.BorderStyle = BorderStyle.FixedSingle;
            tbPlat.Font = new Font("Tahoma", 12F);
            tbPlat.Location = new Point(306, 47);
            tbPlat.Multiline = true;
            tbPlat.Name = "tbPlat";
            tbPlat.Size = new Size(139, 31);
            tbPlat.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(245, 50);
            label6.Name = "label6";
            label6.Size = new Size(44, 24);
            label6.TabIndex = 14;
            label6.Text = "Plat";
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
            btnTambah.Location = new Point(436, 287);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(125, 52);
            btnTambah.TabIndex = 11;
            btnTambah.Text = "Add";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // tbHari
            // 
            tbHari.BorderStyle = BorderStyle.FixedSingle;
            tbHari.Font = new Font("Tahoma", 12F);
            tbHari.Location = new Point(1174, 47);
            tbHari.Multiline = true;
            tbHari.Name = "tbHari";
            tbHari.Size = new Size(139, 31);
            tbHari.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(1018, 50);
            label5.Name = "label5";
            label5.Size = new Size(142, 24);
            label5.TabIndex = 9;
            label5.Text = "Harga per Hari";
            // 
            // tbTahun
            // 
            tbTahun.BorderStyle = BorderStyle.FixedSingle;
            tbTahun.Font = new Font("Tahoma", 12F);
            tbTahun.Location = new Point(731, 47);
            tbTahun.Multiline = true;
            tbTahun.Name = "tbTahun";
            tbTahun.Size = new Size(139, 31);
            tbTahun.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(648, 51);
            label4.Name = "label4";
            label4.Size = new Size(66, 24);
            label4.TabIndex = 7;
            label4.Text = "Tahun";
            // 
            // tbMerk
            // 
            tbMerk.BorderStyle = BorderStyle.FixedSingle;
            tbMerk.Font = new Font("Tahoma", 12F);
            tbMerk.Location = new Point(306, 193);
            tbMerk.Multiline = true;
            tbMerk.Name = "tbMerk";
            tbMerk.Size = new Size(139, 31);
            tbMerk.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(236, 195);
            label3.Name = "label3";
            label3.Size = new Size(53, 24);
            label3.TabIndex = 5;
            label3.Text = "Merk";
            // 
            // tbNamaMobil
            // 
            tbNamaMobil.BorderStyle = BorderStyle.FixedSingle;
            tbNamaMobil.Font = new Font("Tahoma", 12F);
            tbNamaMobil.Location = new Point(306, 123);
            tbNamaMobil.Multiline = true;
            tbNamaMobil.Name = "tbNamaMobil";
            tbNamaMobil.Size = new Size(139, 31);
            tbNamaMobil.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(174, 126);
            label2.Name = "label2";
            label2.Size = new Size(115, 24);
            label2.TabIndex = 0;
            label2.Text = "Nama Mobil";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(21, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(1595, 564);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(19, 11);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 1;
            label1.Text = "Data Mobil";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Plat, NamaMobil, Merk, Tahun, Warna, HargaHari, HargaMinggu, HargaBulan, Status });
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(19, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(1557, 494);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // Plat
            // 
            Plat.DataPropertyName = "Plat";
            Plat.HeaderText = "Plat";
            Plat.MinimumWidth = 6;
            Plat.Name = "Plat";
            // 
            // NamaMobil
            // 
            NamaMobil.DataPropertyName = "NamaMobil";
            NamaMobil.HeaderText = "Nama Mobil";
            NamaMobil.MinimumWidth = 6;
            NamaMobil.Name = "NamaMobil";
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
            // Warna
            // 
            Warna.DataPropertyName = "Warna";
            Warna.HeaderText = "Warna";
            Warna.MinimumWidth = 6;
            Warna.Name = "Warna";
            // 
            // HargaHari
            // 
            HargaHari.DataPropertyName = "HargaPerHari";
            HargaHari.HeaderText = "Harga per Hari";
            HargaHari.MinimumWidth = 6;
            HargaHari.Name = "HargaHari";
            // 
            // HargaMinggu
            // 
            HargaMinggu.DataPropertyName = "HargaPerMinggu";
            HargaMinggu.HeaderText = "Harga per Minggu";
            HargaMinggu.MinimumWidth = 6;
            HargaMinggu.Name = "HargaMinggu";
            // 
            // HargaBulan
            // 
            HargaBulan.DataPropertyName = "HargaPerBulan";
            HargaBulan.HeaderText = "Harga per Bulan";
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
            // MobilData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "MobilData";
            Size = new Size(1637, 995);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbStatus;
        private Button btnHapus;
        private Button btnUpdate;
        private TextBox tbBulan;
        private Label label10;
        private TextBox tbMinggu;
        private Label label9;
        private Label label8;
        private TextBox tbWarna;
        private Label label7;
        private TextBox tbPlat;
        private Label label6;
        private Button btnTambah;
        private TextBox tbHari;
        private Label label5;
        private TextBox tbTahun;
        private Label label4;
        private TextBox tbMerk;
        private Label label3;
        private TextBox tbNamaMobil;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Plat;
        private DataGridViewTextBoxColumn NamaMobil;
        private DataGridViewTextBoxColumn Merk;
        private DataGridViewTextBoxColumn Tahun;
        private DataGridViewTextBoxColumn Warna;
        private DataGridViewTextBoxColumn HargaHari;
        private DataGridViewTextBoxColumn HargaMinggu;
        private DataGridViewTextBoxColumn HargaBulan;
        private DataGridViewTextBoxColumn Status;
    }
}
