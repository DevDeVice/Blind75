using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75
{
    internal class Blind75
    {
        /*All tasks in this project were completed independently in C# without using the Internet.*/

        //Two-Sum
        public int[] TwoSum(int[] nums, int target)
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
            return [0, 0];
        }
        //Contains Duplicate
        public bool ContainsDuplicate(int[] nums)
        {
            return nums.Count() != nums.Distinct().Count();
        }
    }
}
