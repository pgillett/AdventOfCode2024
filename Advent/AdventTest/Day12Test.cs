using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day12Test
{
    private Day12 _day12;

    [TestInitialize]
    public void Setup()
    {
        _day12 = new Day12();
    }

    private string _input = @"";
}