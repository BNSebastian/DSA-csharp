using leetcode.arrays;

namespace leetcode.test.arrays
{
    [TestClass]
    public class PlusOneTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int[] input = { 1, 2, 3 };
            int[] expected = { 1, 2, 4 };

            // Act
            int[] actual = PlusOne.Solution(input);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            int[] input = { 4, 3, 2, 1 };
            int[] expected = { 4, 3, 2, 2 };

            // Act
            int[] actual = PlusOne.Solution(input);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            int[] input = { 9 };
            int[] expected = { 1, 0 };

            // Act
            int[] actual = PlusOne.Solution(input);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}