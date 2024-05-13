namespace Benchmark.NameEnum
{
    public class NameEnumWithNameof
    {
        public string GetName(ColorEnum color)
        {
            return nameof(color);
        }
    }
}
