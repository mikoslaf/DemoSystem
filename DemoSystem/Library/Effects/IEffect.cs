namespace DemoSystem.Library.Effects
{
    internal interface IEffect
    {
        void Render(Graphics graphics, int width, int height, int localFrame, int globalFrame);
    }
}
