using leetcode.easy.bits;

namespace leetcode.test.easy.bits
{
    [TestClass]
    public class NumberOfOneBitsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            uint input = 0b00000000000000000000000000001011;

            var expected = 3;

            // Act
            var actual = NumberOfOneBits.Solution(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            uint input = 0b00000000000000000000000010000000;

            var expected = 1;

            // Act
            var actual = NumberOfOneBits.Solution(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            uint input = 0b11111111111111111111111111111101;

            var expected = 31;

            // Act
            var actual = NumberOfOneBits.Solution(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}