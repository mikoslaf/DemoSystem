
namespace DemoSystem.Library.Effects
{
    internal class GrowingCircle : IEffect
    {
        public void Render(Graphics g, int width, int height, int localFrame, int GlobalFrame)
        {
            g.FillEllipse(
                Brushes.Blue,
                width / 2 - localFrame,
                height / 2 - localFrame,
                localFrame * 2,
                localFrame * 2
                );
        }
    }
}
