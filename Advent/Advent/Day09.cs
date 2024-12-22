using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent;

public class Day09
{
    public long Part1(string input)
    {
        var files = new List<(int id, int length)>();
        var space = new List<int>();

        for (var i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0)
            {
                files.Add((i / 2, input[i] - '0'));
            }
            else
            {
                space.Add(input[i] - '0');
            }
        }

        for (var s = 0; s < space.Count; s++)
        {
            if (space[s] > 0)
            {
                if (space[s] > files[^1].length)
                {
                    files.Insert(s + 1, files[^1]);
                    space.Insert(s + 1, space[s] - files[^1].length);
                    space[s] = 0;
                    files.RemoveAt(files.Count - 1);
                    space.RemoveAt(space.Count - 1);
                }
                else if (space[s] < files[^1].length)
                {
                    files.Insert(s + 1, (files[^1].id, space[s]));
                    files[^1] = (files[^1].id, files[^1].length - space[s]);
                    space[s] = 0;
                    space.Insert(s + 1, 0);
                }
                else
                {
                    files.Insert(s + 1, files[^1]);
                    space.Insert(s + 1, 0);
                    space[s] = 0;
                    files.RemoveAt(files.Count - 1);
                    space.RemoveAt(space.Count - 1);
                }
            }
        }

        var total = 0L;
        var pos = 0;
        foreach (var file in files)
        {
            for (var p = 0; p < file.length; p++)
            {
                total += pos * file.id;
                pos++;
            }
        }
        return total;
    }
    
    public long Part2(string input)
    {
        var files = new List<(int id, int length)>();

        for (var i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0)
            {
                files.Add((i / 2, input[i] - '0'));
            }
            else
            {
                files.Add((-1, input[i] - '0'));
            }
        }

        for (var i = input.Length / 2; i > 0; i--)
        {
            var fpos = files.FindIndex(f => f.id == i);
            for (var s = 0; s < fpos; s++)
            {
                if (files[s].id < 0 && files[s].length >= files[fpos].length)
                {
                    if (files[s].length > files[fpos].length)
                    {
                        var l = (-1, files[s].length - files[fpos].length);
                        files[s] = files[fpos];
                        files[fpos] = (-1, files[fpos].length);
                        files.Insert(s + 1, l);
                    }
                    else
                    {
                        files[s] = files[fpos];
                        files[fpos] = (-1, files[s].length);
                    }

                    break;
                }
            }
        }

        var total = 0L;
        var pos = 0;
        foreach (var file in files)
        {
            for (var p = 0; p < file.length; p++)
            {
                if (file.id > 0)
                    total += pos * file.id;
                pos++;
            }
        }
        return total;
    }
}