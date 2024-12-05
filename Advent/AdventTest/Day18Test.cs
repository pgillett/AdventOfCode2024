using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day18Test
{
    private Day18 _day18;

    [TestInitialize]
    public void Setup()
    {
        _day18 = new Day18();
    }

    private string _input = @"";
}