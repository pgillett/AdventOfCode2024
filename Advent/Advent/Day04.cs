using System;
using System.Linq;

namespace Advent;

public class Day04
{
    public int Part1(string input)
    {
        var lines = input.IntoLines();

        var total = 0;
        var maxX = lines[0].Length - 3;
        var maxY = lines.Length - 3;
        
        for (var y = 0; y < lines.Length; y++)
        for (var x = 0; x < lines.Length; x++)
        {
            if (lines[y][x] == 'X')
            {
                for(var dx = x > 2 ? -1 : 0; dx <= (x < maxX ? 1 : 0); dx++)
                    for(var dy = y > 2 ? -1 : 0 ; dy <= (y < maxY ? 1 : 0); dy++)
                        if (dx != 0 || dy != 0)
                        {
                            if (lines[y + dy][x + dx] == 'M' &&
                                lines[y + 2 * dy][x + 2 * dx] == 'A' &&
                                lines[y + 3 * dy][x + 3 * dx] == 'S')
                            {
                                total++;
                            }
                        }
            }
        }
        return total;
    }

    public int Part2(string input)
    {
        var lines = input.IntoLines();

        var total = 0;
        
        for (var y = 1; y < lines.Length - 1; y++)
        for (var x = 1; x < lines.Length - 1; x++)
        {
            if (lines[y][x] == 'A')
            {
                var c1 = lines[y-1][x-1];
                var c2 = lines[y+1][x+1];
                if ((c1 == 'M' && c2 == 'S') || (c1 == 'S' && c2 == 'M'))
                {
                    c1 = lines[y - 1][x + 1];
                    c2 = lines[y + 1][x - 1];
                    if ((c1 == 'M' && c2 == 'S') || (c1 == 'S' && c2 == 'M'))
                        total++;
                }

            }
        }
        return total;
    }
}