
namespace DemoSystem.Library.Effects
{
    internal class GrowingCircle : IEffect
    {
        private Brush _brush = Brushes.Blue;
        private int _xOffSet;
        private int _yOffSet;

        public GrowingCircle(Brush brush, int xOffSet = 0, int yOffset = 0)
        {
            _brush = brush;
            _xOffSet = xOffSet;
            _yOffSet = yOffset;
        }
        public void Render(Graphics g, int width, int height, int localFrame, int GlobalFrame)
        {
             g.FillEllipse(
                _brush,
                (_xOffSet + width) / 2 - localFrame,
                (_yOffSet + height) / 2 - localFrame,
                localFrame * 2,
                localFrame * 2
                );;
        }
    }
}
