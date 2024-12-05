using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day02Test
{
    private Day02 _day02;

    [TestInitialize]
    public void Setup()
    {
        _day02 = new Day02();
    }

    [TestMethod]
    public void Part1()
    {
        var result = _day02.Part1(_input);
        
        result.Should().Be(2);
    }

    [TestMethod]
    public void Part2()
    {
        var result = _day02.Part2(_input);
        
        result.Should().Be(4);
    }

    private string _input = @"7 6 4 2 1
1 2 7 8 9
9 7 6 2 1
1 3 2 4 5
8 6 4 4 1
1 3 6 7 9";
}