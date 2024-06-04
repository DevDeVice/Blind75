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
        //Product-of-array-except-self
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            int[] leftProducts = new int[n];
            int[] rightProducts = new int[n];

            leftProducts[0] = 1;
            for (int i = 1; i < n; i++)
            {
                leftProducts[i] = leftProducts[i - 1] * nums[i - 1];
            }

            rightProducts[n - 1] = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                rightProducts[i] = rightProducts[i + 1] * nums[i + 1];
            }

            // Wynikowy iloczyn bez bieżącego elementu
            for (int i = 0; i < n; i++)
            {
                result[i] = leftProducts[i] * rightProducts[i];
            }

            return result;
        }
        //3sum
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var result = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue; // Pomiń duplikaty
                }

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1]) left++; // Pomiń duplikaty
                        while (left < right && nums[right] == nums[right - 1]) right--; // Pomiń duplikaty
                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return result;
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
 