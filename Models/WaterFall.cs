using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water.Models
{
    internal class WaterFall : WaterBody
    {
        public int Height { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Id: {Id} , Waterfall: {Name} , Depth: {Depth}, Height: {Height}");
        }
    }
}