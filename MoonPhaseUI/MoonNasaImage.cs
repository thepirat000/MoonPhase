using System;
using System.Drawing;

namespace MoonPhase
{
    public class MoonNasaImages
    {
        public Uri ImageUri { get; set; }
        public Uri ImageFancyUri { get; set; }

        public Lazy<Image> Image { get { return new Lazy<Image>(DownloadImage); } }
        public Lazy<Image> ImageFancy { get { return new Lazy<Image>(DownloadImageFancy); } } 

        private Image DownloadImage()
        {
            using (var stream = new System.Net.WebClient().OpenRead(ImageUri.ToString()))
            {
                return System.Drawing.Image.FromStream(stream);
            }
        }

        private Image DownloadImageFancy()
        {
            using (var stream = new System.Net.WebClient().OpenRead(ImageFancyUri.ToString()))
            {
                return System.Drawing.Image.FromStream(stream);
            }
        }
    }
    // Original from https://svs.gsfc.nasa.gov/images/gallery/MoonPhaseandLibration/current_moon.js
    public static class MoonNasaImageHelper
    {
        private const string Domain = "https://svs.gsfc.nasa.gov";
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

        public static MoonNasaImages GetMoonImagesUrls(DateTime dt)
        {
            int moon_imagenum;
            string moon_path;

            var moon_year = dt.Year;
            if ((moon_year < MinYear) || (moon_year > MaxYear))
            {
                moon_year = MaxYear;
                moon_imagenum = 1;
            }
            else
            {
                var janone = new DateTime(moon_year, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                moon_imagenum = 1 + (int)Math.Round((dt.GetJavascriptTimeStamp() - janone.GetJavascriptTimeStamp()) / 3600000d);
                if (moon_imagenum > NImages[moon_year - MinYear])
                {
                    moon_imagenum = NImages[moon_year - MinYear];
                }
            }
            moon_path = Paths[moon_year - MinYear];

            string imageId = $"{moon_imagenum:0000}";
            return new MoonNasaImages()
            {
                ImageFancyUri = new Uri($"{Domain}{moon_path}frames/5760x3240_16x9_30p/fancy/comp.{imageId}.tif"),
                ImageUri = new Uri($"{Domain}{moon_path}frames/730x730_1x1_30p/moon.{imageId}.jpg")
            };
        }

        private static long GetJavascriptTimeStamp(this DateTime dt)
        {
            var nineteenseventy = new DateTime(1970, 1, 1);
            var timeElapsed = (dt.ToUniversalTime() - nineteenseventy);
            return (long)(timeElapsed.TotalMilliseconds + 0.5);
        }

    }
}
