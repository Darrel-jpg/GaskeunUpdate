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
    public partial class RiwayatTransaksi : UserControl
    {
        RiwayatControl riwayatControl = new RiwayatControl();
        public RiwayatTransaksi()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = riwayatControl.ReadTransaksi();
        }

        private void TransaksiPelanggan_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[1].Width = 175; // Lebar kolom JenisKendaraan
            dataGridView1.Columns[2].Width = 190; // Lebar kolom NamaKendaraan
            dataGridView1.Columns[4].Width = 140; // Lebar kolom TanggalKembali
            dataGridView1.Columns[5].Width = 195; // Lebar kolom TanggalKeterlambatan
        }
    }
}
