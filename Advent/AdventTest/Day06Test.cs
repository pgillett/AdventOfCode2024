using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day06Test
{
    private Day06 _day06;

    [TestInitialize]
    public void Setup()
    {
        _day06 = new Day06();
    }

    [TestMethod]
    public void Part1()
    {
        var result = _day06.Part1(_input);
        
        result.Should().Be(41);
    }
    
    [TestMethod]
    public void Part2()
    {
        var result = _day06.Part2(_input);
        
        result.Should().Be(6);
    }

    private string _input = @"....#.....
.........#
..........
..#.......
.......#..
..........
.#..^.....
........#.
#.........
......#...";
}