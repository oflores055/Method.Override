using System;
namespace Method.Override
{
    public class PowerOfEngine:Engines
    {
        public override void Engine()
        {
            base.Engine();
            Console.WriteLine("Calculating the power your engine has.");
        }
    }
}
