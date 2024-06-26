namespace ADS;

public class Arrays
{
    public static int RemoveDuplicates(int[] nums)
    {
        int count = 0;
        int current = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] <= current)
            {
            }
            else
            {
                current = nums[i];
                count++;
                nums[count] = nums[i];
            }
        }

        return count + 1;
    }

    public static int RemoveElement(int[] nums, int val)
    {
        int count = 0;
        for (int i = 0; i < nums.Length;)
        {
            if (nums[i] == val)
            {
                for (int k = i + 1; k < nums.Length; k++)
                {
                    if (k == nums.Length - 1)
                    {
                        nums[k - 1] = nums[k];
                        nums[^1] = 0;
                        i--;
                    }
                    else
                    {
                        nums[k - 1] = nums[k];
                    }
                }

                count++;
            }

            i++;
        }
        return nums.Length-count;
    }
}