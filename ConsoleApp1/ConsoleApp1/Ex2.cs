using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ex2
    {
        public const double PI = 3.1415926535897931;
        public double VolumeSphere(double radius)
        {
            return 4 / 3 * PI * Math.Pow(radius, 3);
        }
    }
}
