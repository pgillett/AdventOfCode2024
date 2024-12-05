using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day07Test
{
    private Day07 _day07;

    [TestInitialize]
    public void Setup()
    {
        _day07 = new Day07();
    }

    private string _input = @"";
}