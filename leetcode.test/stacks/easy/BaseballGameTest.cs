using leetcode.stacks.easy;

namespace leetcode.test.stacks.easy
{
    [TestClass]
    public class BaseballGameTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var input = new string[] { "5", "2", "C", "D", "+" };
            var expected = 30;

            // Act
            var actual = BaseballGame.CalPoints(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var input = new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" };
            var expected = 27;

            // Act
            var actual = BaseballGame.CalPoints(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var input = new string[] { "1", "C" };
            var expected = 0;

            // Act
            var actual = BaseballGame.CalPoints(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}