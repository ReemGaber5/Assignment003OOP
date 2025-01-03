using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment003
{
    public class Circle :ICircle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
            
        }

        public double Area =>Math.PI * Radius * Radius;

        public void DisplayInfo()
        {
            Console.WriteLine($"shape: Circle");
            Console.WriteLine($"Area: {Area:F2}\n");
        }
    }
}
