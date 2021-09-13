using System;
namespace Method.Override
{
    public class Rpms:Engines
    {
        public override void Engine()
        {
            base.Engine();
            Console.WriteLine("Calculating the RPM on your engine.");
        }

    }
}
