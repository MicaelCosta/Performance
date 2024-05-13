namespace Benchmark.ToString
{
    public class StringWithLiteral
    {
        public string TransformString(long id)
        {
            return $"{id}";
        }
    }
}
