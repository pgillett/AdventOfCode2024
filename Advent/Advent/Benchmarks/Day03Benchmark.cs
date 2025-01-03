using BenchmarkDotNet.Attributes;

namespace Advent.Benchmarks;

[MemoryDiagnoser]
public class Day03Benchmark
{
    [Benchmark]
    public void Part1()
    {
        var day = new Day03();
        day.Part1(InputData.Day(3));
    }
    
    [Benchmark]
    public void Part2()
    {
        var day = new Day03();
        day.Part2(InputData.Day(3));
    }
}