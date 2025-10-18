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
            moment1.AddEffect(new GrowingCircle());
            demo.AddMoment(moment1);


            return demo;
        }
    }
}
