using leetcode.arrays.easy;

namespace leetcode.test.arrays.easy
{
    [TestClass]
    public class SquaresOfASortedArrayTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            var input = new int[] { -4, -1, 0, 3, 10 };
            var expected = new int[] { 0, 1, 9, 16, 100 };

            // act
            var actual = SquaresOfASortedArray.Solution(input);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // arrange
            var input = new int[] { -7, -3, 2, 3, 11 };
            var expected = new int[] { 4, 9, 9, 49, 121 };

            // act
            var actual = SquaresOfASortedArray.Solution(input);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}