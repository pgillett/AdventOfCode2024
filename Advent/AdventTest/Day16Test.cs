using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day16Test
{
    private Day16 _day16;

    [TestInitialize]
    public void Setup()
    {
        _day16 = new Day16();
    }

    private string _input = @"";
}