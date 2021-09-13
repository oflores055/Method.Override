using System;
namespace Method.Override
{
    public class Cylinders:Engines
    {
        public override void Engine()
        {
            base.Engine();
            Console.WriteLine("Calculatin the number of cylinders your engine has.");
        }
    }
}
