using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToAsyncProgramming
{
    public class EnergizerBunny
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int BatteryPercentage { get; set; }

        public override string ToString()
        {
            return "It just keeps going";
        }
    }
}
