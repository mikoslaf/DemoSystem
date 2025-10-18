using DemoSystem.Library.Effects;

namespace DemoSystem.Library
{
    internal class Moment
    {
        private int _localFrame = 0;
        private int _frameCount = 0;
        private List<IEffect> _effects = [];

        public Moment(int frameCount)
        {
            _frameCount = frameCount;
        }
        public bool Render(Graphics graphics, int width, int height, int globalFrame)
        {
            foreach (IEffect effect in _effects)
            {
                effect.Render(graphics, width, height, _localFrame, globalFrame);
            }

            _localFrame++;
            bool cont = _localFrame < _frameCount;
            if(!cont) _localFrame = 0;
            return cont;
        }

        internal void AddEffect(IEffect effect)
        {
            _effects.Add(effect);
        }
    }
}
