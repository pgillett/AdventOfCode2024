using System;
using System.Linq;

namespace Advent;

public class Day13
{
    public long Part1(string input)
    {
        var games = input.IntoSections()
            .Select(g => new Game(g));

        var total = 0L;
        foreach (var game in games)
        {
            var x = (game.PrizeX - (double)game.BX * game.PrizeY / game.BY) 
                    / (game.AX - (double)game.BX * game.AY / game.BY);
            var pressA = (long)Math.Round(x);
            if (x >= 0 && x <= 100 && Math.Abs(x - pressA) < 0.001)
            {
                if ((game.PrizeX - pressA * game.AX) % game.BX == 0)
                {
                    var pressB = (game.PrizeX - pressA * game.AX) / game.BX;
                    if (pressB >= 0 && pressB <= 100)
                        total += 3 * pressA + pressB;
                }
            }
        }
        
        // 8400 = 94a + 22b
        // 5400 = 34a + 67b
        
        // 67b = 5400 - 34a
        // b = (5400 - 34a) / 67
        
        // 8400 = 94a + 22 (5400 - 34a) / 67
        
        // 8400 = 94a + 22 * 5400 / 67 - 22 * 34a / 67
        // 8400 - 22 * 5400 / 67 = 94a - 22 * 34a / 67
        
        // 8400 - 22 * 5400 / 67 = a(94 - 22 * 34 / 67)
        // (8400 - 22 * 5400 / 67) / (94 - 22 * 34 / 67) = a
        
        return total;
    }

    public long Part2(string input)
    {
        var games = input.IntoSections()
            .Select(g => new Game(g, true));

        var total = 0L;
        foreach (var game in games)
        {
            var x = (game.PrizeX - (double)game.BX * game.PrizeY / game.BY) 
                    / (game.AX - (double)game.BX * game.AY / game.BY);
            var pressA = (long)Math.Round(x);
            if (x >= 0 && Math.Abs(x - pressA) < 0.001)
            {
                if ((game.PrizeX - pressA * game.AX) % game.BX == 0)
                {
                    var pressB = (game.PrizeX - pressA * game.AX) / game.BX;
                    if (pressB >= 0)
                        total += 3 * pressA + pressB;
                }
            }
        }
        
        return total;
    }

    public class Game
    {
        public int AX;
        public int AY;
        public int BX;
        public int BY;
        public long PrizeX;
        public long PrizeY;

        public Game(string input, bool add = false)
        {
            var split = input.IntoLines();
            var ba = split[0].Split('+', ',');
            AX = int.Parse(ba[1]);
            AY = int.Parse(ba[3]);
            var bb = split[1].Split('+', ',');
            BX = int.Parse(bb[1]);
            BY = int.Parse(bb[3]);
            var prize = split[2].Split('=', ',');
            PrizeX = int.Parse(prize[1]);
            PrizeY = int.Parse(prize[3]);

            if (add)
            {
                PrizeX += 10000000000000L;
                PrizeY += 10000000000000L;
            }
        }
    }
}