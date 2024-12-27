using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day10Test
{
    private Day10 _day10;

    [TestInitialize]
    public void Setup()
    {
        _day10 = new Day10();
    }

    [TestMethod]
    public void Part1()
    {
        var result = _day10.Part1(_input);

        result.Should().Be(1);
    }
    
    [TestMethod]
    public void Part1a()
    {
        var result = _day10.Part1(_input2);

        result.Should().Be(36);
    }

    [TestMethod]
    public void Part2()
    {
        var result = _day10.Part2(_input2);

        result.Should().Be(81);
    }
    
    private string _input = @"0123
1234
8765
9876";
    
    private string _input2 = @"89010123
78121874
87430965
96549874
45678903
32019012
01329801
10456732";
}