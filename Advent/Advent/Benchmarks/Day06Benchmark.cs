using BenchmarkDotNet.Attributes;

namespace Advent.Benchmarks;

[MemoryDiagnoser]
public class Day06Benchmark
{
    [Benchmark]
    public void Part1()
    {
        var day = new Day06();
        day.Part1(InputData.Day(6));
    }
    
    [Benchmark]
    public void Part2()
    {
        var day = new Day06();
        day.Part2(InputData.Day(6));
    }
}