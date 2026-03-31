using Water.Models;

namespace Water
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Models.WaterBody> waterBodies = new List<Models.WaterBody>()
            {
                new Ocean(){ Id = 01, Name = "Pacific", Depth = 4000, HasCoralReefs = true },
                new Ocean(){ Id = 02, Name = "Atlantic", Depth = 3500, HasCoralReefs = false },
                new Ocean(){ Id = 03, Name = "Indian", Depth = 3000, HasCoralReefs = true },
                new Ocean(){ Id = 04, Name = "Arctic", Depth = 2000, HasCoralReefs = false },
                new Ocean(){ Id = 05, Name = "Southern", Depth = 2500, HasCoralReefs = true },
                new Sea(){ Id = 11, Name = "Baltic", Depth = 1500, SaltLevel = 35 },
                new Sea(){ Id = 12, Name = "Black", Depth = 1200, SaltLevel = 30 },
                new Sea(){ Id = 13, Name = "Red", Depth = 1000, SaltLevel = 40 },
                new Sea(){ Id = 14, Name = "Baikal", Depth = 1700, SaltLevel = 25 },
                new River(){ Id = 21, Name = "Nile", Depth = 50, FlowSpeed = 5 },
                new River(){ Id = 22, Name = "Amazon", Depth = 60, FlowSpeed = 7 },
                new River(){ Id = 23, Name = "Kur", Depth = 40, FlowSpeed = 4 },
                new WaterFall(){ Id = 31, Name = "Niagara", Depth = 100, Height = 50 },
                new WaterFall(){ Id = 32, Name = "Victoria", Depth = 120, Height = 80 }
            };

            waterBodies.ForEach(water => water.GetInfo());
            Console.WriteLine();

            for (int i = 0; i < waterBodies.Count; i++)
            {
                if (waterBodies[i] is River river && river.Id == 21)
                {
                    river.Name = "Araz";
                }
                if (waterBodies[i] is Ocean ocean && ocean.Id == 02)
                {
                    ocean.Depth += 500;
                }
                if (waterBodies[i] is Sea sea)
                {
                    sea.SaltLevel -= (int)(sea.SaltLevel * 0.15);
                }
                if (waterBodies[i] is WaterFall waterFall && waterFall.Id == 32)
                {
                    waterFall.Height += 12;
                }
            }
            waterBodies.ForEach(water => water.GetInfo());

        }
    }
}