using System;
using System.Linq;

namespace Advent;

public class Day03
{
    public int Part1(string input)
    {
        var total = 0;
        var pos = 0;
        while (pos < input.Length - 3)
        {
            if (input[pos] == 'm'
                && input[pos + 1] == 'u'
                && input[pos + 2] == 'l'
                && input[pos + 3] == '('
                && char.IsDigit(input[pos + 4]))
            {
                pos += 4;
                var first = 0;
                while (char.IsDigit(input[pos]))
                {
                    first = first * 10 + input[pos] - '0';
//                    first += input[pos];
                    pos++;
                }

                if (input[pos] == ',' && char.IsDigit(input[pos + 1]))
                {
                    pos += 1;
                    var second = 0;
                    while (char.IsDigit(input[pos]))
                    {
                        second = second * 10 + input[pos] - '0';
//                        second += input[pos];
                        pos++;
                    }

                    if (input[pos] == ')')
                    {
  //                      var multiply = int.Parse(first) * int.Parse(second);
                        total += first * second;
                    }
                }
            }
            else
            {
                pos++;
            }
        }
        
        return total;
    }

    public int Part2(string input)
    {
        var total = 0;
        var enabled = true;
        var pos = 0;
        while (pos < input.Length - 3)
        {
            if (input[pos] == 'd'
                && input[pos + 1] == 'o')
            {
                if (input[pos + 2] == '('
                    && input[pos + 3] == ')')
                {
                    enabled = true;
                    pos += 4;
                    continue;
                }

                if (input[pos + 2] == 'n'
                    && input[pos + 3] == '\''
                    && input[pos + 4] == 't'
                    && input[pos + 5] == '('
                    && input[pos + 6] == ')')
                {
                    enabled = false;
                    pos += 7;
                    continue;  
                }
            }
            if (enabled
                && input[pos] == 'm'
                && input[pos + 1] == 'u'
                && input[pos + 2] == 'l'
                && input[pos + 3] == '('
                && char.IsDigit(input[pos + 4]))
            {
                pos += 4;
                var first = 0;
                while (char.IsDigit(input[pos]))
                {
                    first = first * 10 + input[pos] - '0';
                    pos++;
                }

                if (input[pos] == ',' && char.IsDigit(input[pos + 1]))
                {
                    pos += 1;
                    var second = 0;
                    while (char.IsDigit(input[pos]))
                    {
                        second = second * 10 + input[pos] - '0';
                        pos++;
                    }

                    if (input[pos] == ')')
                    {
                        total += first * second;
                    }
                }
            }
            else
            {
                pos++;
            }
        }
        
        return total;
    }
}