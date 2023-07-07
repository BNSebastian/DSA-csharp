using leetcode.arrays.easy;

namespace leetcode.test.arrays.easy
{
    [TestClass]
    public class FindTargetIndicesAfterSortingArrayTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var nums = new int[] { 1, 2, 5, 2, 3 };
            var target = 2;

            var expected = new List<int> { 1, 2 };

            // Act
            var actual = FindTargetIndicesAfterSortingArray.TargetIndices(nums, target);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var nums = new int[] { 1, 2, 5, 2, 3 };
            var target = 3;

            var expected = new List<int> { 3 };

            // Act
            var actual = FindTargetIndicesAfterSortingArray.TargetIndices(nums, target);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var nums = new int[] { 1, 2, 5, 2, 3 };
            var target = 5;

            var expected = new List<int> { 4 };

            // Act
            var actual = FindTargetIndicesAfterSortingArray.TargetIndices(nums, target);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}