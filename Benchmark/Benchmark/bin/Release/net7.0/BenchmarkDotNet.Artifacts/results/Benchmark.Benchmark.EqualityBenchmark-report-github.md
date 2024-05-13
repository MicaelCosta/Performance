```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method               | Mean     | Error    | StdDev   | Ratio | Gen0   | Allocated | Alloc Ratio |
|--------------------- |---------:|---------:|---------:|------:|-------:|----------:|------------:|
| EqualityWithAny      | 91.54 ns | 0.962 ns | 0.853 ns |  1.00 | 0.0612 |     256 B |        1.00 |
| EqualityWithContains | 44.11 ns | 0.912 ns | 1.085 ns |  0.49 | 0.0306 |     128 B |        0.50 |
