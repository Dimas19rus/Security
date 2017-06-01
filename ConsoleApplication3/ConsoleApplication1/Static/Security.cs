using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class Security
    {
        public static List<IDopusk> Dopusk { get; set; } = new List<IDopusk>();

        public static void Propusk(INumericObject o )
        {
            if (o is IDopusk)
            {
                Dopusk.Add((IDopusk)o);
            }
        }

        public static void InfoDopusk()
        {
            Console.WriteLine("Список пропущенных:");
            foreach (var d in Dopusk)
                Console.WriteLine("\t" + ((INumericObject)d).Name);               
        }
    }
}
