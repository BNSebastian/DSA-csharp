using leetcode.arrays.medium;

namespace leetcode.test.arrays.medium
{
    [TestClass]
    public class ThreeSumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var nums = new int[] { -1, 0, 1, 2, -1, -4 };

            var expected = new List<List<int>>() { new List<int> { -1, -1, 2 }, new List<int> { -1, 0, 1 } };

            // Act
            var actual = ThreeSum.Solution(nums);

            // Assert
            for (int i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var nums = new int[] { 0, 1, 1 };

            var expected = new List<List<int>>();

            // Act
            var actual = ThreeSum.Solution(nums);

            // Assert
            for (int i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var nums = new int[] { 0, 0, 0 };

            var expected = new List<List<int>>() { new List<int> { 0, 0, 0 } };

            // Act
            var actual = ThreeSum.Solution(nums);

            // Assert
            for (int i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}