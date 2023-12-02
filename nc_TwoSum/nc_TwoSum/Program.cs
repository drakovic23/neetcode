namespace nc_TwoSum
{
    internal class Program
    {

        static public int[] TwoSum(int[] nums, int target)
        {
            int[] ret = new int[2];

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();


            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                
                if(keyValuePairs.ContainsKey(diff))
                {
                    ret[0] = i;
                    ret[1] = keyValuePairs[diff];
                    return ret;
                }

                if (keyValuePairs.ContainsKey(nums[i]) == false)
                {
                    keyValuePairs.Add(nums[i], i);
                }
            }
            
            return ret;
            
        }


        static void Main(string[] args)
        {
            //int[] nums = { 2, 4, 11, 3 };
            int[] nums = { 3, 2, 4 };
            int[] result = TwoSum(nums, 6);

            Console.WriteLine($"[{result[0]},{result[1]}]");
            
        }
    }
}