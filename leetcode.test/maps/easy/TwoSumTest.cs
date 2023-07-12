using leetcode.maps.easy;

namespace leetcode.test.maps.easy
{
    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var expected = new int[] { 0, 1 };

            // Act
            var actual = TwoSum.Solution(nums, target);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var nums = new int[] { 3, 2, 4 };
            var target = 6;

            var expected = new int[] { 1, 2 };

            // Act
            var actual = TwoSum.Solution(nums, target);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var nums = new int[] { 3, 3 };
            var target = 6;

            var expected = new int[] { 0, 1 };

            // Act
            var actual = TwoSum.Solution(nums, target);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}