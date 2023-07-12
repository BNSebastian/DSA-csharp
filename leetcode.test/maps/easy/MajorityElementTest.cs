using leetcode.maps.easy;

namespace leetcode.test.maps.easy
{
    [TestClass]
    public class MajorityElementTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var nums = new int[] { 3, 2, 3 };
            var expected = 3;

            // Act
            var actual = MajorityElement.Solution(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var nums = new int[] { 2, 2, 1, 1, 1, 2, 2 };
            var expected = 2;

            // Act
            var actual = MajorityElement.Solution(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}