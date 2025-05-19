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
    public partial class MobilData : UserControl
    {
        MobilContext mobilContext;
        private string platLama;
        public MobilData()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            MobilControl mobilControl = new MobilControl();
            dataGridView1.DataSource = mobilControl.ReadMobil();
        }

        public Mobil GetMobil()
        {
            Mobil newMobil = new Mobil();

            newMobil.Plat = tbPlat.Text;
            newMobil.NamaMobil = tbNamaMobil.Text;
            newMobil.Merk = tbMerk.Text;
            newMobil.Tahun = tbTahun.Text;
            newMobil.Warna = tbWarna.Text;
            newMobil.HargaPerHari = decimal.Parse(tbHari.Text);
            newMobil.HargaPerMinggu = decimal.Parse(tbMinggu.Text);
            newMobil.HargaPerBulan = decimal.Parse(tbBulan.Text);
            newMobil.Status = cbStatus.SelectedItem?.ToString();

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
                tbWarna.Text = row.Cells[4].Value.ToString();
                tbHari.Text = row.Cells[5].Value.ToString();
                tbMinggu.Text = row.Cells[6].Value.ToString();
                tbBulan.Text = row.Cells[7].Value.ToString();
                cbStatus.Text = row.Cells[8].Value.ToString();

                platLama = tbPlat.Text;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Mobil newMobil = GetMobil();
            MobilControl mobilControl = new MobilControl();
            bool isSucces = mobilControl.AddMobil(newMobil);

            if (isSucces)
            {
                MessageBox.Show("Mobil berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gagal menambahkan motor!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mobilControl.ReadMobil();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(platLama))
            {
                MessageBox.Show("Plat mobil harus diisi!");
                return;
            }

            Mobil newMobil = GetMobil();
            MobilControl mobilControl = new MobilControl();
            if (mobilControl.UpdateMobil(newMobil, platLama))
            {
                MessageBox.Show("Data mobil berhasil diperbarui!");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = mobilControl.ReadMobil();
                platLama = null;

                ClearForm();
            }
            else
            {
                MessageBox.Show("Gagal memperbarui data motor!");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            Mobil mobil = GetMobil();
            MobilControl mobilControl = new MobilControl();
            if (mobilControl.DeleteMobil(mobil))
            {
                MessageBox.Show("Data mobil berhasil dihapus!");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = mobilControl.ReadMobil();
            }
            else
            {
                MessageBox.Show("Gagal menghapus data motor!");
            }
        }

        private void ClearForm()
        {
            tbNamaMobil.Text = "";
            tbMerk.Text = "";
            tbTahun.Text = "";
            tbPlat.Text = "";
            tbWarna.Text = "";
            tbHari.Text = "";
            tbMinggu.Text = "";
            tbBulan.Text = "";
            cbStatus.Text = "";
        }

    }
}
