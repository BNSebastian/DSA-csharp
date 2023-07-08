using leetcode.arrays.medium;

namespace leetcode.test.arrays.medium
{
    [TestClass]
    public class ContainerWithMostWaterTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            var expected = 49;

            // Act
            int actual = ContainerWithMostWater.Solution(height);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var height = new int[] { 1, 1 };

            var expected = 1;

            // Act
            int actual = ContainerWithMostWater.Solution(height);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}