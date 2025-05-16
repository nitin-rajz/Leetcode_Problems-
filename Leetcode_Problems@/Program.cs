using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Problems_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
                Program obj = new Program();
          Solution solution = new Solution();
            //solution.RemoveElement(new int[] { 3, 2, 2, 3 }, 3);
            //solution.PlusOne(new int[] { 9, 9, 9 });
            //solution.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
            //solution.MaxProfit(new int[] { 7, 6, 4, 3, 1}); // [7,6,4,3,1]
            //solution.MaxProfit(new int[] { 2, 1, 4, 5, 2, 9, 7 }); // [2,1,4,5,2,9,7]
            //solution.SingleNumber(new int[] { 1,5,6,1,5,6,4});
            //solution.MergeAlternately("abc", "pqr");
            //solution.FindTheDifference("abcd", "abcde");
            //solution.StrStr("sadbutsad", "sad");
            solution.IsAnagram("anagram", "nagaram");

            Console.WriteLine("Nitin Raj");
        }
        void print()
        {
            Console.WriteLine("nititititi");
        }
    }
 
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int total = 0;
         foreach(int i in nums)
            {
                if (val != i)
                {
                    nums[total] = i;
                    total++;

                }
            }
            return total;

        }
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;

                    return digits;
                }
             
                digits[i] = 0;

            }
            int[] result = new int[digits.Length + 1];
            result[0] = 1;

            return result;

        }
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }
            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }

        }

        public int MaxProfit(int[] prices)
        {
            
            int min = prices[0];
            int minIndex = 0;
            int max = 0;
            for ( int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                    minIndex = i;
                }
            }
          if(minIndex< prices.Length - 1)
            {
                for (int j = minIndex + 1; j < prices.Length; j++)
                {
                    if (prices[j] > max)
                    {
                        max = prices[j];

                    }
                }
            }
            else
            {
                return 0;
            }
            return max - min;


        }

        public int SingleNumber(int[] nums)
        {
            // return nums.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key).First();
            int result = 0;
            foreach (int i in nums)
            {
                result ^= i;
            }
            return result;

        }

        public string MergeAlternately(string word1, string word2)
        {
            string combined = "";
            for (int i = 0; i < word1.Length + word2.Length;i++)
            {
                if (i < word1.Length)
                {
                    combined += word1[i];
                }
                if (i < word2.Length)
                {
                    combined += word2[i];
                }
               
            }
            return combined;


        }
        public char FindTheDifference(string s, string t)
        {
         string combined = s + t;
            char result = combined[0];
            for (int i = 1; i < combined.Length; i++)
            {
                result ^= combined[i];
            }
            return result;

        }
        public int StrStr(string haystack, string needle)
        {
            int index = haystack.IndexOf(needle);
            if(index != -1)
            {
                return index;
            }
            else
            {
                return -1;
            }

        }
        public bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }
            char[] arr1 = s.ToCharArray();
            char[] arr2 = t.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            return arr1.SequenceEqual(arr2);
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    if (arr1[i] != arr2[i])
            //    {
            //        return false;
            //    }
            //}
            


        }

        public int MajorityElement(int[] nums)
        {    
            int result = 0;
            foreach(int i in nums)
            {
                result ^= i;

            }
            return result;



        }

    }
}
