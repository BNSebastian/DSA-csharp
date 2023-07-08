using leetcode.stacks.easy;

namespace leetcode.test.stacks.easy
{
    [TestClass]
    public class RemoveAllAdjacentDuplicatesInAStringTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var input = "abbaca";
            var expected = "ca";

            // Act
            var actual = RemoveAllAdjacentDuplicatesInAString.RemoveDuplicates(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var input = "azxxzy";
            var expected = "ay";

            // Act
            var actual = RemoveAllAdjacentDuplicatesInAString.RemoveDuplicates(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}