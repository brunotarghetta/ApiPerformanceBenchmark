// See https://aka.ms/new-console-template for more information
using ApiPerformanceBenchmark;
using BenchmarkDotNet.Running;

Console.WriteLine("Hello, World!");


BenchmarkRunner.Run<BenchmarksWeatherForecast>();
