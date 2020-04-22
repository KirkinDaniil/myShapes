using System;
namespace Test.Models
{
    public class Side
    {
        public Point a { get; set; }
        public Point b { get; set; }

        public double GetLength()
        {
            return Math.Abs((a.x - b.x) + (a.y - b.y));
        }

        public static double operator +(Side first, Side second)
        {
            return first.GetLength() + second.GetLength();
        }

        public static double operator +(double first, Side second)
        {
            return first + second.GetLength();
        }

        public static double operator -(Side first, Side second)
        {
            return first.GetLength() - second.GetLength();
        }

        public static double operator -(double first, Side second)
        {
            return first - second.GetLength();
        }

        public override string ToString()
        {
            return a.ToString() + b.ToString();
        }
    }
}
