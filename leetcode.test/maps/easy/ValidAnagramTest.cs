using leetcode.maps.easy;

namespace leetcode.test.maps.easy
{
    [TestClass]
    public class ValidAnagramTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var s = "anagram";
            var t = "nagaram";
            var expected = true;

            // Act
            var actual = ValidAnagram.Solution(s, t);

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var s = "rat";
            var t = "car";
            var expected = false;

            // Act
            var actual = ValidAnagram.Solution(s, t);

            // Assert
            Assert.IsTrue(expected == actual);
        }
    }
}