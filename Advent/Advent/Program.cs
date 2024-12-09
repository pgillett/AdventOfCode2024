using System;
using System.Diagnostics;
using Advent.Benchmarks;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace Advent;

class Program
{
    private static Stopwatch _stopwatch;

    private const int From = 4;
    private const int To = 4;

    private static readonly int[,] Times = new int[25, 2];

    private const int Benchmark = 4;

    static void Main(string[] args)
    {
        _stopwatch = new Stopwatch();

        // var config = ManualConfig.Create(DefaultConfig.Instance)
        //     .WithOptions(ConfigOptions.JoinSummary)
        //     .WithOptions(ConfigOptions.DisableLogFile);
        //
        // BenchmarkRunner.Run(new[]
        // {
        //     BenchmarkConverter.TypeToBenchmarks(typeof(Day01Benchmark), config),
        //     BenchmarkConverter.TypeToBenchmarks(typeof(Day02Benchmark), config),
        //     // BenchmarkConverter.TypeToBenchmarks(typeof(Day03Benchmark)),
        //     // BenchmarkConverter.TypeToBenchmarks(typeof(Day04Benchmark)),
        //     // BenchmarkConverter.TypeToBenchmarks(typeof(Day05Benchmark)),
        //     // BenchmarkConverter.TypeToBenchmarks(typeof(Day06Benchmark)),
        // });
        //
        // BenchmarkRunner.Run<ParsingBenchmark>();
        //
        // return;
        //

        if (Benchmark == 0)
        {
            if (IncludeDay(1))
            {
                var day = new Day01();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day01));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day01));
            }
            
            if (IncludeDay(2))
            {
                var day = new Day02();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day02));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day02));
            }
            if (IncludeDay(3))
            {
                var day = new Day03();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day03));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day03));
            }
            if (IncludeDay(4))
            {
                var day = new Day04();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day04));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day04));
            }
            if (IncludeDay(5))
            {
                var day = new Day05();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day05));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day05));
            }
            if (IncludeDay(6))
            {
                var day = new Day06();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day06));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day06));
            }
            if (IncludeDay(7))
            {
                var day = new Day07();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day07));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day07));
            }
            if (IncludeDay(8))
            {
                var day = new Day08();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day08));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day08));
            }
            if (IncludeDay(9))
            {
                var day = new Day09();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day09));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day09));
            }
            if (IncludeDay(10))
            {
                var day = new Day10();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day10));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day10));
            }
            if (IncludeDay(11))
            {
                var day = new Day11();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day11));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day11));
            }
            if (IncludeDay(12))
            {
                var day = new Day12();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day12));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day12));
            }
            if (IncludeDay(13))
            {
                var day = new Day13();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day13));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day13));
            }
            if (IncludeDay(14))
            {
                var day = new Day14();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day14));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day14));
            }
            if (IncludeDay(15))
            {
                var day = new Day15();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day15));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day15));
            }
            if (IncludeDay(16))
            {
                var day = new Day16();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day16));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day16));
            }
            if (IncludeDay(17))
            {
                var day = new Day17();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day17));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day17));
            }
            if (IncludeDay(18))
            {
                var day = new Day18();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day18));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day18));
            }
            if (IncludeDay(19))
            {
                var day = new Day19();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day19));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day19));
            }
            if (IncludeDay(20))
            {
                var day = new Day20();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day20));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day20));
            }
            if (IncludeDay(21))
            {
                var day = new Day21();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day21));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day21));
            }
            if (IncludeDay(22))
            {
                var day = new Day22();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day22));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day22));
            }
            if (IncludeDay(23))
            {
                var day = new Day23();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day23));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day23));
            }
            if (IncludeDay(24))
            {
                var day = new Day24();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day24));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day24));
            }
            if (IncludeDay(25))
            {
                var day = new Day25();
                Console.WriteLine("Part 1 - {0}", day.Part1(InputData.Day25));
                Console.WriteLine("Part 2 - {0}", day.Part2(InputData.Day25));
            }
        }
        else
        {
            switch (Benchmark)
            {
                case 1:
                    BenchmarkRunner.Run<Day01Benchmark>();
                    break;
                case 2:
                    BenchmarkRunner.Run<Day02Benchmark>();
                    break;
                case 3:
                    BenchmarkRunner.Run<Day03Benchmark>();
                    break;
                case 4:
                    BenchmarkRunner.Run<Day04Benchmark>();
                    break;
                case 5:
                    BenchmarkRunner.Run<Day05Benchmark>();
                    break;
                case 6:
                    BenchmarkRunner.Run<Day06Benchmark>();
                    break;
                case 7:
                    BenchmarkRunner.Run<Day07Benchmark>();
                    break;
                case 8:
                    BenchmarkRunner.Run<Day08Benchmark>();
                    break;
                case 9:
                    BenchmarkRunner.Run<Day09Benchmark>();
                    break;
                case 10:
                    BenchmarkRunner.Run<Day10Benchmark>();
                    break;
                case 11:
                    BenchmarkRunner.Run<Day11Benchmark>();
                    break;
                case 12:
                    BenchmarkRunner.Run<Day12Benchmark>();
                    break;
                case 13:
                    BenchmarkRunner.Run<Day13Benchmark>();
                    break;
                case 14:
                    BenchmarkRunner.Run<Day14Benchmark>();
                    break;
                case 15:
                    BenchmarkRunner.Run<Day15Benchmark>();
                    break;
                case 16:
                    BenchmarkRunner.Run<Day16Benchmark>();
                    break;
                case 17:
                    BenchmarkRunner.Run<Day17Benchmark>();
                    break;
                case 18:
                    BenchmarkRunner.Run<Day18Benchmark>();
                    break;
                case 19:
                    BenchmarkRunner.Run<Day19Benchmark>();
                    break;
                case 20:
                    BenchmarkRunner.Run<Day20Benchmark>();
                    break;
                case 21:
                    BenchmarkRunner.Run<Day21Benchmark>();
                    break;
                case 22:
                    BenchmarkRunner.Run<Day22Benchmark>();
                    break;
                case 23:
                    BenchmarkRunner.Run<Day23Benchmark>();
                    break;
                case 24:
                    BenchmarkRunner.Run<Day24Benchmark>();
                    break;
                case 25:
                    BenchmarkRunner.Run<Day25Benchmark>();
                    break;
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Day       Part 1    Part 2");
        for (int i = 0; i < 25; i++)
        {
            if (IncludeDay(i + 1, false))
                Console.WriteLine($"{i + 1,-10}{Times[i, 0],5} ms  {Times[i, 1],5} ms");
        }
    }

    static bool IncludeDay(int day, bool header = true)
    {
        if (DateTime.Now < new DateTime(2023, 12, day)) return false;
        
        if (day < From || day > To) return false;

        _stopwatch.Reset();
        _stopwatch.Start();
        if (header)
        {
            Console.WriteLine();
            Console.WriteLine($"DAY {day}");
            Console.WriteLine($"==========");
        }

        return true;
    }

    static void Output(int day, int part, string name, object answer)
    {
        var time = _stopwatch.ElapsedMilliseconds;
        Times[day - 1, part - 1] = (int) time;
        Console.WriteLine($"{time} ms - {name}: {answer}");
        _stopwatch.Reset();
        _stopwatch.Start();
    }
}
