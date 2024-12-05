using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day17Test
{
    private Day17 _day17;

    [TestInitialize]
    public void Setup()
    {
        _day17 = new Day17();
    }

    private string _input = @"";
}