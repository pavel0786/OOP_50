using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_50.Class
{
    class Circle
    {
        const decimal PI = (decimal)3.1416;
        public decimal radius;
        public decimal GetDiameter()
        {
            return 2 * radius;
        }
        public decimal GetPerimeter()
        {
            return 2 * PI * radius;
        }
        public decimal GetArea()
        {
            return PI * radius * radius;
        }
    }
}
