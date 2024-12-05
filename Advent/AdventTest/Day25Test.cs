using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day25Test
{
    private Day25 _day25;

    [TestInitialize]
    public void Setup()
    {
        _day25 = new Day25();
    }

    private string _input = @"";
}