```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method              | Mean     | Error   | StdDev  | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|-------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| ListWithoutTracking | 681.6 μs | 9.84 μs | 9.21 μs |  1.00 | 17.5781 |      - |  72.48 KB |        1.00 |
| ListWithTracking    | 685.8 μs | 3.45 μs | 3.23 μs |  1.01 | 17.5781 | 0.9766 |  73.06 KB |        1.01 |
