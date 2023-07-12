using leetcode.sets.easy;

namespace leetcode.test.sets.easy
{
    [TestClass]
    public class HappyNumberTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var n = 19;
            var expected = true;

            // Act
            var actual = HappyNumber.Solution(n);

            // Assert
            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var n = 2;
            var expected = false;

            // Act
            var actual = HappyNumber.Solution(n);

            // Assert
            Assert.IsTrue(actual == expected);
        }
    }
}