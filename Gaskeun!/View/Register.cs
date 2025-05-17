using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gaskeun_.View
{
    public partial class Register : Form
    {
        Models.PelangganContext pelangganContext;
        public Register()
        {
            InitializeComponent();
            pelangganContext = new Models.PelangganContext();

            tbPassword.PasswordChar = '*';
            tbConfirm.PasswordChar = '*';

            tbUsername.KeyDown += TbUsername_KeyDown;
            tbEmail.KeyDown += TbEmail_KeyDown;
            tbNoHp.KeyDown += TbNoHp_KeyDown;
            tbPassword.KeyDown += TbPassword_KeyDown;
            tbConfirm.KeyDown += TbConfirm_KeyDown;
        }

        private bool isPasswordVisible1 = false;
        private bool isPasswordVisible2 = false;
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (isPasswordVisible1)
            {
                tbPassword.PasswordChar = '*';
                button3.Image = Properties.Resources.icons8_closed_eye_26;
                isPasswordVisible1 = false;
            }
            else
            {
                tbPassword.PasswordChar = '\0';
                button3.Image = Properties.Resources.icons8_eye_26;
                isPasswordVisible1 = true;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible2)
            {
                tbConfirm.PasswordChar = '*';
                button4.Image = Properties.Resources.icons8_closed_eye_26;
                isPasswordVisible2 = false;
            }
            else
            {
                tbConfirm.PasswordChar = '\0';
                button4.Image = Properties.Resources.icons8_eye_26;
                isPasswordVisible2 = true;
            }
        }
        private void TbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbEmail.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void TbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbNoHp.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void TbNoHp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void TbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbConfirm.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void TbConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Models.Pelanggan GetPelanggan()
        {
            Models.Pelanggan newPelanggan = new Models.Pelanggan();
            newPelanggan.Username = tbUsername.Text.Trim();
            newPelanggan.Email = tbEmail.Text.Trim();
            newPelanggan.NoHp = tbNoHp.Text.Trim();
            newPelanggan.Password = tbPassword.Text.Trim();

            return newPelanggan;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text.Trim()))
            {
                MessageBox.Show("Username tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsername.Text = "";
                tbUsername.Focus();
                return;
            }

            if (!tbEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email harus menggunakan domain @gmail.com", "Validasi Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEmail.Focus();
                return;
            }

            if (!tbNoHp.Text.All(char.IsDigit))
            {
                MessageBox.Show("Nomor HP hanya boleh berisi angka", "Validasi Nomor HP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNoHp.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tbPassword.Text.Trim()))
            {
                MessageBox.Show("Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPassword.Text = "";
                tbPassword.Focus();
                return;
            }

            if (tbConfirm.Text != tbPassword.Text)
            {
                MessageBox.Show("Konfirmasi Password tidak sama", "Validasi Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbConfirm.Text = "";
                tbConfirm.Focus();
                return;
            }

            Models.Pelanggan newPelanggan = GetPelanggan();
            bool isSuccess = pelangganContext.Insert(newPelanggan);

            if (isSuccess)
            {
                MessageBox.Show("Pendaftaran berhasil! Silahkan Login", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 login = new Form1();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Pendaftaran gagal, coba lagi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Image img = Properties.Resources.Free_Vector___Abstract_background_gradient_colorful_design;
            e.Graphics.DrawImage(img, new Rectangle(0, 0, panel1.Width, panel1.Height));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
