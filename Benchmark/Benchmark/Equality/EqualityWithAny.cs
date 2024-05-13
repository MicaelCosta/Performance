namespace Benchmark.Equality
{
    public class EqualityWithAny
    {
        public bool IsValid(List<int> numbers, int number)
        {
            return numbers.Any(a => a == number);
        }
    }
}
