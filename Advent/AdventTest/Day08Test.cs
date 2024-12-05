using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day08Test
{
    private Day08 _day08;

    [TestInitialize]
    public void Setup()
    {
        _day08 = new Day08();
    }

    private string _input = @"";
}