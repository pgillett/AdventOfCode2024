using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent;

public class Day11
{
    public int Part1(string input)
    {
        var stones = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse);

        for (var i = 0; i < 25; i++)
        {
            var stones2 = new List<long>();
            foreach (var stone in stones)
            {
                if (stone == 0)
                {
                    stones2.Add(1);
                }
                else
                {
                    var digits = Digits(stone);
                    if (digits % 2 == 0)
                    {
                        var split = (int)Math.Pow(10, digits / 2);
                        stones2.Add(stone / split);
                        stones2.Add(stone % split);
                    }
                    else
                    {
                        stones2.Add(stone * 2024);
                    }
                }
            }

            stones = stones2;
        }
        return stones.Count();
    }

    public long Part2(string input)
    {
        var stones = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse);

        var total = new Dictionary<(long, int), long>();

        var allStones = 0L;

        foreach (var stone in stones)
        {
            allStones += ValueFor(total, stone, 75);
        }

        return allStones;
    }

    public long ValueFor(Dictionary<(long, int), long> totals, long stone, int steps)
    {
        if (totals.ContainsKey((stone, steps)))
        {
            return totals[(stone, steps)];
        }

        if (steps == 0) return 1;

        long value;
        if (stone == 0)
        {
            value = ValueFor(totals, 1, steps - 1);
        }
        else
        {
            var digits = Digits(stone);
            if (digits % 2 == 0)
            {
                var split = _powerOfTen[digits / 2];
                //(int)Math.Pow(10, digits / 2);
                value = ValueFor(totals, stone / split, steps - 1) +
                        ValueFor(totals, stone % split, steps - 1);
            }
            else
            {
                value = ValueFor(totals, stone * 2024, steps - 1);
            }
        }

        totals[(stone, steps)] = value;

        return value;
    }

    private long[] _powerOfTen =
    [
        1,
        10,
        100,
        1_000,
        10_000,
        100_000,
        1_000_000,
        10_000_000,
        100_000_000,
        1_000_000_000,
        10_000_000_000,
        100_000_000_000,
        1_000_000_000_000,
        10_000_000_000_000,
        100_000_000_000_000,
        1_000_000_000_000_000,
        10_000_000_000_000_000,
        100_000_000_000_000_000
    ];
    
    private int Digits(long value)
    {

            if (value < 1_000_000)
            {
                if (value < 1_000)
                {
                    if (value < 10) return 1;
                    if (value < 100) return 2;
                    return 3;
                }

                if (value < 10_000) return 4;
                if (value < 100_000) return 5;
                return 6;
            }

            if (value < 1_000_000_000)
            {
                if (value < 10_000_000) return 7;
                if (value < 100_000_000) return 8;
                return 9;
            }

            if (value < 10_000_000_000) return 10;
            if (value < 100_000_000_000) return 11;
            if (value < 1_000_000_000_000)return 12;
        

        if (value < 1_000_000_000_000_000)
        {
            if (value < 10_000_000_000_000) return 13;
            if (value < 100_000_000_000_000) return 14;
            return 15;
        }

        if (value < 10_000_000_000_000_000) return 16;
        if (value < 100_000_000_000_000_000) return 17;
        return 18;
//        return (int)Math.Floor(Math.Log10(Math.Abs(value)) + 1);
    }
}