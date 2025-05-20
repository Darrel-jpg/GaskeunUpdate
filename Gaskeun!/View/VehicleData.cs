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
        private string platLama;
        public VehicleData()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            MotorControl motorControl = new MotorControl();
            dataGridView1.DataSource = motorControl.GetAllMotors();
        }

        public Motor GetMotor()
        {
            Motor newMotor = new Motor();

            newMotor.Plat = tbPlat.Text;
            newMotor.NamaMotor = tbNamaMotor.Text;
            newMotor.Merk = tbMerk.Text;
            newMotor.Tahun = tbTahun.Text;
            newMotor.Warna = tbWarna.Text;
            newMotor.Gambar = tbGambar.Text;
            newMotor.HargaPerHari = decimal.Parse(tbHari.Text);
            newMotor.HargaPerMinggu = decimal.Parse(tbMinggu.Text);
            newMotor.HargaPerBulan = decimal.Parse(tbBulan.Text);
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
                tbWarna.Text = row.Cells[4].Value.ToString();
                tbGambar.Text = row.Cells[5].Value.ToString();
                tbHari.Text = row.Cells[6].Value.ToString();
                tbMinggu.Text = row.Cells[7].Value.ToString();
                tbBulan.Text = row.Cells[8].Value.ToString();
                cbStatus.Text = row.Cells[9].Value.ToString();

                platLama = tbPlat.Text;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Motor newMotor = GetMotor();
            MotorControl motorControl = new MotorControl();
            bool isSucces = motorControl.AddMotor(newMotor);

            if (isSucces)
            {
                MessageBox.Show("Motor berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gagal menambahkan motor!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = motorControl.GetAllMotors();

            ClearForm();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(platLama))
            {
                MessageBox.Show("Plat motor harus diisi!");
                return;
            }

            Motor newMotor = GetMotor();
            MotorControl motorControl = new MotorControl();
            if (motorControl.UpdateMotor(newMotor, platLama))
            {
                MessageBox.Show("Data motor berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = motorControl.GetAllMotors();
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
            Motor motor = GetMotor();
            MotorControl motorControl = new MotorControl();
            if (motorControl.DeleteMotor(motor))
            {
                MessageBox.Show("Data motor berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = motorControl.GetAllMotors();
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
            tbWarna.Text = "";
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
    }
}
