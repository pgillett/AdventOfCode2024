using BenchmarkDotNet.Attributes;

namespace Advent.Benchmarks;

[MemoryDiagnoser]
public class Day08Benchmark
{
    [Benchmark]
    public void Part1()
    {
        var day = new Day08();
        day.Part1(InputData.Day08);
    }
    
    [Benchmark]
    public void Part2()
    {
        var day = new Day08();
        day.Part2(InputData.Day08);
    }
}