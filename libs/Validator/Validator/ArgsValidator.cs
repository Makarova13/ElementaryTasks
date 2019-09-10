namespace Validator
{
    public class ArgsValidator: IArgsValidator
    {
        public bool ArgsAreInt(string[] str)
        {
            foreach (string s in str)
            {
                if (!int.TryParse(s, out int a))
                {
                    return false;
                }
            }

            return true;
        }

        public bool ArgsAreFloat(string[] str)
        {
            foreach (string s in str)
            {
                if (!float.TryParse(s, out float a))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
