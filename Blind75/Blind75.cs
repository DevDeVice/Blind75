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
        //Valid-anagram
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            int[] map = new int[26];
            foreach (var i in s)
            {
                map[i - 'a']++;
            }
            foreach (var i in t)
            {
                if (map[i - 'a'] <= 0)
                    return false;
                else
                    map[i - 'a']--;
            }
            return true;
        }
        //Valid-parentheses
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> mappings = new Dictionary<char, char>();
            mappings.Add(')', '(');
            mappings.Add('}', '{');
            mappings.Add(']', '[');

            foreach (char c in s)
            {
                if (mappings.ContainsValue(c))
                {
                    stack.Push(c);
                }
                else if (mappings.ContainsKey(c))
                {
                    if (stack.Count == 0 || stack.Pop() != mappings[c])
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
