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

    private string _input = @"";
}