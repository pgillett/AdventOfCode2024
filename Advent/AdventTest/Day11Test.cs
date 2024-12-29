using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day11Test
{
    private Day11 _day11;

    [TestInitialize]
    public void Setup()
    {
        _day11 = new Day11();
    }

    [TestMethod]
    public void Part1()
    {
        var results = _day11.Part1(_input);

        results.Should().Be(55312);
    }
    
    [TestMethod]
    public void Part2()
    {
        var results = _day11.Part2(_input);

        results.Should().Be(65601038650482L);
    }

    private string _input = @"125 17";
}