using Gaskeun_.Controller;
using Npgsql;

namespace Gaskeun_.View
{
    public partial class Form1 : Form
    {
        AuthLogin authLogin = new AuthLogin();
        public Form1()
        {
            InitializeComponent();

            textBox2.PasswordChar = '*';
            textBox1.KeyDown += TextBox1_KeyDown;
            textBox2.KeyDown += TextBox2_KeyDown;
        }

        private bool isPasswordVisible = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                textBox2.PasswordChar = '*';
                button3.Image = Properties.Resources.icons8_closed_eye_26;
                isPasswordVisible = false;
            }
            else
            {
                textBox2.PasswordChar = '\0';
                button3.Image = Properties.Resources.icons8_eye_26;
                isPasswordVisible = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (authLogin.LoginAdmin(username, password))
            {
                AdminMainForm adminMainForm = new AdminMainForm();
                MessageBox.Show("Login sebagai Admin Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                adminMainForm.ShowDialog();
                this.Close();
            }
            else if (authLogin.LoginPelanggan(username, password))
            {
                MessageBox.Show("Login Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Username atau Password Salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Image img = Properties.Resources.Free_Vector___Abstract_background_gradient_colorful_design;
            e.Graphics.DrawImage(img, new Rectangle(0, 0, panel1.Width, panel1.Height));
        }
    }
}
