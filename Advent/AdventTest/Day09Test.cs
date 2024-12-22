using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day09Test
{
    private Day09 _day09;

    [TestInitialize]
    public void Setup()
    {
        _day09 = new Day09();
    }

    [TestMethod]
    public void Part1()
    {
        var result = _day09.Part1(_input);
        
        result.Should().Be(1928);
    }
    
    [TestMethod]
    public void Part2()
    {
        var result = _day09.Part2(_input);
        
        result.Should().Be(2858);
    }

    private string _input = @"2333133121414131402";
}