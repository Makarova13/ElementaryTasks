namespace Validator
{
    public interface IArgsValidator
    {
        bool ArgsAreInt(string[] str);
        bool ArgsAreFloat(string[] str);
    }
}
