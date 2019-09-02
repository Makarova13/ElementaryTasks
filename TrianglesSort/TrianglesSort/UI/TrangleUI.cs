using UserInterface;
using OperationsWithNums;

namespace TrianglesSort
{
    class TriangleUI
    {
        const int NUMBER_OF_SIDES = 3;

        public IUserInterface UI { get; }

        public TriangleUI(IUserInterface ui)
        {
            UI = ui;
        }

        public bool GetTriangle(out string name, out float[] sides)
        {
            UI.ShowMessage(StrConsts.INPUT_TRIANGLE);
            string[] triangle = UI.ReadLine(',');
            name = triangle[0];
            int beginInStringFrom = 1;

            return triangle.GetFloat(NUMBER_OF_SIDES, beginInStringFrom, out sides); 
        }
    }
}
