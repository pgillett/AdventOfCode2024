using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Advent.Benchmarks;

[MemoryDiagnoser]
public class Day23Benchmark
{
    [Benchmark]
    public void Part1()
    {
        var day = new Day23();
        day.Part1(InputData.Day23);
    }
    
    [Benchmark]
    public void Part2()
    {
        var day = new Day23();
        day.Part2(InputData.Day23);
    }
}
