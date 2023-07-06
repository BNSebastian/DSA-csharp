using leetcode.arrays;

namespace leetcode.test.arrays
{
    [TestClass]
    public class AssignCookiesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int[] g = { 1, 2, 3 };
            int[] s = { 1, 1 };

            int expected = 1;

            // Act
            int actual = AssignCookies.FindContentChildren(g, s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            int[] g = { 1, 2 };
            int[] s = { 1, 2, 3 };

            int expected = 2;

            // Act
            int actual = AssignCookies.FindContentChildren(g, s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}