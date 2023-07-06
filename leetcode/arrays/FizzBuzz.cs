namespace leetcode.arrays
{
    public static class FizzBuzz
    {
        public static List<string> Solution(int n)
        {
            List<string> output = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) output.Add("FizzBuzz");
                else if (i % 3 == 0) output.Add("Fizz");
                else if (i % 5 == 0) output.Add("Buzz");
                else output.Add(i.ToString());
            }

            return output;
        }
    }
}