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

    private string _input = @"";
}