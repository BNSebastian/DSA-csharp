using leetcode.stacks.easy;

namespace leetcode.test.stacks.easy
{
    [TestClass]
    public class BackspaceStringCompareTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var s = "ab#c";
            var t = "ad#c";

            // Act
            var actual = BackspaceStringCompare.BackspaceCompare(s, t);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var s = "ab##";
            var t = "c#d#";

            // Act
            var actual = BackspaceStringCompare.BackspaceCompare(s, t);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var s = "a#c";
            var t = "b";

            // Act
            var actual = BackspaceStringCompare.BackspaceCompare(s, t);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            var s = "a##c";
            var t = "#a#c";

            // Act
            var actual = BackspaceStringCompare.BackspaceCompare(s, t);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}