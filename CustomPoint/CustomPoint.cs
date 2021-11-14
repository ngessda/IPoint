using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPoint
{
    class CustomPoint : IPoint
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
        public double PointDistance(double x1, double y1)
        {
            double rX = Math.Pow(x - x1, 2);
            double rY = Math.Pow(y - y1, 2);
            double result = Math.Round(Math.Sqrt(rX + rY),1);
            return result;
        }
        private double PointDistance(double x1, double y1, double x2, double y2)
        {
            double rX = Math.Pow(x1 - x2, 2);
            double rY = Math.Pow(y1 - y2, 2);
            double result = Math.Sqrt(rX + rY);
            return result;
        }
        public void PointTriangle(double x1, double y1, double x2, double y2)
        {
            double pd1 = PointDistance(x1, y1);
            double pd2 = PointDistance(x2, y2);
            double pd3 = PointDistance(x1, y1, x2, y2);
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
    interface IPoint
    {
        double PointDistance(double x1,double y1);
        void PointTriangle(double x1,double y1, double x2, double y2);
    }
}
