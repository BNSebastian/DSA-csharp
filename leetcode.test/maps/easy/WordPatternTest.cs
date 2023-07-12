using leetcode.maps.easy;

namespace leetcode.test.maps.easy
{
    [TestClass]
    public class WordPatternTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var pattern = "abba";
            var s = "dog cat cat dog";
            var expected = true;

            // Act
            var actual = WordPattern.Solution(pattern, s);

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var pattern = "abba";
            var s = "dog cat cat fish";
            var expected = false;

            // Act
            var actual = WordPattern.Solution(pattern, s);

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var pattern = "aaaa";
            var s = "dog cat cat dog";
            var expected = false;

            // Act
            var actual = WordPattern.Solution(pattern, s);

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            var pattern = "abba";
            var s = "dog dog dog dog";
            var expected = false;

            // Act
            var actual = WordPattern.Solution(pattern, s);

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            // Arrange
            var pattern = "aaa";
            var s = "aa aa aa aa";
            var expected = false;

            // Act
            var actual = WordPattern.Solution(pattern, s);

            // Assert
            Assert.IsTrue(expected == actual);
        }
    }
}