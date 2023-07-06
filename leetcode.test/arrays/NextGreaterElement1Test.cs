using leetcode.arrays;

namespace leetcode.test.arrays
{
    [TestClass]
    public class NextGreaterElement1Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int[] nums1 = { 4, 1, 2 };
            int[] nums2 = { 1, 3, 4, 2 };

            int[] expected = { -1, 3, -1 };

            // Act
            int[] actual = NextGreaterElement1.Solution(nums1, nums2);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            int[] nums1 = { 2, 4 };
            int[] nums2 = { 1, 2, 3, 4 };

            int[] expected = { 3, -1 };

            // Act
            int[] actual = NextGreaterElement1.Solution(nums1, nums2);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}