using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent;

public class Day15
{
    public int Part1(string input)
    {
        var sections = input.IntoSections();
        var map = sections[0].IntoLines()
            .Select(r => r.ToCharArray()).ToArray();

        (int x, int y) pos = (0, 0);
        for(var y=0;y<map.Length;y++)
            for(var x=0;x<map[0].Length;x++)
                if (map[y][x] == '@')
                {
                    map[y][x] = '.';
                    pos = (x, y);
                    break;
                }
        
        var directions = sections[1].Replace("\n", "").Replace("\r","");

        foreach (var d in directions)
        {
            var (dx, dy) = Vector(d);

            (int x, int y) pos2 = (pos.x + dx, pos.y + dy);
            var atMove = map[pos2.y][pos2.x];
            if (atMove == '.')
            {
                pos = pos2;
            }
            else if (atMove != '#')
            {
                var stack = pos2;
                while (true)
                {
                    stack = (stack.x + dx, stack.y + dy);
                    if (map[stack.y][stack.x] == '#')
                        break;
                    if (map[stack.y][stack.x] == '.')
                    {
                        while (stack != pos2)
                        {
                            map[stack.y][stack.x] = 'O';
                            stack = (stack.x - dx, stack.y - dy);
                        }
                        map[pos2.y][pos2.x] = '.';
                        pos = pos2;
                        break;
                    }
                }
            }
        }

        var total = 0;
        for(var y = 0; y<map.Length;y++)
            for(var x = 0;x<map[0].Length;x++)
                if (map[y][x] == 'O')
                    total += 100 * y + x;
        
        return total;
    }

    private (int dx, int dy) Vector(char d) => d switch
    {
        '<' => (-1, 0),
        '>' => (1, 0),
        '^' => (0, -1),
        'v' => (0, 1),
        _ => throw new Exception()
    };

    public int Part2(string input)
    {
        var sections = input.IntoSections();
        var map = sections[0].IntoLines();
        
        var walls = new HashSet<(int x, int y)>();
        var boxes = new HashSet<(int x, int y)>();

        (int x, int y) pos = (0, 0);
        for (var y = 0; y < map.Length; y++)
        for (var x = 0; x < map[0].Length; x++)
        {
            var m = map[y][x]; 
            if (m == '@')
            {
                pos = (x * 2, y);
            }
            else if (m == '#')
            {
                walls.Add((x * 2, y));
                walls.Add((x * 2 + 1, y));
            }
            else if (m == 'O')
            {
                boxes.Add((x * 2, y));
            }
        }

        var directions = sections[1].Replace("\n", "").Replace("\r", "");

        foreach (var d in directions)
        {
            var (dx, dy) = Vector(d);

            (int x, int y) pos2 = (pos.x + dx, pos.y + dy);

            if (!walls.Contains(pos2))
            {
                if (!boxes.Contains(pos2) && !boxes.Contains((pos2.x - 1, pos2.y)))
                {
                    pos = pos2;
                }
                else
                {
                    var boxes2 = boxes.ToHashSet();
                    if (boxes.Contains(pos2))
                    {
                        if (Move(walls, boxes2, pos2, (dx, dy)))
                        {
                            boxes = boxes2;
                            pos = pos2;
                        }
                    }
                    else if (boxes.Contains((pos2.x - 1, pos2.y)))
                    {
                        if (Move(walls, boxes2, (pos2.x - 1, pos2.y), (dx, dy)))
                        {
                            boxes = boxes2;
                            pos = pos2;
                        }
                    }
                }
            }
        }

        return boxes.Sum(box => 100 * box.y + box.x);
    }

    private bool Move(HashSet<(int x, int y)> walls, HashSet<(int x, int y)> boxes, 
        (int x, int y) pos, (int x, int y) vector)
    {
        (int x, int y) pos2 = (pos.x + vector.x, pos.y + vector.y);
        if (walls.Contains(pos2) || walls.Contains((pos2.x + 1, pos2.y))) return false;

        boxes.Remove(pos);

        if (boxes.Contains(pos2) && !Move(walls, boxes, pos2, vector)) return false;
        if (boxes.Contains((pos2.x - 1, pos2.y)) && !Move(walls, boxes, (pos2.x - 1, pos2.y), vector)) return false;
        if (boxes.Contains((pos2.x + 1, pos2.y)) && !Move(walls, boxes, (pos2.x + 1, pos2.y), vector)) return false;

        boxes.Add(pos2);
            
        return true;
    }
    
}