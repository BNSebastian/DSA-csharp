using leetcode.strings.easy;

namespace leetcode.test.strings.easy
{
    [TestClass]
    public class FindTheIndexOfTheFirstOccurenceInAStringTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var haystack = "sadbutsad";
            var needle = "sad";

            var expected = 0;

            // Act
            var actual = FindTheIndexOfTheFirstOccurenceInAString.StrStr(haystack, needle);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var haystack = "leetcode";
            var needle = "leeto";

            var expected = -1;

            // Act
            var actual = FindTheIndexOfTheFirstOccurenceInAString.StrStr(haystack, needle);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}