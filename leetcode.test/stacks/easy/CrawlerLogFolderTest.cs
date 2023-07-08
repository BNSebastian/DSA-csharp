using leetcode.stacks.easy;

namespace leetcode.test.stacks.easy
{
    [TestClass]
    public class CrawlerLogFolderTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var logs = new string[] { "d1/", "d2/", "../", "d21/", "./" };
            var expected = 2;

            // Act
            var actual = CrawlerLogFolder.Solution(logs);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var logs = new string[] { "d1/", "d2/", "./", "d3/", "../", "d31/" };
            var expected = 3;

            // Act
            var actual = CrawlerLogFolder.Solution(logs);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var logs = new string[] { "d1/", "../", "../", "../" };
            var expected = 0;

            // Act
            var actual = CrawlerLogFolder.Solution(logs);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            var logs = new string[] { "./", "../", "./" };
            var expected = 0;

            // Act
            var actual = CrawlerLogFolder.Solution(logs);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}