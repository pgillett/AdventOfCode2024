using BenchmarkDotNet.Attributes;

namespace Advent.Benchmarks;

[MemoryDiagnoser]
public class Day17Benchmark
{
    [Benchmark]
    public void Part1()
    {
        var day = new Day17();
        day.Part1(InputData.Day(17));
    }
    
    [Benchmark]
    public void Part2()
    {
        var day = new Day17();
        day.Part2(InputData.Day(17));
    }
}
