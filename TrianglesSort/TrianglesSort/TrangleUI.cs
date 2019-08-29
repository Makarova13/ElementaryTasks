using TasksHelper;

namespace TrianglesSort
{
    class TrangleUI
    {
        const int NUMBER_OF_SIDES = 3;

        public static bool GetTriangle(out string name, out int[] sides)
        {
            ConsoleUI.ShowMessage(StrConsts.INPUT_TRIANGLE);
            string[] triangle = ConsoleUI.ReadLine(',');
            name = triangle[0];
            int beginInStringFrom = 1;

            return triangle.GetInt(NUMBER_OF_SIDES, beginInStringFrom, out sides); 
        }
    }
}
