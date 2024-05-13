```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method                  | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------ |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| ConcatWithPlus          | 28.50 ns | 0.603 ns | 0.939 ns |  0.59 |    0.02 | 0.0134 |      56 B |        0.29 |
| ConcatWithLiteral       | 27.03 ns | 0.562 ns | 0.769 ns |  0.56 |    0.02 | 0.0134 |      56 B |        0.29 |
| ConcatWithStringBuilder | 48.53 ns | 0.964 ns | 1.071 ns |  1.00 |    0.00 | 0.0459 |     192 B |        1.00 |
