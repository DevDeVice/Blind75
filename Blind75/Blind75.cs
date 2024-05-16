using System;
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
        //Maximum-subarray
        public int MaxSubArray(int[] nums)
        {
            int sum = 0;
            int maxSum = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (nums[i] > sum)
                {
                    sum = nums[i];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            return maxSum;
        }
        //Reverse-linked-list
        public class ListNode
            {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
                {
                    this.val = val;
                    this.next = next;
                }
        }
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;
            ListNode nextNode = null;

            while (current != null)
            {
                nextNode = current.next; // Save the next node
                current.next = prev; // Reverse the link
                prev = current; // Move pointers one position ahead
                current = nextNode;
            }

            return prev;
        }
        //Linked-list-cycle
        public class ListNode2 {
            public int val;
            public ListNode2 next;
            public ListNode2(int x) {
                val = x;
                next = null;
            }
        }
        public bool HasCycle(ListNode2 head)
        {
            HashSet<ListNode2> visited = new HashSet<ListNode2>();

            while (head != null)
            {
                if (visited.Contains(head))
                {
                    return true;
                }
                visited.Add(head);
                head = head.next;
            }
            return false;
        }
        //Invert-binary-tree
        public class TreeNode {
           public int val;
           public TreeNode left;
           public TreeNode right;
           public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
               this.val = val;
               this.left = left;
               this.right = right;
           }
       }

        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode temp = root.left;
            root.left = InvertTree(root.right);
            root.right = InvertTree(temp);

            return root;
        }
    }
}
 