using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPoint
{
    public interface IPoint<T>
    {
        double PointDistance(T other);
        void PointTriangle(T p1, T p2);
    }
}
