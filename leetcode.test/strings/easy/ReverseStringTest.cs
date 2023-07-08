using leetcode.strings.easy;

namespace leetcode.test.strings.easy
{
    [TestClass]
    public class ReverseStringTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var input = new char[] { 'h', 'e', 'l', 'l', 'o' };
            var expected = new char[] { 'o', 'l', 'l', 'e', 'h' };

            // Act
            ReverseString.Solution(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var input = new char[] { 'H', 'a', 'n', 'n', 'a', 'h' };
            var expected = new char[] { 'h', 'a', 'n', 'n', 'a', 'H' };

            // Act
            ReverseString.Solution(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }
    }
}