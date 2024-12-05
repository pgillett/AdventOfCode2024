using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day01Test
{
    private Day01 _day01;

    [TestInitialize]
    public void Setup()
    {
        _day01 = new Day01();
    }

    private string _input = @"";
}
