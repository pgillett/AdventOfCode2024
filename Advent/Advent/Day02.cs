using System;
using System.Linq;

namespace Advent;

public class Day02
{
    public int Part1(string input)
    {
        var reports = input.IntoLines()
            .Select(l => l.Split(" ").Select(int.Parse).ToArray());

        var totalSafe = 0;
        foreach (var report in reports)
        {
            var dir = 0;
            var safe = true;
            for (var i = 0; i < report.Length - 1; i++)
            {
                var diff = report[i + 1] - report[i];
                if (diff is 0 or > 3 or < -3)
                {
                    safe = false;
                    break;
                }
                if (dir == 0)
                {
                    dir = Math.Sign(diff);
                }
                else if (dir != Math.Sign(diff))
                {
                    safe = false;
                    break;
                }
            }
            
            if (safe)
            {
                totalSafe++;
            }
        }

        return totalSafe;
    }

    public int Part2(string input)
    {
        var reports = input.IntoLines()
            .Select(l => l.Split(" ").Select(int.Parse).ToArray());

        var totalSafe = 0;
        foreach (var report in reports)
        {
            for (var skip = 0; skip < report.Length; skip++)
            {
                var dir = 0;
                var safe = true;
                for (var i = 0; i < report.Length - 2; i++)
                {
                    var diff = report[i + 1 < skip ? i + 1 : i + 2] - report[i < skip ? i : i + 1];
                    if (diff is 0 or > 3 or < -3)
                    {
                        safe = false;
                        break;
                    }

                    if (dir == 0)
                    {
                        dir = Math.Sign(diff);
                    }
                    else if (dir != Math.Sign(diff))
                    {
                        safe = false;
                        break;
                    }
                }

                if (safe)
                {
                    totalSafe++;
                    break;
                }
            }
        }

        return totalSafe;
    }
}