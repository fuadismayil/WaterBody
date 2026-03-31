using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water.Models
{
    internal class River: WaterBody
    {
        public int FlowSpeed { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Id: {Id} , River: {Name} , Depth: {Depth}, Flow Speed: {FlowSpeed}");

        }
    }
}