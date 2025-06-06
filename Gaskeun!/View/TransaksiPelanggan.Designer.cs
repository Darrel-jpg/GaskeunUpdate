﻿namespace Gaskeun_.View
{
    partial class TransaksiPelanggan
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            cbStatus = new ComboBox();
            label8 = new Label();
            label2 = new Label();
            btnUpdate = new Button();
            label5 = new Label();
            tbDenda = new TextBox();
            dtTglKeterlambatan = new DateTimePicker();
            Username = new DataGridViewTextBoxColumn();
            JenisKendaraan = new DataGridViewTextBoxColumn();
            NamaKendaraan = new DataGridViewTextBoxColumn();
            TanggalSewa = new DataGridViewTextBoxColumn();
            TanggalKembali = new DataGridViewTextBoxColumn();
            TanggalKeterlambatan = new DataGridViewTextBoxColumn();
            Durasi = new DataGridViewTextBoxColumn();
            PaketSewa = new DataGridViewTextBoxColumn();
            Denda = new DataGridViewTextBoxColumn();
            MetodePembayaran = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Berjalan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Username, JenisKendaraan, NamaKendaraan, TanggalSewa, TanggalKembali, TanggalKeterlambatan, Durasi, PaketSewa, Denda, MetodePembayaran, Harga, Berjalan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(32, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(1518, 636);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(41, 29);
            label1.Name = "label1";
            label1.Size = new Size(240, 30);
            label1.TabIndex = 3;
            label1.Text = "Transaksi Pelanggan";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(27, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1583, 733);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(cbStatus);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(tbDenda);
            panel2.Controls.Add(dtTglKeterlambatan);
            panel2.Location = new Point(27, 785);
            panel2.Name = "panel2";
            panel2.Size = new Size(1583, 215);
            panel2.TabIndex = 2;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Segoe UI", 12F);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Selesai", "Berjalan" });
            cbStatus.Location = new Point(982, 77);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(139, 36);
            cbStatus.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(982, 43);
            label8.Name = "label8";
            label8.Size = new Size(66, 24);
            label8.TabIndex = 27;
            label8.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(364, 38);
            label2.Name = "label2";
            label2.Size = new Size(220, 24);
            label2.TabIndex = 26;
            label2.Text = "Tanggal Keterlambatan";
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
            btnUpdate.Location = new Point(735, 131);
            btnUpdate.Margin = new Padding(190, 3, 3, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 52);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(726, 39);
            label5.Name = "label5";
            label5.Size = new Size(128, 24);
            label5.TabIndex = 11;
            label5.Text = "Harga Denda";
            // 
            // tbDenda
            // 
            tbDenda.BorderStyle = BorderStyle.FixedSingle;
            tbDenda.Font = new Font("Tahoma", 12F);
            tbDenda.Location = new Point(726, 77);
            tbDenda.Multiline = true;
            tbDenda.Name = "tbDenda";
            tbDenda.Size = new Size(139, 31);
            tbDenda.TabIndex = 12;
            // 
            // dtTglKeterlambatan
            // 
            dtTglKeterlambatan.Location = new Point(364, 76);
            dtTglKeterlambatan.Name = "dtTglKeterlambatan";
            dtTglKeterlambatan.Size = new Size(250, 27);
            dtTglKeterlambatan.TabIndex = 0;
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
            // TanggalSewa
            // 
            TanggalSewa.DataPropertyName = "TanggalSewa";
            TanggalSewa.HeaderText = "Tgl Sewa";
            TanggalSewa.MinimumWidth = 6;
            TanggalSewa.Name = "TanggalSewa";
            // 
            // TanggalKembali
            // 
            TanggalKembali.DataPropertyName = "TanggalKembali";
            TanggalKembali.HeaderText = "Tgl Kembali";
            TanggalKembali.MinimumWidth = 6;
            TanggalKembali.Name = "TanggalKembali";
            // 
            // TanggalKeterlambatan
            // 
            TanggalKeterlambatan.DataPropertyName = "TanggalKeterlambatan";
            TanggalKeterlambatan.HeaderText = "Tgl Keterlambatan";
            TanggalKeterlambatan.MinimumWidth = 6;
            TanggalKeterlambatan.Name = "TanggalKeterlambatan";
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
            // Denda
            // 
            Denda.DataPropertyName = "Denda";
            Denda.HeaderText = "Denda";
            Denda.MinimumWidth = 6;
            Denda.Name = "Denda";
            // 
            // MetodePembayaran
            // 
            MetodePembayaran.DataPropertyName = "MetodePembayaran";
            MetodePembayaran.HeaderText = "Metode Pembayaran";
            MetodePembayaran.MinimumWidth = 6;
            MetodePembayaran.Name = "MetodePembayaran";
            // 
            // Harga
            // 
            Harga.DataPropertyName = "Harga";
            Harga.HeaderText = "Total Harga";
            Harga.MinimumWidth = 6;
            Harga.Name = "Harga";
            // 
            // Berjalan
            // 
            Berjalan.DataPropertyName = "StatusText";
            Berjalan.HeaderText = "Status";
            Berjalan.MinimumWidth = 6;
            Berjalan.Name = "Berjalan";
            // 
            // TransaksiPelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TransaksiPelanggan";
            Size = new Size(1637, 1025);
            Load += TransaksiPelanggan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private DateTimePicker dtTglKeterlambatan;
        private Label label5;
        private TextBox tbDenda;
        private Label label2;
        private Button btnUpdate;
        private ComboBox cbStatus;
        private Label label8;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn JenisKendaraan;
        private DataGridViewTextBoxColumn NamaKendaraan;
        private DataGridViewTextBoxColumn TanggalSewa;
        private DataGridViewTextBoxColumn TanggalKembali;
        private DataGridViewTextBoxColumn TanggalKeterlambatan;
        private DataGridViewTextBoxColumn Durasi;
        private DataGridViewTextBoxColumn PaketSewa;
        private DataGridViewTextBoxColumn Denda;
        private DataGridViewTextBoxColumn MetodePembayaran;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Berjalan;
    }
}
