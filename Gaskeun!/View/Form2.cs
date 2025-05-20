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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //private void Form2_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        pictureBox2.Load("https://i.imgur.com/3SQOYnI.png");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Gagal memuat gambar: " + ex.Message);
        //    }
        //}

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            string url = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                pictureBox2.Image = null; // hilangkan gambar kalau kosong
                return;
            }

            try
            {
                using var wc = new System.Net.WebClient();
                byte[] imageBytes = await wc.DownloadDataTaskAsync(url);

                using var ms = new System.IO.MemoryStream(imageBytes);
                Image img = Image.FromStream(ms);

                pictureBox2.Image = img; // set gambar ke picturebox
            }
            catch
            {
                pictureBox2.Image = null; // kalau gagal load gambar, hilangkan gambar
            }
        }
    }
}
