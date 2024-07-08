using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LeetCodeClass
    {
        public string revertNumber(int x)
        {
            StringBuilder revertNum = new StringBuilder();
            int value = Math.Abs(x);
            while (value != 0)
            {
                int lastDigit = value % 10;
                revertNum.Insert(revertNum.Length, lastDigit);
                value /= 10;
            }
            if(x < 0)
            {
                revertNum.Insert(revertNum.Length, "-");
            }
            return revertNum.ToString();
        }

        public int RomanToInt(string s)
        {
            char[] inputChar = s.ToArray();
            int index = 0;
            int result = 0;
            while (index < inputChar.Count())
            {
                switch (inputChar[index])
                {
                    case 'I':
                        result += 1;
                        break;
                    case 'V':
                        if (checkCombination(inputChar, inputChar[index], index))
                        {
                            result += 3;
                            break;
                        }
                        result += 5;
                        break;
                    case 'X':
                        if (checkCombination(inputChar, inputChar[index], index))
                        {
                            result += 8;
                            break;
                        }
                        result += 10;
                        break;
                    case 'L':
                        if (checkCombination(inputChar, inputChar[index], index))
                        {
                            result += 30;
                            break;
                        }
                        result += 50;
                        break;
                    case 'C':
                        if (checkCombination(inputChar, inputChar[index], index))
                        {
                            result += 80;
                            break;
                        }
                        result += 100;
                        break;
                    case 'D':
                        if (checkCombination(inputChar, inputChar[index], index))
                        {
                            result += 300;
                            break;
                        }
                        result += 500;
                        break;
                    case 'M':
                        if (checkCombination(inputChar, inputChar[index], index))
                        {
                            result += 800;
                            break;
                        }
                        result += 1000;
                        break;
                }
                index += 1;
            }
            return result;
        }

        private bool checkCombination(char[] array, char c, int index)
        {
            if (index > 0)
            {
                switch (c)
                {
                    case 'V':
                    case 'X':
                        if (array[index - 1] == 'I')
                        {
                            return true;
                        }
                        break;
                    case 'L':
                    case 'C':
                        if (array[index - 1] == 'X')
                        {
                            return true;
                        }
                        break;
                    case 'D':
                    case 'M':
                        if (array[index - 1] == 'C')
                        {
                            return true;
                        }
                        break;
                }
            }
            return false;
        }

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Count() > 0)
            {
                if (strs.Count() == 1)
                {
                    return strs[0];
                }
                else
                {

                }
            }
            return "";
        }
    }
}
