using leetcode.arrays.easy;

namespace leetcode.test.arrays.easy
{
    [TestClass]
    public class ArrayPartitionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int[] nums = { 1, 4, 3, 2 };

            int expected = 4;

            // Act
            int actual = ArrayPartition.Solution(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            int[] nums = { 6, 2, 6, 5, 1, 2 };

            int expected = 9;

            // Act
            int actual = ArrayPartition.Solution(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}