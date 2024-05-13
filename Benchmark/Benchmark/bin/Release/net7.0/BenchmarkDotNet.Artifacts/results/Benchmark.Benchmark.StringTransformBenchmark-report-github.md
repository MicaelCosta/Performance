```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method             | Mean      | Error     | StdDev    | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------- |----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| StringWithToString |  9.175 ns | 0.1474 ns | 0.1231 ns |  1.00 |    0.00 | 0.0076 |      32 B |        1.00 |
| StringWithLiteral  | 45.368 ns | 0.3723 ns | 0.3300 ns |  4.95 |    0.06 | 0.0076 |      32 B |        1.00 |
