using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Advent.Benchmarks;

[MemoryDiagnoser]
public class Day24Benchmark
{
    [Benchmark]
    public void Part1()
    {
        var day = new Day24();
        day.Part1(InputData.Day(24));
    }
    
    [Benchmark]
    public void Part2()
    {
        var day = new Day24();
        day.Part2(InputData.Day(24));
    }
}
