# ApiPerformanceBenchmark

https://benchmarkdotnet.org/articles/overview.html

`ApiPerformanceBenchmark\ApiToCheckPerformance>dotnet run`

`ApiPerformanceBenchmark\ApiPerformanceBenchmark> dotnet run --configuration Release`

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.1889/21H2/November2021Update)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.400-preview.22301.10
  [Host]     : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2
  Job-MWFBXI : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2

IterationCount=3

|        Method |     Mean |     Error |    StdDev |
|-------------- |---------:|----------:|----------:|
| TryGetWeather | 1.239 ms | 0.7322 ms | 0.0401 ms |

// * Legends *
  Mean   : Arithmetic mean of all measurements
  Error  : Half of 99.9% confidence interval
  StdDev : Standard deviation of all measurements
  1 ms   : 1 Millisecond (0.001 sec)

// ***** BenchmarkRunner: End *****
Run time: 00:00:10 (10.98 sec), executed benchmarks: 1

Global total time: 00:00:14 (14.32 sec), executed benchmarks: 1
// * Artifacts cleanup *
