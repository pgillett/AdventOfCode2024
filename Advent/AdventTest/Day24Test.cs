using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day24Test
{
    private Day24 _day24;

    [TestInitialize]
    public void Setup()
    {
        _day24 = new Day24();
    }

    private string _input = @"";
}