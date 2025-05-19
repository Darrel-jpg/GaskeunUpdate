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
    public partial class UsersData : UserControl
    {
        public UsersData()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            PelangganControl pelangganControl = new PelangganControl();
            dataGridView1.DataSource = pelangganControl.GetAllPelanggan();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                tbUsername.Text = row.Cells[0].Value.ToString();
                tbEmail.Text = row.Cells[1].Value.ToString();
                tbNoHp.Text = row.Cells[2].Value.ToString();
                cbStatus.Text = row.Cells[3].Value.ToString();
            }
        }
        public Pelanggan GetPelanggan()
        {
            Pelanggan newPelanggan = new Pelanggan();

            newPelanggan.Username = tbUsername.Text;
            newPelanggan.Email = tbEmail.Text;
            newPelanggan.NoHp = tbNoHp.Text;
            newPelanggan.Status = cbStatus.SelectedItem?.ToString();

            return newPelanggan;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Pelanggan newPelanggan = GetPelanggan();
            PelangganControl pelangganControl = new PelangganControl();
            if (pelangganControl.UpdatePelanggan(newPelanggan))
            {
                MessageBox.Show("Data pelanggan berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = pelangganControl.GetAllPelanggan();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Gagal memperbarui data pelanggan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            Pelanggan pelanggan = GetPelanggan();
            PelangganControl pelangganControl = new PelangganControl();
            if (pelangganControl.DeletePelanggan(pelanggan))
            {
                MessageBox.Show("Data pelanggan berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = pelangganControl.GetAllPelanggan();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Gagal menghapus data pelanggan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            tbUsername.Text = "";
            tbEmail.Text = "";
            tbNoHp.Text = "";
            cbStatus.Text = "";
        }
    }
}
