using System.Text.RegularExpressions;

namespace Benchmark.Email
{
    public class EmailValidatorWithRegex
    {
        public bool IsValid(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            return regex.Match(email).Success;
        }
    }
}
