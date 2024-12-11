using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent;

public class Day05
{
    public int Part1(string input)
    {
        var sections = input.IntoSections();

        var rules = sections[0].IntoLines()
            .Select(rule => (int.Parse(rule[..2]), int.Parse(rule[^2..])))
            .GroupBy(rule => rule.Item1)
            .Select(group => (group.Key, group.Select(rule => rule.Item2).ToArray()))
            .ToDictionary(group => group.Key, group => group.Item2);
        
        var updates = sections[1].IntoLines();

        var total = 0;

        foreach (var update in updates)
        {
            var ok = true;

            var pages = update.Split(',').Select(int.Parse).ToArray();
            for(var p1 = 0; p1<pages.Length; p1++)
            {
                var page = pages[p1];
                if (rules.TryGetValue(page, out var rule))
                {
                    for (var p = 0; p < p1; p++)
                    {
                        if (rule.Contains(pages[p]))
                        {
                            ok = false;
                            break;
                        }
                    }
                }
            }

            if (ok)
            {
                var middle = pages[(pages.Length - 1) / 2];
                total += middle;
            }
        }

        return total;
    }

    public int Part2(string input)
    {
        var sections = input.IntoSections();

        var rules = sections[0].IntoLines()
            .Select(rule => (int.Parse(rule[..2]), int.Parse(rule[^2..])))
            .GroupBy(rule => rule.Item1)
            .Select(group => (group.Key, group.Select(rule => rule.Item2).ToArray()))
            .ToDictionary(group => group.Key, group => group.Item2);
        
        var updates = sections[1].IntoLines();

        var total = 0;

        foreach (var update in updates)
        {
            var ok = true;

            var pages = update.Split(',').Select(int.Parse).ToArray();
            
            var sorted = new List<int>();
            foreach (var page in pages)
            {
                if (rules.TryGetValue(page, out var rule))
                {
                    var add = true;
                    for (var p = 0; p < sorted.Count; p++)
                    {
                        if (rule.Contains(sorted[p]))
                        {
                            sorted.Insert(p, page);
                            ok = false;
                            add = false;
                            break;
                        }
                    }
                    if (add)
                        sorted.Add(page);
                }
                else
                {
                    sorted.Add(page);
                }
                
            }

            if (!ok)
            { 
                var middle = sorted[(pages.Length - 1) / 2];
                total += middle;
            }
        }

        return total;    }
}