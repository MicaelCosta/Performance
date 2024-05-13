namespace Benchmark.Strings
{
    public class StringCompareWithEqual
    {
        public bool IsValid(string first, string second)
        {
            return first.ToUpper() == second.ToUpper();
        }
    }
}
