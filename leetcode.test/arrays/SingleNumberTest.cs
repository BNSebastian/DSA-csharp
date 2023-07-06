using leetcode.arrays;

namespace leetcode.test.arrays
{
    [TestClass]
    public class SingleNumberTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int[] nums = { 2, 2, 1 };
            int expected = 1;

            // Act
            int actual = SingleNumber.Find(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            int[] nums = { 4, 1, 2, 1, 2 };
            int expected = 4;

            // Act
            int actual = SingleNumber.Find(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            int[] nums = { 1 };
            int expected = 1;

            // Act
            int actual = SingleNumber.Find(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}