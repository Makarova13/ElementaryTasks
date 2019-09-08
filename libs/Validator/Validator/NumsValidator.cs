namespace Validator
{
    public class NumsValidator: INumsValidator
    {
        public bool IsPositive(double a)
        {
            return a >= 0.0;
        }
    }
}
