using System;

namespace Advent;

public static class Extensions
{
    public static string[] IntoLines(this string str) =>
        str.Split(["\n", "\r\n"], StringSplitOptions.RemoveEmptyEntries);

    public static string[] IntoSections(this string str) =>
        str.Split(["\n\n", "\r\n\r\n"], StringSplitOptions.RemoveEmptyEntries);
}