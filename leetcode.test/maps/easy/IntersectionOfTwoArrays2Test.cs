using leetcode.maps.easy;

namespace leetcode.test.maps.easy
{
    [TestClass]
    public class IntersectionOfTwoArrays2Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var nums1 = new int[] { 1, 2, 2, 1 };
            var nums2 = new int[] { 2, 2 };
            var expected = new int[] { 2, 2 };

            // Act
            var actual = IntersectionOfTwoArrays2.Solution(nums1, nums2);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var nums1 = new int[] { 4, 9, 5 };
            var nums2 = new int[] { 9, 4, 9, 8, 4 };
            var expected = new int[] { 4, 9 };

            // Act
            var actual = IntersectionOfTwoArrays2.Solution(nums1, nums2);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var nums1 = new int[] { 1, 2, 2, 1 };
            var nums2 = new int[] { 2 };
            var expected = new int[] { 2 };

            // Act
            var actual = IntersectionOfTwoArrays2.Solution(nums1, nums2);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}