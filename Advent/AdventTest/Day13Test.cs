using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day13Test
{
    private Day13 _day13;

    [TestInitialize]
    public void Setup()
    {
        _day13 = new Day13();
    }

    private string _input = @"";
}