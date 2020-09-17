using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;

namespace MoonPhase
{
    public class ImageInfo
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string UriFormat { get; set; }
    }

    // Original from https://svs.gsfc.nasa.gov/images/gallery/MoonPhaseandLibration/current_moon.js
    public static class MoonNasaImageHelper
    {
        private const string Domain = "https://svs.gsfc.nasa.gov";
        private static Random _random = new Random();

        public static readonly List<ImageInfo> NasaImageConfig = new List<ImageInfo>()
        {
            new ImageInfo() { Id = 1, Name = "Moon", UriFormat = "{Domain}{Path}frames/730x730_1x1_30p/moon.{ImageNum}.jpg" },
            new ImageInfo() { Id = 2, Name = "Fancy", UriFormat = "{Domain}{Path}frames/5760x3240_16x9_30p/fancy/comp.{ImageNum}.tif" },
            new ImageInfo() { Id = 3, Name = "Plain", UriFormat = "{Domain}{Path}frames/3840x2160_16x9_30p/plain/moon.{ImageNum}.tif" },
            new ImageInfo() { Id = 4, Name = "Globe", UriFormat = "{Domain}{Path}frames/960x960_1x1_30p/globe.{ImageNum}.tif" },
            new ImageInfo() { Id = 5, Name = "Orbit", UriFormat = "{Domain}{Path}frames/1080x1080_1x1_30p/orbit.{ImageNum}.tif" },
            new ImageInfo() { Id = 6, Name = "FancyMini", UriFormat = "{Domain}{Path}frames/3840x2160_16x9_30p/fancy/comp.{ImageNum}.tif" },
            new ImageInfo() { Id = 7, Name = "MoonMini", UriFormat = "{Domain}{Path}frames/216x216_1x1_30p/moon.{ImageNum}.jpg" },
            new ImageInfo() { Id = 8, Name = "PlainMini", UriFormat = "{Domain}{Path}frames/1920x1080_16x9_30p/plain/moon.{ImageNum}.tif" },
        };

        // One image per hour, starting in 0001 for the first hour and until the last hour on the year 
        // Normal year has 8760 images, and leap year has 8784
        private readonly static int[] NImages = new int[] { 8760, 8760, 8760, 8784 };
        private readonly static int MinYear = 2017;
        private readonly static int MaxYear = 2020;
        private readonly static string[] Paths = new string[] 
        { 
          "/vis/a000000/a004500/a004537/",
          "/vis/a000000/a004600/a004604/",
          "/vis/a000000/a004400/a004442/",
          "/vis/a000000/a004700/a004768/" 
        };

        public static Image GetRandomMoonImage(DateTime dt)
        {
            // 1 to 5 (do not include the Mini versions
            var id = _random.Next(1, 6);
            return GetMoonImage(id, dt);
        }

        public static Image GetMoonImage(string name, DateTime dt)
        {
            var id = NasaImageConfig.FirstOrDefault(img => img.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))?.Id ?? 0;
            return GetMoonImage(id, dt);
        }

        public static Image GetMoonImage(int id, DateTime dt)
        {
            int imagenum;
            string path;

            var moon_year = dt.Year;
            if ((moon_year < MinYear) || (moon_year > MaxYear))
            {
                moon_year = MaxYear;
                imagenum = 1;
            }
            else
            {
                var janone = new DateTime(moon_year, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                imagenum = 1 + (int)Math.Round((dt.ToUniversalTime() - janone).TotalMilliseconds / 3600000d);
                if (imagenum > NImages[moon_year - MinYear])
                {
                    imagenum = NImages[moon_year - MinYear];
                }
            }
            path = Paths[moon_year - MinYear];
            
            var imgInfo = NasaImageConfig.FirstOrDefault(img => img.Id == id) ?? NasaImageConfig[0];
            var url = FormatUrl(imgInfo.UriFormat, path, imagenum);
            return DownloadImage(url);
        }

        private static string FormatUrl(string format, string path, int imageNum)
        {
            string imageId = $"{imageNum:0000}";
            return format
                .Replace("{Domain}", Domain)
                .Replace("{Path}", path)
                .Replace("{ImageNum}", imageId.ToString());
        }

        private static Image DownloadImage(string url)
        {
            using (var stream = new WebClient().OpenRead(url))
            {
                return Image.FromStream(stream);
            }
        }
    }
}
