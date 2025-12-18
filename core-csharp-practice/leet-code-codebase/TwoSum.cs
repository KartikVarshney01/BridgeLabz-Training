class TwoSum
{
    static void Main(string[] args)
    {
        // Read the size of the array
        int n = int.Parse(Console.ReadLine());

        int[] nums = new int[n];

        // Read array elements
        string[] input = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(input[i]);
        }

        // Read the target value
        int target = int.Parse(Console.ReadLine());

        int[] ans = FindTwoSum(nums, target);

        if (ans != null)
        {
            Console.WriteLine(ans[0] + " " + ans[1]);
        }
        else
        {
            Console.WriteLine("No pair found");
        }
    }

    static int[] FindTwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return null;
    }
}