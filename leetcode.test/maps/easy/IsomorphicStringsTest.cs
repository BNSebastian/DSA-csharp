using leetcode.maps.easy;

namespace leetcode.test.maps.easy
{
    [TestClass]
    public class IsomorphicStringsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var s = "egg";
            var t = "add";
            var expected = true;

            // Act
            var actual = IsomorphicStrings.Solution(s, t);

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var s = "foo";
            var t = "bar";
            var expected = false;

            // Act
            var actual = IsomorphicStrings.Solution(s, t);

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var s = "paper";
            var t = "title";
            var expected = true;

            // Act
            var actual = IsomorphicStrings.Solution(s, t);

            // Assert
            Assert.IsTrue(expected == actual);
        }
    }
}