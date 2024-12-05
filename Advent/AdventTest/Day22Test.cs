using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day22Test
{
    private Day22 _day22;

    [TestInitialize]
    public void Setup()
    {
        _day22 = new Day22();
    }

    private string _input = @"";
}