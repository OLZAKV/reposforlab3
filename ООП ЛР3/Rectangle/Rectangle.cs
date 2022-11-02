using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double AreaCalculator() => side1 * side2;
        private double PerimeterCalculator() => 2 * (side1 + side2);
        
        public double Area
        {
            get => AreaCalculator();
        }
        public double Perimeter
        {
            get => PerimeterCalculator();
        }
    }
}
