using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (var num in numbers)
            {                
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }
            return sum % 2 != 0 ? true : false;            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsNumber)
                && password.Any(Char.IsLower)
                && password.Any(Char.IsUpper);
            //bool hasUpper = false;
            //bool hasLower = false;
            //bool hasNum = false;
            //foreach (var character in password)
            //{
            //    if (Char.IsUpper(character))
            //    {
            //        hasUpper = true;
            //    }
            //    if (Char.IsLower(character))
            //    {
            //        hasLower = true;
            //    }
            //    if (Char.IsDigit(character))
            //    {
            //        hasNum = true;
            //    }
            //}
            //return hasUpper && hasLower && hasNum;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            //var numbers = new List<int>();
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        numbers.Add(i);
            //    }
            //}
            //return numbers.ToArray();
            return Enumerable.Range(1, 100).Where(x => x % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
