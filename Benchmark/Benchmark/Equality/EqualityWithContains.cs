namespace Benchmark.Equality
{
    public class EqualityWithContains
    {
        public bool IsValid(List<int> numbers, int number)
        {
            return numbers.Contains(number);
        }
    }
}
