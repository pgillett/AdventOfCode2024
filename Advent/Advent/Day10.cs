using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent;

public class Day10
{
    public int Part1(string input)
    {
        var map = input.IntoLines();
        var maxX = map[0].Length;
        var maxY = map.Length;
        
        var zerosList = new List<(int x, int y)>();
        
        for (var y = 0; y < maxY; y++)
        for (var x = 0; x < maxX; x++)
        {
            if (map[y][x] == '0')
            {
                zerosList.Add((x, y));
            }
        }

        var zeros = zerosList.ToDictionary(z => z, _ => new HashSet<(int x, int y)>());

        var steps = new Queue<(HashSet<(int x, int y)> set, char step, (int x, int y) pos)>();
        foreach (var zero in zeros)
        {
            steps.Enqueue((zero.Value, '0', zero.Key));         
        }

        while (steps.Count != 0)
        {
            var next = steps.Dequeue();
            var at = map[next.pos.y][next.pos.x];
            if (at == next.step)
            {
                if (at == '9')
                {
                    next.set.Add(next.pos);
                }
                else
                {
                    if (next.pos.x > 0)
                        steps.Enqueue((next.set, (char)(next.step + 1), (next.pos.x - 1, next.pos.y)));
                    if (next.pos.x < (maxX - 1))
                        steps.Enqueue((next.set, (char)(next.step + 1), (next.pos.x + 1, next.pos.y)));
                    if (next.pos.y > 0)
                        steps.Enqueue((next.set, (char)(next.step + 1), (next.pos.x, next.pos.y - 1)));
                    if (next.pos.y < (maxY - 1))
                        steps.Enqueue((next.set, (char)(next.step + 1), (next.pos.x, next.pos.y + 1)));
                }
            }
        }
        
        return zeros.Sum(s => s.Value.Count);
    }

    public int Part2(string input)
    {
        var map = input.IntoLines();
        var maxX = map[0].Length;
        var maxY = map.Length;
        
        var zerosList = new List<(int x, int y)>();
        
        for (var y = 0; y < maxY; y++)
        for (var x = 0; x < maxX; x++)
        {
            if (map[y][x] == '0')
            {
                zerosList.Add((x, y));
            }
        }

        var zeros = zerosList.ToDictionary(z => z, _ => 0);

        var steps = new Queue<((int x, int y) start, char step, (int x, int y) pos)>();
        foreach (var zero in zeros)
        {
            steps.Enqueue((zero.Key, '0', zero.Key));         
        }

        while (steps.Count != 0)
        {
            var next = steps.Dequeue();
            var at = map[next.pos.y][next.pos.x];
            if (at == next.step)
            {
                if (at == '9')
                {
                    zeros[next.start]++;
                }
                else
                {
                    if (next.pos.x > 0)
                        steps.Enqueue((next.start, (char)(next.step + 1), (next.pos.x - 1, next.pos.y)));
                    if (next.pos.x < (maxX - 1))
                        steps.Enqueue((next.start, (char)(next.step + 1), (next.pos.x + 1, next.pos.y)));
                    if (next.pos.y > 0)
                        steps.Enqueue((next.start, (char)(next.step + 1), (next.pos.x, next.pos.y - 1)));
                    if (next.pos.y < (maxY - 1))
                        steps.Enqueue((next.start, (char)(next.step + 1), (next.pos.x, next.pos.y + 1)));
                }
            }
        }
        
        return zeros.Sum(s => s.Value);
    }
}