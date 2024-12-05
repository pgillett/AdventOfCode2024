using System;
using Advent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventTest;

[TestClass]
public class Day02Test
{
    private Day02 _day02;

    [TestInitialize]
    public void Setup()
    {
        _day02 = new Day02();
    }

    private string _input = @"";
}