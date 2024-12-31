using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day13Test
{
    private Day13 _day13;

    [TestInitialize]
    public void Setup()
    {
        _day13 = new Day13();
    }

    [TestMethod]
    public void Part1()
    {
        var result = _day13.Part1(_input);

        result.Should().Be(480);
    }
    
    [TestMethod]
    public void Part2()
    {
        var result = _day13.Part2(_input);

        result.Should().Be(875318608908);
    }
    

    private string _input = @"Button A: X+94, Y+34
Button B: X+22, Y+67
Prize: X=8400, Y=5400

Button A: X+26, Y+66
Button B: X+67, Y+21
Prize: X=12748, Y=12176

Button A: X+17, Y+86
Button B: X+84, Y+37
Prize: X=7870, Y=6450

Button A: X+69, Y+23
Button B: X+27, Y+71
Prize: X=18641, Y=10279";
}