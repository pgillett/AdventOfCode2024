using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Advent.Benchmarks;

[MemoryDiagnoser]
public class Day25Benchmark
{
    [Benchmark]
    public void Part1()
    {
        var day = new Day25();
        day.Part1(InputData.Day25);
    }
    
    [Benchmark]
    public void Part2()
    {
        var day = new Day25();
        day.Part2(InputData.Day25);
    }
}
