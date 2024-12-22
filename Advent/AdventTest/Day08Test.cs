using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day08Test
{
    private Day08 _day08;

    [TestInitialize]
    public void Setup()
    {
        _day08 = new Day08();
    }

    [TestMethod]
    public void Part1()
    {
        var result = _day08.Part1(_input);
        
        result.Should().Be(14);
    }
    
    [TestMethod]
    public void Part2()
    {
        var result = _day08.Part2(_input);
        
        result.Should().Be(34);
    }

    private string _input = @"............
........0...
.....0......
.......0....
....0.......
......A.....
............
............
........A...
.........A..
............
............";
}