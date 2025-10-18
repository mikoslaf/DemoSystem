using System;

namespace DemoSystem.Library.Effects
{
    internal class Puzzle: IEffect
    {
        private int _size;
        private Color[,] _imageColors;
        private int _imageWidth;
        private int _imageHeight;

        public Puzzle(string imagePath, int size = 7)
        {
            _size = size;
            _imageColors = ImagePixelMapper.MapImageToColors(imagePath);
            _imageWidth = _imageColors.GetLength(0);
            _imageHeight = _imageColors.GetLength(1);
        }

        private Color GetColorFromImage(int x, int y)
        {
            if (x < 0 || x >= _imageWidth || y < 0 || y >= _imageHeight)
            {
                return Color.Gray;
            }
            
            int imgX = x % _imageWidth;
            int imgY = y % _imageHeight;
            return _imageColors[imgX, imgY];
        }

        public void Render(Graphics g, int width, int height, int localFrame, int GlobalFrame)
        {
           
            g.FillRectangles(Brushes.Black, new Rectangle[] { new Rectangle(0, 0, width, height) });
            int columns = width / _size;
            int rows = height / _size;

            int squaresToDraw = Math.Min(localFrame, columns * rows);

            for (int i = 0; i < squaresToDraw; i++)
            {
                int col = i % columns;
                int row = i / columns;

                int x = col * _size;
                int y = row * _size;

                Color pixelColor = GetColorFromImage(col, row);
                Console.WriteLine($"Square [{col}, {row}] at position ({x}, {y}) - Color: R={pixelColor.R}, G={pixelColor.G}, B={pixelColor.B}, A={pixelColor.A}");
                
                using SolidBrush brush = new SolidBrush(pixelColor);
                g.FillRectangle(brush, x, y, _size, _size);
            }
        }
    }
}
