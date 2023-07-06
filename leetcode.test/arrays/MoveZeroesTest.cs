using leetcode.arrays;

namespace leetcode.test.arrays
{
    [TestClass]
    public class MoveZeroesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int[] nums = { 0, 1, 0, 3, 12 };
            int[] expected = { 1, 3, 12, 0, 0 };

            // Act
            MoveZeroes.move(nums);
            int[] actual = nums;

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            int[] nums = { 0 };
            int[] expected = { 0 };

            // Act
            MoveZeroes.move(nums);
            int[] actual = nums;

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            int[] nums = { 0, 0, 1 };
            int[] expected = { 1, 0, 0 };

            // Act
            MoveZeroes.move(nums);
            int[] actual = nums;

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}