using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent;

public class Day08
{
    public int Part1(string input)
    {
        var lines = input.IntoLines();

        var locations = new Dictionary<char, List<(int x, int y)>>();

        var maxX = lines[0].Length;
        var maxY = lines.Length;

        for (var y = 0; y < maxY; y++)
        for (var x = 0; x < maxX; x++)
        {
            var c = lines[y][x];
            if (c != '.')
            {
                if (!locations.ContainsKey(c))
                    locations[c] = [];
                locations[c].Add((x, y));
            }
        }

        var antinodes = new HashSet<(int, int)>();
        foreach (var list in locations.Values)
        {
            for(var f = 0; f < list.Count - 1; f++)
            for (var s = f + 1; s < list.Count; s++)
            {
                (int x, int y) vector = (list[s].x - list[f].x, list[s].y - list[f].y);
                (int x, int y) p1 = (list[f].x - vector.x, list[f].y - vector.y);
                (int x, int y) p2 = (list[s].x + vector.x, list[s].y + vector.y);
                if (p1.x >=0 && p1.x < maxX && p1.y >= 0 && p1.y < maxY)
                    antinodes.Add(p1);
                if(p2.x >=0 && p2.x < maxX && p2.y >= 0 && p2.y < maxY)
                    antinodes.Add(p2);
            }
        }

        return antinodes.Count;
    }

    public int Part2(string input)
    {
        var lines = input.IntoLines();

        var locations = new Dictionary<char, List<(int x, int y)>>();

        var maxX = lines[0].Length;
        var maxY = lines.Length;

        for (var y = 0; y < maxY; y++)
        for (var x = 0; x < maxX; x++)
        {
            var c = lines[y][x];
            if (c != '.')
            {
                if (!locations.ContainsKey(c))
                    locations[c] = [];
                locations[c].Add((x, y));
            }
        }

        var antinodes = new HashSet<(int, int)>();
        foreach (var list in locations.Values)
        {
            for(var f = 0; f < list.Count - 1; f++)
            for (var s = f + 1; s < list.Count; s++)
            {
                (int x, int y) vector = (list[s].x - list[f].x, list[s].y - list[f].y);
                antinodes.Add(list[f]);

                for (var i = 1;; i++)
                {
                    (int x, int y) p = (list[f].x - i * vector.x, list[f].y - i * vector.y);
                    if (p.x < 0 || p.x >= maxX || p.y < 0 || p.y >= maxY)
                        break;
                    antinodes.Add(p);
                }
                
                for (var i = 1;; i++)
                {
                    (int x, int y) p = (list[f].x + i * vector.x, list[f].y + i * vector.y);
                    if (p.x < 0 || p.x >= maxX || p.y < 0 || p.y >= maxY)
                        break;
                    antinodes.Add(p);
                }
            }
        }

        return antinodes.Count;
    }
}