```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method          | Mean     | Error     | StdDev    | Median   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|---------------- |---------:|----------:|----------:|---------:|------:|--------:|-------:|----------:|------------:|
| LoopWithForeach | 2.354 μs | 0.0466 μs | 0.0887 μs | 2.309 μs |  1.00 |    0.00 | 0.7553 |   3.09 KB |        1.00 |
| LoopWithFor     | 2.191 μs | 0.0259 μs | 0.0242 μs | 2.199 μs |  0.90 |    0.04 | 0.7553 |   3.09 KB |        1.00 |
