using System.Drawing;
using System.IO;

namespace DemoSystem.Library
{
    internal class ImagePixelMapper
    {
        public static Color[,] MapImageToColors(string imagePath)
        {
               // U¿ywamy FileStream, aby unikn¹æ blokowania pliku
            using var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            using Bitmap bitmap = new Bitmap(stream);
            return MapImageToColors(bitmap);
        }

        public static Color[,] MapImageToColors(Bitmap bitmap)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            Color[,] colorMap = new Color[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    colorMap[x, y] = bitmap.GetPixel(x, y);
                }
            }

            return colorMap;
        }

        public static Dictionary<Point, Color> MapImageToColorDictionary(string imagePath)
        {
            using var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            using Bitmap bitmap = new Bitmap(stream);
            return MapImageToColorDictionary(bitmap);
        }

        public static Dictionary<Point, Color> MapImageToColorDictionary(Bitmap bitmap)
        {
            Dictionary<Point, Color> colorMap = new Dictionary<Point, Color>();

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    colorMap[new Point(x, y)] = bitmap.GetPixel(x, y);
                }
            }

            return colorMap;
        }
    }
}