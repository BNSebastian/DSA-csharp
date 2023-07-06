namespace leetcode.arrays
{
    public static class AssignCookies
    {
        public static int Solution(int[] children, int[] cookies)
        {
            Array.Sort(children);
            Array.Sort(cookies);

            int child = 0, cookie = 0;

            for (; child < children.Length && cookie < cookies.Length; cookie++)
            {
                if (cookies[cookie] >= children[child])
                {
                    child++;
                }
            }

            return child;
        }
    }
}