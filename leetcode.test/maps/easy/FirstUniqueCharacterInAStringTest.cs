using leetcode.maps.easy;

namespace leetcode.test.maps.easy
{
    [TestClass]
    public class FirstUniqueCharacterInAStringTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var s = "leetcode";
            var expected = 0;

            // Act
            var actual = FirstUniqueCharacterInAString.Solution(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var s = "loveleetcode";
            var expected = 2;

            // Act
            var actual = FirstUniqueCharacterInAString.Solution(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var s = "aabb";
            var expected = -1;

            // Act
            var actual = FirstUniqueCharacterInAString.Solution(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}