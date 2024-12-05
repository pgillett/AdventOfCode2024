using BenchmarkDotNet.Attributes;

namespace Advent.Benchmarks;

[MemoryDiagnoser]
public class Day20Benchmark
{
    [Benchmark]
    public void Part1()
    {
        var day = new Day20();
        day.Part1(InputData.Day20);
    }
    
    [Benchmark]
    public void Part2()
    {
        var day = new Day20();
        day.Part2(InputData.Day20);
    }
}
