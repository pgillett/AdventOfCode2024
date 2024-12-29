using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Advent;

public class Day12
{
    public int Part1(string input)
    {
        var map = input.IntoLines();

        var maxX = map[0].Length;
        var maxY = map.Length;

        var seen = new int[maxY, maxX];

        var steps = new Queue<(int x, int y, int i)>();
        var id = 0;
        var sx = 0;
        var sy = 0;

        while (sy < maxY)
        {
            if (seen[sy, sx] != 0)
            {
                sx++;
                if (sx == maxX)
                {
                    sx = 0;
                    sy++;
                }

                continue;
            }

            id++;

            steps.Enqueue((sx, sy, id));

            var c = map[sy][sx];

            while (steps.Count > 0)
            {
                var (x, y, i) = steps.Dequeue();
                if (seen[y, x] != 0) continue;
                if (map[y][x] != c) continue;

                seen[y, x] = i;

                if (x > 0) steps.Enqueue((x - 1, y, i));
                if (x < maxX - 1) steps.Enqueue((x + 1, y, i));
                if (y > 0) steps.Enqueue((x, y - 1, i));
                if (y < maxY - 1) steps.Enqueue((x, y + 1, i));
            }
        }

        var areaPerim = new (int area, int perim)[id + 1];
        
        for (var y = 0; y < maxY; y++)
        for (var x = 0; x < maxX; x++)
        {
            id = seen[y, x];
            var p = 4;
            if (x > 0 && seen[y, x - 1] == id) p -= 2;
            if (y > 0 && seen[y - 1, x] == id) p -= 2;
            var last = areaPerim[id];
            areaPerim[id] = (last.area + 1, last.perim + p);
        }

        return areaPerim.Sum(a => a.area * a.perim);
    }

    public int Part2(string input)
    {
        var map = input.IntoLines();

        var maxX = map[0].Length;
        var maxY = map.Length;

        var seen = new int[maxY, maxX];

        var steps = new Queue<(int x, int y, int i)>();
        var id = 0;
        var sx = 0;
        var sy = 0;

        while (sy < maxY)
        {
            if (seen[sy, sx] != 0)
            {
                sx++;
                if (sx == maxX)
                {
                    sx = 0;
                    sy++;
                }

                continue;
            }

            id++;

            steps.Enqueue((sx, sy, id));

            var c = map[sy][sx];

            while (steps.Count > 0)
            {
                var (x, y, i) = steps.Dequeue();
                if (seen[y, x] != 0) continue;
                if (map[y][x] != c) continue;

                seen[y, x] = i;

                if (x > 0) steps.Enqueue((x - 1, y, i));
                if (x < maxX - 1) steps.Enqueue((x + 1, y, i));
                if (y > 0) steps.Enqueue((x, y - 1, i));
                if (y < maxY - 1) steps.Enqueue((x, y + 1, i));
            }
        }

        var areaSides = new (int area, int sides)[id + 1];
        for (var y = 0; y < maxY; y++)
        for (var x = 0; x < maxX; x++)
        {
            id = seen[y, x];
            var s = 0;
            if (x == 0 || seen[y, x - 1] != id)
            {
                if (y == 0 || seen[y - 1, x] != id || (x > 0 && seen[y - 1, x - 1] == id))
                    s++;
            }

            if (x == maxX - 1 || seen[y, x + 1] != id)
            {
                if (y == 0 || seen[y - 1, x] != id || (x < maxX - 1 && seen[y - 1, x + 1] == id))
                    s++;
            }

            if (y == 0 || seen[y - 1, x] != id)
            {
                if (x == 0 || seen[y, x - 1] != id || (y > 0 && seen[y - 1, x - 1] == id))
                    s++;
            }

            if (y == maxY - 1 || seen[y + 1, x] != id)
            {
                if (x == 0 || seen[y, x - 1] != id || (y < maxY - 1 && seen[y + 1, x - 1] == id))
                    s++;
            }
            var last = areaSides[id];
            areaSides[id] = (last.area + 1, last.sides + s);
        }

        return areaSides.Sum(a => a.area * a.sides);
    }
}