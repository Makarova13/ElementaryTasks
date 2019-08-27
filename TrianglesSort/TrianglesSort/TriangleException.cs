using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesSort
{
    class TriangleException: ApplicationException
    {
        public TriangleException(string message)
            : base(message)
        {
           
        }
    }
}
