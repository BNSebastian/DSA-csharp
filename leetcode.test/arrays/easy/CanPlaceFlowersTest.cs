using leetcode.arrays.easy;

namespace leetcode.test.arrays.easy
{
    [TestClass]
    public class CanPlaceFlowersTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var input = new int[] { 1, 0, 0, 0, 1 };
            var n = 1;

            // Act
            var actual = CanPlaceFlowers.Solution(input, n);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var input = new int[] { 1, 0, 0, 0, 1 };
            var n = 2;

            // Act
            var actual = CanPlaceFlowers.Solution(input, n);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var input = new int[] { 1 };
            var n = 0;

            // Act
            var actual = CanPlaceFlowers.Solution(input, n);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            var input = new int[] { 0, 0, 1, 0, 0 };
            var n = 1;

            // Act
            var actual = CanPlaceFlowers.Solution(input, n);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            // Arrange
            var input = new int[] { 0 };
            var n = 0;

            // Act
            var actual = CanPlaceFlowers.Solution(input, n);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}