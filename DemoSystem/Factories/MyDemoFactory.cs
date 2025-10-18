using DemoSystem.Library;
using DemoSystem.Library.Effects;

namespace DemoSystem.Factories
{
    internal class MyDemoFactory : IDemoFactory
    {
        public Demo CreateDemo()
        {
            Demo demo = new();

            var moment1 = new Moment(120);
            moment1.AddEffect(effect: new GrowingCircle(Brushes.Blue));
            moment1.AddEffect(effect: new GrowingCircle(Brushes.Red, xOffSet: -100, yOffset: -100));

            demo.AddMoment(moment1);

            var moment2 = new Moment(120);
            moment2.AddEffect(effect: new GrowingCircle(Brushes.Green));
            demo.AddMoment(moment2);


            return demo;
        }
    }
}
