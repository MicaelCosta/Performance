```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method                          | Mean        | Error     | StdDev     | Ratio | Gen0   | Allocated | Alloc Ratio |
|-------------------------------- |------------:|----------:|-----------:|------:|-------:|----------:|------------:|
| EmailValidatorWithRegex         | 4,687.98 ns | 90.651 ns | 117.871 ns | 1.000 | 1.5945 |    6672 B |        1.00 |
| EmailValidatorWithRegexCompiled |   226.90 ns |  4.565 ns |   6.832 ns | 0.048 | 0.1147 |     480 B |        0.07 |
| EmailValidatorSimple            |    39.33 ns |  0.402 ns |   0.357 ns | 0.008 | 0.0191 |      80 B |        0.01 |
