using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advent;

public class Day07
{
    public long Part1(string input)
    {
        var lines = input.IntoLines();

        var total = 0L;
        
        foreach (var line in lines)
        {
            var split = line.Split(":");
            var answer = long.Parse(split[0]);
            var values = split[1].Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToArray();

            var queue = new Queue<(long current, int step)>();

            queue.Enqueue((values[0], 1));

            while (queue.Count > 0)
            {
                var next = queue.Dequeue();

                var add = next.current + values[next.step];
                var multiply = next.current * values[next.step];
                if (next.step == values.Length - 1)
                {
                    if (add == answer || multiply == answer)
                    {
                        total += answer;
                        break;
                    }
                }
                else
                {
                    if (add <= answer)
                        queue.Enqueue((add, next.step + 1));
                    if (multiply <= answer)
                        queue.Enqueue((multiply, next.step + 1));
                }
            }
        }

        return total;
    }

    public long Part2(string input) 
    {
        var lines = input.IntoLines();

        var total = 0L;
        
        foreach (var line in lines)
        {
            var split = line.Split(":");
            var answer = long.Parse(split[0]);
            var values = split[1].Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToArray();

            var queue = new Queue<(long current, int step)>();

            queue.Enqueue((values[0], 1));

            while (queue.Count > 0)
            {
                var next = queue.Dequeue();

                var add = next.current + values[next.step];
                var multiply = next.current * values[next.step];
                var concat = long.Parse($"{next.current}{values[next.step]}");

                if (next.step == values.Length - 1)
                {
                    if (add == answer || multiply == answer || concat == answer)
                    {
                        total += answer;
                        break;
                    }
                }
                else
                {
                    if (add <= answer)
                        queue.Enqueue((add, next.step + 1));
                    if (multiply <= answer)
                        queue.Enqueue((multiply, next.step + 1));
                    if (concat <= answer)
                        queue.Enqueue((concat, next.step + 1));
                }
            }
        }

        return total;
    }
}