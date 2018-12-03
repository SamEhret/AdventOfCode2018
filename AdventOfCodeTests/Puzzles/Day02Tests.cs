using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Puzzles.Day02;

namespace AdventOfCodeTests.Puzzles
{
    [TestClass]
    public class Day02Tests
    {
        [TestMethod]
        public void TestPartOneSolutionIsCorrect()
        {
            // Arrange
            // Act
            var solution = Solution.Part1();

            // Assert
            Assert.AreEqual(4980, solution);
        }

        [TestMethod]
        public void TestPartTwoSolutionIsCorrect()
        {
            // Arrange
            // Act
            var solution = Solution.Part2();

            // Assert
            Assert.AreEqual("qysdtrkloagnfozuwujmhrbvx", solution);
        }
    }
}
