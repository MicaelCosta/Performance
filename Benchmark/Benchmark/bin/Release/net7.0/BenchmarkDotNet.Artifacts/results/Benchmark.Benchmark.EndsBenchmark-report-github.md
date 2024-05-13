```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method         | Mean          | Error      | StdDev     | Median        | Ratio | Allocated | Alloc Ratio |
|--------------- |--------------:|-----------:|-----------:|--------------:|------:|----------:|------------:|
| EndsWithString | 1,226.9581 ns | 24.3383 ns | 46.3061 ns | 1,222.3217 ns | 1.000 |         - |          NA |
| EndsWithChar   |     0.0333 ns |  0.0317 ns |  0.0312 ns |     0.0239 ns | 0.000 |         - |          NA |
