using BenchmarkDotNet.Attributes;

namespace Advent.Benchmarks;

[MemoryDiagnoser]
public class Day01Benchmark
{
    [Benchmark]
    public void Part1()
    {
        var day = new Day01();
        day.Part1(InputData.Day(1));
    }
    
    [Benchmark]
    public void Part2()
    {
        var day = new Day01();
        day.Part2(InputData.Day(1));
    }
}