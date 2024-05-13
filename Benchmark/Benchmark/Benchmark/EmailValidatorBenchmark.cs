using Benchmark.Email;
using BenchmarkDotNet.Attributes;

namespace Benchmark.Benchmark
{
    [MemoryDiagnoser]//Ajuda a analisar a memória
    public class EmailValidatorBenchmark
    {    
        [Benchmark(Baseline = true)]//Baseline => trata o metodo como o base para comparar com outros
        public void EmailValidatorWithRegex()
        {
            EmailValidatorWithRegex validator = new EmailValidatorWithRegex();

            validator.IsValid("teste@gmail.com");
        }

        [Benchmark]
        public void EmailValidatorWithRegexCompiled()
        {
            EmailValidatorWithRegexCompiled validator = new EmailValidatorWithRegexCompiled();

            validator.IsValid("teste@gmail.com");
        }

        [Benchmark]
        public void EmailValidatorSimple()
        {
            EmailValidatorSimple validator = new EmailValidatorSimple();

            validator.IsValid("teste@gmail.com");
        }
    }
}
