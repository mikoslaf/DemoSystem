using DemoSystem.Library;

namespace DemoSystem.Factories
{
    internal class MyDemoFactory : IDemoFactory
    {
        public Demo CreateDemo()
        {
            Demo demo = new();

            return demo;
        }
    }
}
