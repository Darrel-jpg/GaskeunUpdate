using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Gaskeun_.Controller;
using Gaskeun_.Helper;
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
    public partial class MobilData : UserControl
    {
        public Cloudinary cloudinary;
        public const string CLOUD_NAME = "dqsnhqpta";
        public const string API_KEY = "415453362647782";
        public const string API_SECRET = "2eO5TB3MKkx_M-AyaA7NOQ9PV_Q";
        public string imagePath;
        public string imageUrl;

        Kendaraan newMobil = new Kendaraan();
        KendaraanControl mobilControl = new KendaraanControl();
        private string platLama;
        private string jenis = "Mobil";
        private int idJenis= KendaraanHelper.ConvertJenisKendaraan("Mobil");

        public MobilData()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = mobilControl.ReadKendaraan(idJenis);
        }

        public Kendaraan GetMobil()
        {
            newMobil.Plat = tbPlat.Text;
            newMobil.Merk = tbMerk.Text;
            newMobil.IdJenisKendaraan = KendaraanHelper.ConvertJenisKendaraan(jenis);
            newMobil.NamaKendaraan = tbNamaMobil.Text;
            newMobil.Tahun = tbTahun.Text;
            newMobil.CC = tbCC.Text;
            newMobil.KapasitasBensin = tbBensin.Text;
            newMobil.Gambar = tbGambar.Text;
            newMobil.HargaHari = decimal.Parse(tbHari.Text);
            newMobil.HargaMinggu = decimal.Parse(tbMinggu.Text);
            newMobil.HargaBulan = decimal.Parse(tbBulan.Text);
            newMobil.Status = KendaraanHelper.ConvertStatus(cbStatus.SelectedItem?.ToString());

            return newMobil;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                tbPlat.Text = row.Cells[0].Value.ToString();
                tbNamaMobil.Text = row.Cells[1].Value.ToString();
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
            bool isSucces = mobilControl.AddKendaraan(GetMobil());

            if (isSucces)
            {
                MessageBox.Show("Mobil berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gagal menambahkan mobil!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mobilControl.ReadKendaraan(idJenis);
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(platLama))
            {
                MessageBox.Show("Plat mobil harus diisi!");
                return;
            }

            if (mobilControl.UpdateKendaraan(GetMobil(), platLama))
            {
                MessageBox.Show("Data mobil berhasil diperbarui!");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = mobilControl.ReadKendaraan(idJenis);
                platLama = null;

                ClearForm();
            }
            else
            {
                MessageBox.Show("Gagal memperbarui data mobil!");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (mobilControl.DeleteKendaraan(GetMobil()))
            {
                MessageBox.Show("Data mobil berhasil dihapus!");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = mobilControl.ReadKendaraan(idJenis);
            }
            else
            {
                MessageBox.Show("Gagal menghapus data mobil!");
            }
        }

        private void ClearForm()
        {
            tbNamaMobil.Text = "";
            tbMerk.Text = "";
            tbTahun.Text = "";
            tbPlat.Text = "";
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
                image.Image = null;
                return;
            }

            try
            {
                using var wc = new System.Net.WebClient();
                byte[] imageBytes = await wc.DownloadDataTaskAsync(url);

                using var ms = new System.IO.MemoryStream(imageBytes);
                Image img = Image.FromStream(ms);

                image.Image = img;
            }
            catch
            {
                image.Image = null;
            }
        }

        private void MobilData_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[1].Width = 150; // Lebar kolom NamaKendaraan
            dataGridView1.Columns[4].Width = 100; // Lebar kolom CC
            dataGridView1.Columns[6].Width = 100; // Lebar kolom Gambar
            dataGridView1.Columns[8].Width = 160; // Lebar kolom HargaMinggu
        }

        //Cloudinarystorage setup dan image upload
        private void cloudinaryStorage()
        {
            Account account = new Account(CLOUD_NAME, API_KEY, API_SECRET);
            cloudinary = new Cloudinary(account);
            imageUrl = uploadImage(imagePath);
        }
        private string uploadImage(string path)
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(path),
            };
            var uploadResult = cloudinary.Upload(uploadParams);
            return uploadResult.SecureUrl.ToString();
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image |*.jpg;*.jpeg;*.png";
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                image.Image = new Bitmap(dlg.FileName);
                imagePath = dlg.FileName;
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            cloudinaryStorage();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tbGambar.Text = imageUrl;
            image.Load(imageUrl);
            MessageBox.Show("Gambar berhasil diupload!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
