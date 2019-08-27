using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TrianglesSort
{
    class Triangle : IComparable
    {
        public Triangle(string name, double x, double y, double z)
        {
            Side1 = x;
            Side2 = y;
            Side3 = z;
            Name = name;
        }

        #region properties

        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public string Name { get; set; }

        public double Square
        {
            get
            {
                return HeronArea(Side1, Side2, Side3);
            }
        }

        public double Perimeter
        {
            get
            {
                return Side1 + Side2 + Side3;
            }
        }

        #endregion

        public static double HeronArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2.0;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static bool IsTriangleExists(double a, double b, double c)
        {
            return ((a + b > c) && (b + c > a) && (a + c) > b);
        }

        public int CompareTo(object obj)
        {
            if (obj is Triangle)
            {
                Triangle tr = (Triangle)obj;
                return Square.CompareTo(tr.Square);
            }
            else
            {
                throw new Exception();
            }
        }

        public override string ToString()
        {
            string triangleStr = string.Format("Name: {0}, Area: {1}", Name, Square);
            return triangleStr;
        }
    }
}
