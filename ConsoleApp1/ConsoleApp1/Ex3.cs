using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ex3
    {
        public double DiscountPrice(double price, int int_discount)
        {
            double discount = Convert.ToDouble(int_discount);
            return price - price * discount / 100;
        }
    }
}
