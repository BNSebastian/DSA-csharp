using leetcode.stacks.easy;

namespace leetcode.test.stacks.easy
{
    [TestClass]
    public class ValidParanthesisTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var input = "()";

            // Act
            var actual = ValidParantheses.Solution(input);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var input = "()[]{}";

            // Act
            var actual = ValidParantheses.Solution(input);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var input = "(]";

            // Act
            var actual = ValidParantheses.Solution(input);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}