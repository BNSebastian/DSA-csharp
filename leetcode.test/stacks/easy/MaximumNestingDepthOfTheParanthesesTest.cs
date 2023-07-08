using leetcode.stacks.easy;

namespace leetcode.test.stacks.easy
{
    [TestClass]
    public class MaximumNestingDepthOfTheParanthesesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var input = "(1+(2*3)+((8)/4))+1";
            var expected = 3;

            // Act
            var actual = MaxingNestingDepthOfTheParantheses.Solution(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var input = "(1)+((2))+(((3)))";
            var expected = 3;

            // Act
            var actual = MaxingNestingDepthOfTheParantheses.Solution(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}