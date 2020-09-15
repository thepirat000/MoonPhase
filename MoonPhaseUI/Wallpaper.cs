using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MoonPhase
{
    public sealed class Wallpaper
    {
        Wallpaper() { }

        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public enum Style : int
        {
            Centered = 0,
            Tiled = 1,
            Stretched = 2,
            ResizeToFit = 6,
            ResizeCrop = 10
        }

        public static void Set(Image image, Style style)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "wallpaper.jpg");
            image.Save(tempPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            Set(tempPath, style);
        }

        public static void Set(string filePath, Style style)
        {
            var key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            key.SetValue(@"TileWallpaper", (style == Style.Tiled ? 1 : 0).ToString());
            if (style == Style.Tiled)
            {
                style = Style.Centered;
            }
            key.SetValue(@"WallpaperStyle", ((int)style).ToString());
            
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, filePath, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }
    }
}
