using System.Text.RegularExpressions;

namespace Benchmark.Email
{
    public class EmailValidatorWithRegexCompiled
    {
        static Regex _regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.Compiled);

        public bool IsValid(string email)
        {
            return _regex.Match(email).Success;
        }
    }
}
