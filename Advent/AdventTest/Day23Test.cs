using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day23Test
{
    private Day23 _day23;

    [TestInitialize]
    public void Setup()
    {
        _day23 = new Day23();
    }

    private string _input = @"";
}