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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            IdTransaksi = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Motor = new DataGridViewTextBoxColumn();
            Mobil = new DataGridViewTextBoxColumn();
            TanggalSewa = new DataGridViewTextBoxColumn();
            TanggalKembali = new DataGridViewTextBoxColumn();
            Jaminan = new DataGridViewTextBoxColumn();
            PaketSewa = new DataGridViewTextBoxColumn();
            Durasi = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            dashboardBindingSource = new BindingSource(components);
            dashboardBindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dashboardBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dashboardBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(28, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1583, 970);
            panel1.TabIndex = 0;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdTransaksi, Username, Motor, Mobil, TanggalSewa, TanggalKembali, Jaminan, PaketSewa, Durasi, Harga });
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
            dataGridView1.Size = new Size(1518, 872);
            dataGridView1.TabIndex = 2;
            // 
            // IdTransaksi
            // 
            IdTransaksi.DataPropertyName = "IdTransaksi";
            IdTransaksi.HeaderText = "ID Transaksi";
            IdTransaksi.MinimumWidth = 6;
            IdTransaksi.Name = "IdTransaksi";
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            // 
            // Motor
            // 
            Motor.DataPropertyName = "Motor";
            Motor.HeaderText = "Motor";
            Motor.MinimumWidth = 6;
            Motor.Name = "Motor";
            // 
            // Mobil
            // 
            Mobil.DataPropertyName = "Mobil";
            Mobil.HeaderText = "Mobil";
            Mobil.MinimumWidth = 6;
            Mobil.Name = "Mobil";
            // 
            // TanggalSewa
            // 
            TanggalSewa.DataPropertyName = "TanggalSewa";
            TanggalSewa.HeaderText = "Tanggal Sewa";
            TanggalSewa.MinimumWidth = 6;
            TanggalSewa.Name = "TanggalSewa";
            // 
            // TanggalKembali
            // 
            TanggalKembali.DataPropertyName = "TanggalKembali";
            TanggalKembali.HeaderText = "Tanggal Kembali";
            TanggalKembali.MinimumWidth = 6;
            TanggalKembali.Name = "TanggalKembali";
            // 
            // Jaminan
            // 
            Jaminan.DataPropertyName = "Jaminan";
            Jaminan.HeaderText = "Jaminan";
            Jaminan.MinimumWidth = 6;
            Jaminan.Name = "Jaminan";
            // 
            // PaketSewa
            // 
            PaketSewa.DataPropertyName = "PaketSewa";
            PaketSewa.HeaderText = "Paket Sewa";
            PaketSewa.MinimumWidth = 6;
            PaketSewa.Name = "PaketSewa";
            // 
            // Durasi
            // 
            Durasi.DataPropertyName = "Durasi";
            Durasi.HeaderText = "Durasi";
            Durasi.MinimumWidth = 6;
            Durasi.Name = "Durasi";
            // 
            // Harga
            // 
            Harga.DataPropertyName = "Harga";
            Harga.HeaderText = "Total Harga";
            Harga.MinimumWidth = 6;
            Harga.Name = "Harga";
            // 
            // dashboardBindingSource
            // 
            dashboardBindingSource.DataSource = typeof(Models.Dashboard);
            // 
            // dashboardBindingSource1
            // 
            dashboardBindingSource1.DataSource = typeof(Models.Dashboard);
            // 
            // TransaksiPelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel1);
            Name = "TransaksiPelanggan";
            Size = new Size(1637, 1025);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dashboardBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dashboardBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdTransaksi;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Motor;
        private DataGridViewTextBoxColumn Mobil;
        private DataGridViewTextBoxColumn TanggalSewa;
        private DataGridViewTextBoxColumn TanggalKembali;
        private DataGridViewTextBoxColumn Jaminan;
        private DataGridViewTextBoxColumn PaketSewa;
        private DataGridViewTextBoxColumn Durasi;
        private DataGridViewTextBoxColumn Harga;
        private BindingSource dashboardBindingSource;
        private BindingSource dashboardBindingSource1;
    }
}
