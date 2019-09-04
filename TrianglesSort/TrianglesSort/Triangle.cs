using System;


namespace TrianglesSort
{
    class Triangle : IComparable<Triangle>
    {
        public Triangle(string name, float x, float y, float z)
        {
            Side1 = x;
            Side2 = y;
            Side3 = z;
            Name = name;
        }

        #region properties

        public float Side1 { get; set; }
        public float Side2 { get; set; }
        public float Side3 { get; set; }
        public string Name { get; set; }

        public float Area
        {
            get
            {
                return HeronArea(Side1, Side2, Side3);
            }
        }

        public float Perimeter
        {
            get
            {
                return Side1 + Side2 + Side3;
            }
        }

        #endregion

        public static float HeronArea(float a, float b, float c)
        {
            float p = (a + b + c) / 2.0;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static bool IsTriangleExist(float a, float b, float c)
        {
            return ((a + b > c) && (b + c > a) && (a + c) > b);
        }

        public int CompareTo(Triangle obj)
        {
            if (!(obj is Triangle))
            {
                throw new FormatException();             
            }
            
            Triangle tr = (Triangle)obj;
            return Area.CompareTo(tr.Area);
        }

        public override string ToString()
        {
            string triangleStr = string.Format("Name: {0}, Area: {1}", Name, Area);
            return triangleStr;
        }
    }
}
