using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day21Test
{
    private Day21 _day21;

    [TestInitialize]
    public void Setup()
    {
        _day21 = new Day21();
    }

    private string _input = @"";
}