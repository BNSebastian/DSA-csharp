using leetcode.maps.easy;

namespace leetcode.test.maps.easy
{
    [TestClass]
    public class ContainsDuplicateTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var nums = new int[] { 1, 2, 3, 1 };
            var expected = true;

            // Act
            var actual = ContainsDuplicate.Solution(nums);

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var nums = new int[] { 1, 2, 3, 4 };
            var expected = false;

            // Act
            var actual = ContainsDuplicate.Solution(nums);

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            var expected = true;

            // Act
            var actual = ContainsDuplicate.Solution(nums);

            // Assert
            Assert.IsTrue(expected == actual);
        }
    }
}