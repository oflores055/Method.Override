using System;
using System.Collections.Generic;

namespace Method.Override
{
    class Program
    {
        static void Main(string[] args)
        {
            var engines = new List<Engines>();

            engines.Add(new Rpms());
            engines.Add(new Cylinders());
            engines.Add(new PowerOfEngine());

            var vehicle = new Vehicle();
            vehicle.engineStats(engines);
        }
    }
}
