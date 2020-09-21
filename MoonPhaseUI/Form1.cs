using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MoonPhase
{
    public partial class Form1 : Form
    {
        private bool _playing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbNasaType.Items.Clear();
            cmbNasaType.DataSource = MoonNasaImageHelper.NasaImageConfig;
            cmbNasaType.DisplayMember = "Name";
            cmbNasaType.ValueMember = "Id";
            cmbNasaType.SelectedIndex = 0;
            cmbIncrement.SelectedIndex = 0;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            AddIncrement(cmbIncrement.Text, -1);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            AddIncrement(cmbIncrement.Text, 1);
        }

        private void AddIncrement(string type, int increment)
        {
            if (type == "Day")
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(increment);
            }
            else if (type == "Hour")
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddHours(increment);
            }
            else if (type == "Month")
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(increment);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Go();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Go();
        }

        private void btnSetWallpaper_Click(object sender, EventArgs e)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
            picture.Image.Save(tempPath, System.Drawing.Imaging.ImageFormat.Bmp);
            Wallpaper.Set(tempPath, Wallpaper.Style.Fit);
        }

        private void cmbNasaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Go();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (btnPlay.Text == "▶")
            {
                btnPlay.Text = "■";
                _playing = true;
                while(_playing)
                {
                    Go(true);
                    AddIncrement(cmbIncrement.Text, 1);
                    Application.DoEvents();
                }
            }
            else
            {
                btnPlay.Text = "▶";
                _playing = false;
            }
        }

        private void Go(bool keepCursor = false)
        {
            var type = cmbNasaType.Text;
            var phase = MoonPhase.GetPhase(dateTimePicker1.Value);
            lblStatus.Text = phase.ToString();
            if (!keepCursor)
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            var url = MoonNasaImageHelper.GetMoonImageUrl(type, dateTimePicker1.Value);
            picture.Image = ImageDownload.FromUrl(url);
            lnkPicture.Text = url;
            if (!keepCursor)
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnkPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var sInfo = new ProcessStartInfo(lnkPicture.Text);
            Process.Start(sInfo);
        }
    }
}
