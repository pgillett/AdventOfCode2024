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

    [TestMethod]
    public void Part1()
    {
        var result = _day05.Part1(_input);
        
        result.Should().Be(143);
    }

    [TestMethod]
    public void Part2()
    {
        var result = _day05.Part2(_input);
        
        result.Should().Be(123);
    }
    
    private string _input = @"47|53
97|13
97|61
97|47
75|29
61|13
75|53
29|13
97|29
53|29
61|53
97|53
61|29
47|13
75|47
97|75
47|61
75|61
47|29
75|13
53|13

75,47,61,53,29
97,61,53,29,13
75,29,13
75,97,47,61,53
61,13,29
97,13,75,29,47";
}