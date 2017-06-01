using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Abiturient h = new Abiturient {Name = "Abiturient"};
            Prepod p =new Prepod {Name = "Prepod"};
            Rabotodatel r =new Rabotodatel {Name = "Rabo"};
            Dog dog = new Dog {Name = "Dog"};
            Squirell squirell = new Squirell {Name = "Squirell"};
            Student student =new Student {Name = "Student"};
            List<INumericObject> list = new List<INumericObject> {h,p,r,dog,squirell,student};
            foreach (var o in list)
            {
                Security.Propusk(o);
            }
            Security.InfoDopusk();
            Console.ReadKey();
        }
    }
}
