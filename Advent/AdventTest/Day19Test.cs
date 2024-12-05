using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day19Test
{
    private Day19 _day19;

    [TestInitialize]
    public void Setup()
    {
        _day19 = new Day19();
    }

    private string _input = @"";
}