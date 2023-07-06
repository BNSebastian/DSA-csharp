using leetcode.arrays;

namespace leetcode.test.arrays
{
    [TestClass]
    public class MergeSortedArrayTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;

            int[] expected = { 1, 2, 2, 3, 5, 6 };

            // Act
            MergeSortedArray.Solution(nums1, m, nums2, n);
            int[] actual = nums1;

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            int[] nums1 = { 1 };
            int m = 1;
            int[] nums2 = { };
            int n = 0;

            int[] expected = { 1 };

            // Act
            MergeSortedArray.Solution(nums1, m, nums2, n);
            int[] actual = nums1;

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            int[] nums1 = { 0 };
            int m = 0;
            int[] nums2 = { 1 };
            int n = 1;

            int[] expected = { 1 };

            // Act
            MergeSortedArray.Solution(nums1, m, nums2, n);
            int[] actual = nums1;

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}