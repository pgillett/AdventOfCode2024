using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day12Test
{
    private Day12 _day12;

    [TestInitialize]
    public void Setup()
    {
        _day12 = new Day12();
    }

    [TestMethod]
    public void Part1()
    {
        var result = _day12.Part1(_input);
        
        result.Should().Be(140);
    }
    
    [TestMethod]
    public void Part1a()
    {
        var result = _day12.Part1(_input2);
        
        result.Should().Be(1930);
    }

    [TestMethod]
    public void Part2()
    {
        var result = _day12.Part2(_input);
        
        result.Should().Be(80);
    }
    
    [TestMethod]
    public void Part2a()
    {
        var result = _day12.Part2(_input3);
        
        result.Should().Be(368);
    }
    

    private string _input = @"AAAA
BBCD
BBCC
EEEC";

    private string _input2 = @"RRRRIICCFF
RRRRIICCCF
VVRRRCCFFF
VVRCCCJFFF
VVVVCJJCFE
VVIVCCJJEE
VVIIICJJEE
MIIIIIJJEE
MIIISIJEEE
MMMISSJEEE";

    private string _input3 = @"AAAAAA
AAABBA
AAABBA
ABBAAA
ABBAAA
AAAAAA";
}