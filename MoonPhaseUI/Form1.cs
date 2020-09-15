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

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbNasaType.SelectedIndex = 0;
            cmbIncrement.SelectedIndex = 3;
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
            else if (type == "Minute")
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddMinutes(increment);
            }
            else if (type == "Hour")
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddHours(increment);
            }
            else if (type == "Month")
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(increment);
            }
            else if (type == "Half-Hour")
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddMinutes(30 * increment);
            }
            else if (type == "Quarter-Hour")
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddMinutes(15 * increment);
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

        private void Go()
        {
            var type = cmbNasaType.Text;
            if (type == "Local")
            {
                var phase = MoonPhase.GetPhase(dateTimePicker1.Value);
                picture.Image = phase.Image_North;
                lblStatus.Text = phase.ToString();
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                var img = MoonNasaImageHelper.GetMoonImage(type, dateTimePicker1.Value);
                picture.Image = img;
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnSetWallpaper_Click(object sender, EventArgs e)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
            picture.Image.Save(tempPath, System.Drawing.Imaging.ImageFormat.Bmp);
            Wallpaper.Set(tempPath, Wallpaper.Style.ResizeToFit);
        }

        private void cmbNasaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Go();
        }
    }
}
