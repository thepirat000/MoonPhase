using MoonPhase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoonPhase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var uris = MoonNasaImageHelper.GetMoonImagesUrls(dateTimePicker1.Value);
            Cursor.Current = Cursors.WaitCursor;
            picture.Image = uris.Image.Value;
            Cursor.Current = Cursors.Default;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GoLocal();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GoLocal();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
        }

        private void GoLocal()
        {
            var phase = MoonPhase.GetPhase(dateTimePicker1.Value);
            picture.Image = phase.Image_North;
            lblStatus.Text = phase.ToString();
        }

        private void btnGoNasaFancy_Click(object sender, EventArgs e)
        {
            var uris = MoonNasaImageHelper.GetMoonImagesUrls(dateTimePicker1.Value);
            Cursor.Current = Cursors.WaitCursor;
            picture.Image = uris.ImageFancy.Value;
            Cursor.Current = Cursors.Default;

        }

        private void btnSetWallpaper_Click(object sender, EventArgs e)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
            picture.Image.Save(tempPath, System.Drawing.Imaging.ImageFormat.Bmp);
            Wallpaper.Set(tempPath, Wallpaper.Style.ResizeToFit);
        }
    }
}
