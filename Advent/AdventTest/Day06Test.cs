using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day06Test
{
    private Day06 _day06;

    [TestInitialize]
    public void Setup()
    {
        _day06 = new Day06();
    }

    private string _input = @"";
}