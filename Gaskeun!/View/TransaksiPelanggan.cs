using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gaskeun_.Controller;
using Gaskeun_.Models;
using Gaskeun_.Helper;

namespace Gaskeun_.View
{
    public partial class TransaksiPelanggan : UserControl
    {
        Transaksi dataTransaksi = new Transaksi();
        TransaksiControl transaksiControl = new TransaksiControl();

        public TransaksiPelanggan()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = transaksiControl.ReadTransaksi();
            dtTglKeterlambatan.ShowCheckBox = true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbDenda.Text = row.Cells[8].Value.ToString();
                cbStatus.Text = row.Cells[10].Value.ToString();
            }
        }
        public Transaksi GetTransaksi()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris dulu cuy!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            dataTransaksi.IdTransaksi = Convert.ToInt32(selectedRow.Cells[0].Value);

            if (dtTglKeterlambatan.Checked)
            {
                dataTransaksi.TanggalKeterlambatan = DateOnly.FromDateTime(dtTglKeterlambatan.Value);
            }
            else
            {
                dataTransaksi.TanggalKeterlambatan = DateOnly.MinValue; // 01/01/0001
            }

            dataTransaksi.Denda = Convert.ToDecimal(tbDenda.Text);
            decimal hargaLama = Convert.ToDecimal(selectedRow.Cells[9].Value);
            dataTransaksi.Harga = hargaLama + dataTransaksi.Denda;
            dataTransaksi.Berjalan = TransaksiHelper.ConvertStatusTransaksi(cbStatus.Text);

            return dataTransaksi;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (GetTransaksi() == null)
            {
                return;
            }

            if (transaksiControl.UpdateTransaksi(GetTransaksi()))
            {
                MessageBox.Show("Data transaksi berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = transaksiControl.ReadTransaksi();
            }
            else
            {
                MessageBox.Show("Gagal memperbarui data transaksi!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TransaksiPelanggan_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 190;
            dataGridView1.Columns[4].Width = 140;
            dataGridView1.Columns[5].Width = 195;
            dataGridView1.Columns[6].Width = 90;
            dataGridView1.Columns[8].Width = 90;
            dataGridView1.Columns[10].Width = 128;
        }
    }
}
