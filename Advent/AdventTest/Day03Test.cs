using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day03Test
{
    private Day03 _day03;

    [TestInitialize]
    public void Setup()
    {
        _day03 = new Day03();
    }

    [TestMethod]
    public void Part1()
    {
        var result = _day03.Part1(_input1);

        result.Should().Be(161);
    }
    
    [TestMethod]
    public void Part2()
    {
        var result = _day03.Part2(_input2);

        result.Should().Be(48);
    }

    private string _input1 = @"xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))";
    private string _input2 = @"xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))";
}