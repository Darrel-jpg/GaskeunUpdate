using Gaskeun_.Controller;
using Gaskeun_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaskeun_.View
{
    public partial class VehicleData : UserControl
    {
        KendaraanContext kendaraanContext;
        Kendaraan newMotor = new Kendaraan();
        KendaraanControl motorControl = new KendaraanControl();
        private string platLama;
        private string jenis = "Motor";
        public VehicleData()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = motorControl.ReadKendaraan(jenis);
        }

        public Kendaraan GetMotor()
        {
            newMotor.Plat = tbPlat.Text;
            newMotor.JenisKendaraan = jenis;
            newMotor.NamaKendaraan = tbNamaMotor.Text;
            newMotor.Merk = tbMerk.Text;
            newMotor.Tahun = tbTahun.Text;
            newMotor.CC = tbCC.Text;
            newMotor.KapasitasBensin = tbBensin.Text;
            newMotor.Gambar = tbGambar.Text;
            newMotor.HargaHari = decimal.Parse(tbHari.Text);
            newMotor.HargaMinggu = decimal.Parse(tbMinggu.Text);
            newMotor.HargaBulan = decimal.Parse(tbBulan.Text);
            newMotor.Status = cbStatus.SelectedItem?.ToString();

            return newMotor;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                tbPlat.Text = row.Cells[0].Value.ToString();
                tbNamaMotor.Text = row.Cells[1].Value.ToString();
                tbMerk.Text = row.Cells[2].Value.ToString();
                tbTahun.Text = row.Cells[3].Value.ToString();
                tbCC.Text = row.Cells[4].Value.ToString();
                tbBensin.Text = row.Cells[5].Value.ToString();
                tbGambar.Text = row.Cells[6].Value.ToString();
                tbHari.Text = row.Cells[7].Value.ToString();
                tbMinggu.Text = row.Cells[8].Value.ToString();
                tbBulan.Text = row.Cells[9].Value.ToString();
                cbStatus.Text = row.Cells[10].Value.ToString();

                platLama = tbPlat.Text;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            bool isSucces = motorControl.AddKendaraan(GetMotor());

            if (isSucces)
            {
                MessageBox.Show("Motor berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gagal menambahkan motor!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = motorControl.ReadKendaraan(jenis);
            ClearForm();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(platLama))
            {
                MessageBox.Show("Plat motor harus diisi!");
                return;
            }

            //Kendaraan newMotor = GetMotor();
            if (motorControl.UpdateKendaraan(GetMotor(), platLama))
            {
                MessageBox.Show("Data motor berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = motorControl.ReadKendaraan(jenis);
                platLama = null;
                ClearForm();
            }
            else
            {
                MessageBox.Show("Gagal memperbarui data motor!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            //Kendaraan motor = GetMotor();
            if (motorControl.DeleteKendaraan(GetMotor()))
            {
                MessageBox.Show("Data motor berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = motorControl.ReadKendaraan(jenis);
            }
            else
            {
                MessageBox.Show("Gagal menghapus data motor!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            tbPlat.Text = "";
            tbNamaMotor.Text = "";
            tbMerk.Text = "";
            tbTahun.Text = "";
            tbCC.Text = "";
            tbBensin.Text = "";
            tbGambar.Text = "";
            tbHari.Text = "";
            tbMinggu.Text = "";
            tbBulan.Text = "";
            cbStatus.Text = "";
        }

        private async void tbGambar_TextChanged(object sender, EventArgs e)
        {
            string url = tbGambar.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                pictureBox1.Image = null;
                return;
            }

            try
            {
                using var wc = new System.Net.WebClient();
                byte[] imageBytes = await wc.DownloadDataTaskAsync(url);

                using var ms = new System.IO.MemoryStream(imageBytes);
                Image img = Image.FromStream(ms);

                pictureBox1.Image = img;
            }
            catch
            {
                pictureBox1.Image = null;
            }
        }

        private void VehicleData_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[1].Width = 150; // Lebar kolom NamaKendaraan
            dataGridView1.Columns[4].Width = 100; // Lebar kolom CC
            dataGridView1.Columns[6].Width = 100; // Lebar kolom Gambar
            dataGridView1.Columns[8].Width = 160; // Lebar kolom HargaMinggu
        }
    }
}
