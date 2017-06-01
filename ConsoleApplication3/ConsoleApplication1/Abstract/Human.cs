using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Human:INumericObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
    }
}
