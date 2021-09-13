using System;
using System.Collections.Generic;

namespace Method.Override
{
    public class Vehicle
    {
        public void engineStats(List<Engines> engines)
        {
            foreach(var engine in engines)
            {
                engine.Engine();
            }
        }
    }
}
