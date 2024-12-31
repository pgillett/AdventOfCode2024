using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent;

public class Day14
{
    public int Part1(string input, int width = 101, int height = 103)
    {
        var robots = input.IntoLines()
            .Select(ParseRobot).ToArray();

        var pos = new List<(int x, int y)>();

        foreach (var robot in robots)
        {
            var x = robot.p.x + robot.v.x * 100;
            var y = robot.p.y + robot.v.y * 100;

            x = x % width;
            y = y % height;

            if (x < 0) x += width;
            if (y < 0) y += height;

            pos.Add((x, y));
        }

        var q1 = pos.Count(r => r.x < (width - 1) / 2 && r.y < (height - 1) / 2);
        var q2 = pos.Count(r => r.x > (width - 1) / 2 && r.y < (height - 1) / 2);
        var q3 = pos.Count(r => r.x < (width - 1) / 2 && r.y > (height - 1) / 2);
        var q4 = pos.Count(r => r.x > (width - 1) / 2 && r.y > (height - 1) / 2);

        return q1 * q2 * q3 * q4;
    }

    public ((int x, int y) p, (int x, int y) v) ParseRobot(string line)
    {
        var split = line.Split('=', ',', ' ');
        return ((int.Parse(split[1]), int.Parse(split[2])),
            (int.Parse(split[4]), int.Parse(split[5])));
    }

    public int Part2(string input, int width = 101, int height = 103)
    {
        var robots = input.IntoLines()
            .Select(ParseRobot).ToArray();

        var bestI = 0;
        var bestCount = 0;

        var pos = new HashSet<(int x, int y)>();

        for (var i = 0; i < width * height; i++)
        {
            pos.Clear();
            
            foreach (var robot in robots)
            {
                var x = robot.p.x + robot.v.x * i;
                var y = robot.p.y + robot.v.y * i;

                x = x % width;
                y = y % height;

                if (x < 0) x += width;
                if (y < 0) y += height;

                pos.Add((x, y));
            }

            var count = 0;
            var step = robots.Length;
            foreach (var p in pos)
            {
                step--;
                if (pos.Contains((p.x + 1, p.y)))
                    count++;
                if (step + count < bestCount)
                    break;
            }

            if (count > bestCount)
            {
                bestCount = count;
                bestI = i;
            }
        }

        return bestI;
    }
}