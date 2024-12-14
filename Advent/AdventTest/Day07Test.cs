using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day07Test
{
    private Day07 _day07;

    [TestInitialize]
    public void Setup()
    {
        _day07 = new Day07();
    }

    [TestMethod]
    public void Part1()
    {
        var result = _day07.Part1(_input);
        
        result.Should().Be(3749);
    }
    
    [TestMethod]
    public void Part2()
    {
        var result = _day07.Part2(_input);
        
        result.Should().Be(11387);
    }
    
    private string _input = @"190: 10 19
3267: 81 40 27
83: 17 5
156: 15 6
7290: 6 8 6 15
161011: 16 10 13
192: 17 8 14
21037: 9 7 18 13
292: 11 6 16 20";
}