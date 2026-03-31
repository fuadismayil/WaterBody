using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water.Models
{
    public abstract class WaterBody
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Depth { get; set; }

        public abstract void GetInfo();
    }
}