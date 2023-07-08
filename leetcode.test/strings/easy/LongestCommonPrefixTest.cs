using leetcode.strings.easy;

namespace leetcode.test.strings.easy
{
    [TestClass]
    public class LongestCommonPrefixTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var input = new string[] { "flower", "flow", "flight" };

            var expected = "fl";

            // Act
            var actual = LongestCommonPrefix.Solution(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var input = new string[] { "dog", "racecar", "car" };

            var expected = "";

            // Act
            var actual = LongestCommonPrefix.Solution(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}