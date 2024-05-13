namespace Benchmark.Ends
{
    public class EndsWithString
    {
        public bool IsValid(string text)
        {
            return text.EndsWith("/");
        }
    }
}
