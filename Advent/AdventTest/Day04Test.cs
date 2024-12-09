using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day04Test
{
    private Day04 _day04;

    [TestInitialize]
    public void Setup()
    {
        _day04 = new Day04();
    }

    [TestMethod]
    public void Part1()
    {
        var result = _day04.Part1(_input);
        
        result.Should().Be(18);
    }
    
    [TestMethod]
    public void Part2()
    {
        var result = _day04.Part2(_input);
        
        result.Should().Be(9);
    }

    private string _input = @"MMMSXXMASM
MSAMXMSMSA
AMXSXMAAMM
MSAMASMSMX
XMASAMXAMM
XXAMMXXAMA
SMSMSASXSS
SAXAMASAAA
MAMMMXMMMM
MXMXAXMASX";
}