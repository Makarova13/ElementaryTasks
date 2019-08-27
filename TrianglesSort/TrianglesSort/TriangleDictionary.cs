using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesSort
{
    class TriangleDictionary
    {
        public Dictionary<string, Triangle> trDictionary;
      
        public int Count()
        { 
            return trDictionary.Count();
        }

        public TriangleDictionary()
        {
            trDictionary = new Dictionary<string, Triangle>();
        }

        public void AddTriangle(Triangle tr, string name) 
        {
            trDictionary.Add(name, tr);
        }

        public void Sort()  
        {
            trDictionary = trDictionary.OrderBy(pair => pair.Value.Square * -1.0).ToDictionary
                (pair => pair.Key, pair => pair.Value);
        }

        public override string ToString()   //TODO: iterator
        {
            string result = null;
            int counter = 0;
            result += "============= Triangles list: ===============\n";
            foreach (var entry in trDictionary)
            {
                result += ++counter + ". ";
                result += string.Format(entry.Key.ToString() + ": " + entry.Value.Square.ToString());
                result += "\n";
            }

            return result;
        }
    }
}
