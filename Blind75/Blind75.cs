﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75
{
    internal class Blind75
    {
        /*
        All tasks in this project were completed independently in C# without using the Internet.
        https://www.techinterviewhandbook.org/best-practice-questions/
        */


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
        //Contains-Duplicate
        public bool ContainsDuplicate(int[] nums)
        {
            return nums.Count() != nums.Distinct().Count();
        }
        //Best-time-to-buy-and-sell-stock
        public int MaxProfit(int[] prices)
        {
            int buy = prices[0];
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < buy)
                {
                    buy = prices[i];
                }
                else if (prices[i] - buy > profit)
                {
                    profit = prices[i] - buy;
                }
            }
            return profit;
        }
    }
}
