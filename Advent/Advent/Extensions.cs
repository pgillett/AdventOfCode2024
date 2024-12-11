using System;

namespace Advent;

public static class Extensions
{
    public static string[] IntoLines(this string str) =>
        str.Split(Environment.NewLine);

    public static string[] IntoSections(this string str) =>
        str.Split(Environment.NewLine + Environment.NewLine);
}