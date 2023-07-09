using leetcode.stacks.easy;

namespace leetcode.test.stacks.easy
{
    [TestClass]
    public class RemoveOutermostParanthesesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var input = "(()())(())";
            var expected = "()()()";

            // Act
            var actual = RemoveOutermostParantheses.Solution(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var input = "(()())(())(()(()))";
            var expected = "()()()()(())";

            // Act
            var actual = RemoveOutermostParantheses.Solution(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var input = "()()";
            var expected = "";

            // Act
            var actual = RemoveOutermostParantheses.Solution(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}