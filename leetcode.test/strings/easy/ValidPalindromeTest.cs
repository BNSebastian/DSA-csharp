using leetcode.strings.easy;

namespace leetcode.test.strings.easy
{
    [TestClass]
    public class ValidPalindromeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var input = "A man, a plan, a canal: Panama";

            // Act
            var actual = ValidPalindrome.IsPalindrome(input);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var input = "race a car";

            // Act
            var actual = ValidPalindrome.IsPalindrome(input);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var input = " ";

            // Act
            var actual = ValidPalindrome.IsPalindrome(input);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}