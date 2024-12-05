using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day20Test
{
    private Day20 _day20;

    [TestInitialize]
    public void Setup()
    {
        _day20 = new Day20();
    }

    private string _input = @"";
}