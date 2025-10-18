using DemoSystem.Factories;
using DemoSystem.Library;

namespace DemoSystem
{
    public partial class DemoSystem : Form
    {
        private Demo _demo;
        public DemoSystem()
        {
            InitializeComponent();

            MyDemoFactory factory = new();

            _demo = factory.CreateDemo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();

        }

        private void DemoSystem_Paint(object sender, PaintEventArgs e)
        {
            _demo.Render(e.Graphics);

        }
    }
}
