using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace roman2arabig
{
    public class mathOps
    {


        public int char_to_int(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return -1;
            }
        }

        public int roman_to_Int(String str1)
        {
            if (str1.Length == 0 || str1==null)
            {
                throw new ArgumentException("Incorrect format");
            }
            if (str1.Length == 1)
            {
                str1 = onlyOneChar(str1);
            }
            else
            {
                str1 = twoOrMoreChar(str1);
            }
            if (str1 == null) return -1;
            int num = char_to_int(str1[0]);
            int pre, curr;

            for (var i = 1; i < str1.Length; i++)
            {
                curr = char_to_int(str1[i]);
                pre = char_to_int(str1[i-1]);
                if (curr <= pre)
                {
                    num += curr;
                }
                else
                {
                    num = num - pre * 2 + curr;
                }
            }
            return num;
        }

        public String onlyOneChar (String inputtxt)
        {
            Regex rx = new Regex(@"^[IVXLCDM]+$");
            if(rx.IsMatch(inputtxt))
            {
                return inputtxt;
            }
            else
            {
                return inputtxt.Substring(0, inputtxt.Length - 1);
            }
        }

        public String twoOrMoreChar(String inputtxt)
        {
            Regex rx = new Regex(@"^[IVXLCDM]+$");
            var lastLetter = inputtxt.Substring(inputtxt.Length - 1, 1);
            var beforeLastLetter = inputtxt.Substring(inputtxt.Length - 2, 1);
            if (rx.IsMatch(inputtxt))
            {
                if ((lastLetter == "V" && beforeLastLetter == "I") || (lastLetter == "X" && beforeLastLetter == "I"))
                {
                    return inputtxt;
                }
                if ((lastLetter == "L" && beforeLastLetter == "X") || (lastLetter == "C" && beforeLastLetter == "X"))
                {
                    return inputtxt;
                }
                if ((lastLetter == "D" && beforeLastLetter == "C") || (lastLetter == "M" && beforeLastLetter == "C"))
                {
                    return inputtxt;
                }
                //--------
                if ((lastLetter == "I" && beforeLastLetter == "X") || (lastLetter == "I" && beforeLastLetter == "V"))
                {
                    return inputtxt;
                }
                if ((lastLetter == "X" && beforeLastLetter == "L") || (lastLetter == "X" && beforeLastLetter == "C"))
                {
                    return inputtxt;
                }
                if ((lastLetter == "C" && beforeLastLetter == "D") || (lastLetter == "C" && beforeLastLetter == "M"))
                {
                    return inputtxt;
                }
                //--------
                if ((lastLetter == "I" && beforeLastLetter == "I") || (lastLetter == "X" && beforeLastLetter == "X") || (lastLetter == "C" && beforeLastLetter == "C")
                     || (lastLetter == "M" && beforeLastLetter == "M"))
                {
                    return inputtxt;
                }
                else
                {
                    throw new ArgumentException("Incorrect format");
                }
            }
            else
            {
                throw new ArgumentException("Incorrect format");
            }
        }

    }
}



