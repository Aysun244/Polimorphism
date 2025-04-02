using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class Program
    {
        static void Main()
        {
            Student student = new Student("Ayla", "Azade");
            Console.WriteLine($"Email:{student .CodeEmail }");
        }
    }
}
