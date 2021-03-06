﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Puzzles.Day01;

namespace AdventOfCodeTests.Puzzles
{
    [TestClass]
    public class Day01Tests
    {
        [TestMethod]
        public void TestPartOneSolutionIsCorrect()
        {
            // Arrange
            // Act
            var solution = Solution.Part1();

            // Assert
            Assert.AreEqual(442, solution);
        }

        [TestMethod]
        public void TestPartTwoSolutionIsCorrect()
        {
            // Arrange
            // Act
            var solution = Solution.Part2();

            // Assert
            Assert.AreEqual(59908, solution);
        }
    }
}
