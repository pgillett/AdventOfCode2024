using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day14Test
{
    private Day14 _day14;

    [TestInitialize]
    public void Setup()
    {
        _day14 = new Day14();
    }

    [TestMethod]
    public void Part1()
    {
        var result = _day14.Part1(_input, 11, 7);
        
        result.Should().Be(12);
    }
    
    [TestMethod]
    public void Part2()
    {
        var result = _day14.Part2(_input, 11, 7);
        
        result.Should().Be(9);
    }

    private string _input = @"p=0,4 v=3,-3
p=6,3 v=-1,-3
p=10,3 v=-1,2
p=2,0 v=2,-1
p=0,0 v=1,3
p=3,0 v=-2,-2
p=7,6 v=-1,-3
p=3,0 v=-1,-2
p=9,3 v=2,3
p=7,3 v=-1,2
p=2,4 v=2,-3
p=9,5 v=-3,-3";
}