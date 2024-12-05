using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day04Test
{
    private Day04 _day04;

    [TestInitialize]
    public void Setup()
    {
        _day04 = new Day04();
    }

    private string _input = @"";
}