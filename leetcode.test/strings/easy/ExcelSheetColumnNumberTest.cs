using leetcode.strings.easy;

namespace leetcode.test.strings.easy
{
    [TestClass]
    public class ExcelSheetColumnNumberTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var input = "A";

            var expected = 1;

            // Act
            var actual = ExcelSheetColumnNumber.TitleToNumber(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var input = "AB";

            var expected = 28;

            // Act
            var actual = ExcelSheetColumnNumber.TitleToNumber(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var input = "ZY";

            var expected = 701;

            // Act
            var actual = ExcelSheetColumnNumber.TitleToNumber(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}