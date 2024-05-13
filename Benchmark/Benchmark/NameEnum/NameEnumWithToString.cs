namespace Benchmark.NameEnum
{
    public class NameEnumWithToString
    {
        public string GetName(ColorEnum color)
        {
            return color.ToString();
        }
    }
}
