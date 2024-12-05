using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day05Test
{
    private Day05 _day05;

    [TestInitialize]
    public void Setup()
    {
        _day05 = new Day05();
    }

    private string _input = @"";
}