using leetcode.strings.easy;

namespace leetcode.test.strings.easy
{
    [TestClass]
    public class ReverseWordsInAString3Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var input = "Let's take LeetCode contest";
            var expected = "s'teL ekat edoCteeL tsetnoc";

            // Act
            var actual = ReverseWordsInAString3.ReverseWords(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var input = "God Ding";
            var expected = "doG gniD";

            // Act
            var actual = ReverseWordsInAString3.ReverseWords(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}