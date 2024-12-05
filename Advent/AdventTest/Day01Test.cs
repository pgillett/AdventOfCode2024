using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day01Test
{
    private Day01 _day01;

    [TestInitialize]
    public void Setup()
    {
        _day01 = new Day01();
    }

    [TestMethod]
    public void Part1()
    {
        var result = _day01.Part1(_input);
        
        result.Should().Be(11);
    }
    
    [TestMethod]
    public void Part2()
    {
        var result = _day01.Part2(_input);
        
        result.Should().Be(31);
    }

    private string _input = @"3   4
4   3
2   5
1   3
3   9
3   3";
}
