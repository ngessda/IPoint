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
            IPoint<CustomPoint> cp = new CustomPoint(3, 5);
            CustomPoint wp = new CustomPoint(4, 6);
            CustomPoint xp = new CustomPoint(3, 7);
            Console.WriteLine(cp.PointDistance(wp));
            cp.PointTriangle(wp, xp);
            Console.ReadKey();
        }
    }
}
