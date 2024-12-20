using BenchmarkDotNet.Attributes;

namespace Advent.Benchmarks;

[MemoryDiagnoser]
public class Day21Benchmark
{
    [Benchmark]
    public void Part1()
    {
        var day = new Day21();
        day.Part1(InputData.Day(21));
    }
    
    [Benchmark]
    public void Part2()
    {
        var day = new Day21();
        day.Part2(InputData.Day(21));
    }
}
