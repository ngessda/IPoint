using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            IPoint cp = new CustomPoint(3,4);
            Console.WriteLine(cp.PointDistance(1, 2));

            Console.ReadKey();
        }
    }
}
