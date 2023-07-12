using leetcode.maps.easy;

namespace leetcode.test.maps.easy
{
    [TestClass]
    public class FindTheDifferenceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var s = "abcd";
            var t = "abcde";
            var expected = 'e';

            // Act
            var actual = FindTheDifference.Solution(s, t);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var s = "";
            var t = "y";
            var expected = 'y';

            // Act
            var actual = FindTheDifference.Solution(s, t);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}