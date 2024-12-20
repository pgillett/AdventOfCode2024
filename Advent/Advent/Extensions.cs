using System;

namespace Advent;

public static class Extensions
{
    public static string[] IntoLines(this string str) =>
        str.Split('\n', StringSplitOptions.RemoveEmptyEntries);

    public static string[] IntoSections(this string str) =>
        str.Split("\n\n", StringSplitOptions.RemoveEmptyEntries);
}