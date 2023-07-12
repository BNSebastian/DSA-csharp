using leetcode.maps.easy;

namespace leetcode.test.maps.easy
{
    [TestClass]
    public class SetMismatchTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var nums = new int[] { 1, 2, 2, 4 };
            var expected = new int[] { 2, 3 };

            // Act
            var actual = SetMismatch.Solution(nums);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var nums = new int[] { 1, 1 };
            var expected = new int[] { 1, 2 };

            // Act
            var actual = SetMismatch.Solution(nums);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}