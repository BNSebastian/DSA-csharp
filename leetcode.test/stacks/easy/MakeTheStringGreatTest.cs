using leetcode.stacks.easy;

namespace leetcode.test.stacks.easy
{
    [TestClass]
    public class MakeTheStringGreatTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var input = "leEeetcode";
            var expected = "leetcode";

            // Act
            var actual = MakeTheStringGreat.Solution(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var input = "abBAcC";
            var expected = "";

            // Act
            var actual = MakeTheStringGreat.Solution(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var input = "s";
            var expected = "s";

            // Act
            var actual = MakeTheStringGreat.Solution(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}