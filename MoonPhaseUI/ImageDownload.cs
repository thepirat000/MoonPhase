using System.Drawing;
using System.Net;

namespace MoonPhase
{
    public class ImageDownload
    {
        public static Image FromUrl(string url)
        {
            using (var stream = new WebClient().OpenRead(url))
            {
                return Image.FromStream(stream);
            }
        }
    }
}
