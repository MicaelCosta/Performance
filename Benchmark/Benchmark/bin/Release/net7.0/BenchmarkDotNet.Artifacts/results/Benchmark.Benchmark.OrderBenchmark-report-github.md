```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method  | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0    | Allocated | Alloc Ratio |
|-------- |---------:|---------:|---------:|------:|--------:|--------:|----------:|------------:|
| OrderBy | 752.5 μs |  5.71 μs |  5.34 μs |  1.00 |    0.00 | 20.5078 |  84.05 KB |        1.00 |
| ThenBy  | 704.5 μs | 13.18 μs | 14.10 μs |  0.93 |    0.02 | 19.5313 |  81.58 KB |        0.97 |
