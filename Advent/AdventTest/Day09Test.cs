using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day09Test
{
    private Day09 _day09;

    [TestInitialize]
    public void Setup()
    {
        _day09 = new Day09();
    }

    private string _input = @"";
}