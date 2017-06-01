using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Animal:INumericObject
    {
        
        public string Name { get; set; }

        public int Id { get; set; }
    }
}
