using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water.Models
{
    internal class Ocean: WaterBody
    {
        public bool HasCoralReefs { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Id: {Id} , Ocean: {Name} , Depth: {Depth}");
        }
    }
}