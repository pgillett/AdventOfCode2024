using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day15Test
{
    private Day15 _day15;

    [TestInitialize]
    public void Setup()
    {
        _day15 = new Day15();
    }

    private string _input = @"";
}