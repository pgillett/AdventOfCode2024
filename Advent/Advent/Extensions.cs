using System;

namespace Advent;

public static class Extensions
{
    public static string[] IntoLines(this string str) =>
        str.Split(Environment.NewLine + Environment.NewLine);
}