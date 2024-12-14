using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent;

public class Day06
{
    public int Part1(string input)
    {
        var map = input.IntoLines();
        var maxX = map[0].Length;
        var maxY = map.Length;

        (int x, int y) start = (0, 0);
        for(var y = 0; y < maxY; y++)
            for(var x = 0; x < maxX; x++)
            {
                if (map[y][x] == '^')
                {
                    start = (x, y);
                    break;
                }
            }

        var direction = 0;

        var visited = new HashSet<(int x, int y)>();
        visited.Add(start);

        while (true)
        {
            (int x, int y) to = (start.x + _directions[direction].x, start.y + _directions[direction].y);
            if (to.x < 0 || to.x >= maxX || to.y < 0 || to.y >= maxY)
                break;

            if (map[to.y][to.x] == '#')
            {
                direction = (direction + 1) % 4;
                continue;
            }
            
            start = to;
            visited.Add(start);
        }

        return visited.Count;
    }

    private (int x, int y)[] _directions = [(0, -1), (1, 0), (0, 1), (-1, 0)];

    public int Part2(string input) 
    {
        var map = input.IntoLines();
        var maxX = map[0].Length;
        var maxY = map.Length;

        (int x, int y) start = (0, 0);
        for(var y = 0; y < maxY; y++)
        for(var x = 0; x < maxX; x++)
        {
            if (map[y][x] == '^')
            {
                start = (x, y);
                break;
            }
        }

        var direction = 0;

        var visited = new HashSet<(int x, int y)>();

        var pos = start;

        while (true)
        {
            (int x, int y) to = (pos.x + _directions[direction].x, pos.y + _directions[direction].y);
            if (to.x < 0 || to.x >= maxX || to.y < 0 || to.y >= maxY)
                break;

            if (map[to.y][to.x] == '#')
            {
                direction = (direction + 1) % 4;
                continue;
            }
            
            pos = to;
            visited.Add(pos);
        }

        var count = 0;
        foreach (var obs in visited)
        {
            pos = start;
            direction = 0;
            var loop = new HashSet<((int x, int y), int direction)>();
            
            while (true)
            {
                (int x, int y) to = (pos.x + _directions[direction].x, pos.y + _directions[direction].y);
                if (to.x < 0 || to.x >= maxX || to.y < 0 || to.y >= maxY)
                    break;

                if (map[to.y][to.x] == '#' || (to.x == obs.x && to.y == obs.y))
                {
                    direction = (direction + 1) % 4;
                    continue;
                }
            
                pos = to;
                if (loop.Contains((pos, direction)))
                {
                    count++;
                    break;
                }
                loop.Add((pos, direction));
            }
        }

        return count;
    }
}