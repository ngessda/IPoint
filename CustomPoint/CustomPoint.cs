using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPoint
{
    class CustomPoint : IPoint<CustomPoint>
    {
        private double x;
        private double y;
        public double X
        {
            get
            {
                return x;
            }
        }
        //public double X => x;
        public double Y
        {
            get
            {
                return y;
            }
        }
        //public double Y => y;
        public CustomPoint()
        {
            x = 0;
            y = 0;
        }
        public CustomPoint(double x1, double y1)
        {
            x = x1;
            y = y1;
        }
        public double PointDistance(CustomPoint other)
        {
            double rX = Math.Pow(X - other.X, 2);
            double rY = Math.Pow(Y - other.Y, 2);
            double result = Math.Round(Math.Sqrt(rX + rY),1);
            return result;
        }
        private double PointDistance(CustomPoint p1, CustomPoint p2)
        {
            double rX = Math.Pow(p1.X - p2.X, 2);
            double rY = Math.Pow(p1.Y - p2.X, 2);
            double result = Math.Sqrt(rX + rY);
            return result;
        }
        public void PointTriangle(CustomPoint p1,CustomPoint p2)
        {
            double pd1 = PointDistance(p1);
            double pd2 = PointDistance(p1, p2);
            double pd3 = PointDistance(p1, p2);
            double sum1 = pd1 + pd2;
            double sum2 = pd2 + pd3;
            double sum3 = pd3 + pd1;
            if (pd1 < sum2 || pd2 < sum3 || pd3 < sum1) 
            {
                Console.WriteLine("Могут.");
            }
            else
            {
                Console.WriteLine("Не могут.");
            }
        }
    }
}
