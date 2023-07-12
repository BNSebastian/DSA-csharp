using leetcode.maps.easy;

namespace leetcode.test.maps.easy
{
    [TestClass]
    public class RansomNoteTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var ransomenote = "a";
            var magazine = "b";
            var expected = false;

            // Act
            var actual = RansomNote.Solution(ransomenote, magazine);

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var ransomenote = "aa";
            var magazine = "ab";
            var expected = false;

            // Act
            var actual = RansomNote.Solution(ransomenote, magazine);

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var ransomenote = "aa";
            var magazine = "aab";
            var expected = true;

            // Act
            var actual = RansomNote.Solution(ransomenote, magazine);

            // Assert
            Assert.IsTrue(expected == actual);
        }
    }
}