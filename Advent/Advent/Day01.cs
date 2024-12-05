using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent;

public class Day01
{
    public int Part1(string input)
    {
        var pairs = Parse(input);
        
        var left = pairs.Select(p => p[0]).OrderBy(i => i).ToArray();
        var right = pairs.Select(p => p[1]).OrderBy(i => i).ToArray();

        return left.Select((t, i) => Math.Abs(right[i] - t)).Sum();
    }

    public int Part2(string input)
    {
        var pairs = Parse(input);
        
        var counts = pairs.GroupBy(p => p[1])
            .ToDictionary(g => g.Key, g => g.Count());
        
        return pairs.Sum(p => p[0] * counts.GetValueOrDefault(p[0], 0));
    }

    public int[][] Parse(string input) => input.IntoLines()
        .Select(l => l.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray())
        .ToArray();
}