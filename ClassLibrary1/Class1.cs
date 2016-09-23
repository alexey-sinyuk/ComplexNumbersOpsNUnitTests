using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Complex
    {
        public double x;
        public double y;

        public Complex (double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            
        }
        
    }

    public class Operations
    {

        public static Boolean IsEqual (Complex a, Complex b)
        {
            return (a.x == b.x) && (a.y == b.y);
        }

        public static Complex Add (Complex a, Complex b)
        {
            return new Complex(a.x + b.x, a.y + b.y);
        }

        public static Complex Sub (Complex a, Complex b)
        {
            return new Complex(a.x - b.x, a.y - b.y);
        }

        public static Complex Mul (Complex a, Complex b)
        {
            return new Complex((a.x * b.x - a.y*b.y), (a.y * b.x + a.x * b.y));
        }

        public static Complex Div(Complex a, Complex b)
        {
            if ((b.x == 0)&&(b.y == 0))
            {
                System.Console.WriteLine("Division by zero!");
                return null;
            }
            else
            {
                return new Complex((a.x * b.x + a.y * b.y)/(b.x * b.x + b.y * b.y),
                    (a.y * b.x - a.x * b.y) / (b.x * b.x + b.y * b.y));
            }
        }
    }
}
