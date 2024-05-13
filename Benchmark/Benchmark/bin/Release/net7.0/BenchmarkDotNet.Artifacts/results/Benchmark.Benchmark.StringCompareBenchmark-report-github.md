```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method                      | Mean      | Error     | StdDev    | Ratio | Gen0   | Allocated | Alloc Ratio |
|---------------------------- |----------:|----------:|----------:|------:|-------:|----------:|------------:|
| StringCompareWithEqual      | 41.495 ns | 0.8440 ns | 1.0975 ns |  1.00 | 0.0076 |      32 B |        1.00 |
| StringCompareWithComparison |  7.957 ns | 0.1829 ns | 0.1711 ns |  0.19 |      - |         - |        0.00 |
