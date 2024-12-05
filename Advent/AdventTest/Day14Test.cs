using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day14Test
{
    private Day14 _day14;

    [TestInitialize]
    public void Setup()
    {
        _day14 = new Day14();
    }

    private string _input = @"";
}