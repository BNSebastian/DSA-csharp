using leetcode.arrays.easy;

namespace leetcode.test.arrays.easy
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int n = 3;
            List<string> expected = new List<string> { "1", "2", "Fizz" };

            // Act
            List<string> actual = FizzBuzz.Solution(n);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            int n = 5;
            List<string> expected = new List<string> { "1", "2", "Fizz", "4", "Buzz" };

            // Act
            List<string> actual = FizzBuzz.Solution(n);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            int n = 15;
            List<string> expected = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            // Act
            List<string> actual = FizzBuzz.Solution(n);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}