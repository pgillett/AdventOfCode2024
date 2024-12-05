using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day03Test
{
    private Day03 _day03;

    [TestInitialize]
    public void Setup()
    {
        _day03 = new Day03();
    }

    private string _input = @"";
}