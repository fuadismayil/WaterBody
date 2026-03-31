using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water.Models
{
    internal class Sea : WaterBody
    {
        public double SaltLevel { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Id: {Id} , Sea: {Name} , Depth: {Depth}, SaltLevel: {SaltLevel}");

        }
    }
}