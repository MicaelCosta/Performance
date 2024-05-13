namespace Benchmark.Strings
{
    public class StringCompareWithComparison
    {
        public bool IsValid(string first, string second)
        {
            return string.Equals(first, second, StringComparison.OrdinalIgnoreCase);
        }
    }
}
