using leetcode.maps.easy;

namespace leetcode.test.maps.easy
{
    [TestClass]
    public class LongestHarmoniousSubsequenceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var nums = new int[] { 1, 3, 2, 2, 5, 2, 3, 7 };
            var expected = 5;

            // Act
            var actual = LongestHarmoniousSubsequence.Solution(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var nums = new int[] { 1, 2, 3, 4 };
            var expected = 2;

            // Act
            var actual = LongestHarmoniousSubsequence.Solution(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var nums = new int[] { 1, 1, 1, 1 };
            var expected = 0;

            // Act
            var actual = LongestHarmoniousSubsequence.Solution(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}