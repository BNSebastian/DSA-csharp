using leetcode.maps.easy;

namespace leetcode.test.maps.easy
{
    [TestClass]
    public class RomanToIntegerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var s = "III";
            var expected = 3;

            //Act
            var actual = RomanToInteger.Solution(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var s = "LVIII";
            var expected = 58;

            //Act
            var actual = RomanToInteger.Solution(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var s = "MCMXCIV";
            var expected = 1994;

            //Act
            var actual = RomanToInteger.Solution(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}