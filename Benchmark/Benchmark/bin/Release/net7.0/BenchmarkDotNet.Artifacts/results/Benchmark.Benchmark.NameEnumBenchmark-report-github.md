```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method               | Mean       | Error     | StdDev    | Ratio | Gen0   | Allocated | Alloc Ratio |
|--------------------- |-----------:|----------:|----------:|------:|-------:|----------:|------------:|
| NameEnumWithToString | 17.7359 ns | 0.3876 ns | 0.4614 ns | 1.000 | 0.0057 |      24 B |        1.00 |
| NameEnumWithNameof   |  0.0560 ns | 0.0297 ns | 0.0454 ns | 0.003 |      - |         - |        0.00 |
