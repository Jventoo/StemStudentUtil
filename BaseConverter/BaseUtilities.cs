using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StemStudentUtil.BaseConverter
{
    class BaseUtilities
    {
        static public string convertInput(string inputStr, int inputBase, int outputBase)
        {
            string res = "", temp = "";

            if (inputBase == 10)
                res = convertFromDecimal(inputStr, outputBase);
            else
            {
                temp = convertToDecimal(inputStr, inputBase);

                if (outputBase != 10)
                    res = convertFromDecimal(temp, outputBase);
                else
                    res = temp;
            }

            return res;
        }

        static public int convertBaseType(string baseStr)
        {
            int baseNum = 0;

            switch (baseStr)
            {
                case "Decimal":
                    baseNum = 10;
                    break;

                case "Hexadecimal":
                    baseNum = 16;
                    break;

                case "Binary":
                    baseNum = 2;
                    break;

                case "Octal":
                    baseNum = 8;
                    break;
            }

            return baseNum;
        }

        static private string convertToDecimal(string inputStr, int inputBase)
        {
            int num = 0, len = inputStr.Length;

            for(int i = 0; i < len; i++)
            {
                int digit = 0;
                char c = inputStr[i];

                switch (c)
                {
                    case 'A':
                        digit = 10;
                        break;
                    case 'B':
                        digit = 11;
                        break;
                    case 'C':
                        digit = 12;
                        break;
                    case 'D':
                        digit = 13;
                        break;
                    case 'E':
                        digit = 14;
                        break;
                    case 'F':
                        digit = 15;
                        break;

                    default:
                        digit = c - '0';
                        break;
                }

                
                num += digit * (int)Math.Pow(inputBase, len - i - 1);
            }

            return num.ToString();
        }

        static private string convertFromDecimal(string inputStr, int outputBase)
        {
            int quotient = Int32.Parse(inputStr);
            Stack resStack = new Stack();

            while (quotient > 0)
            {
                int rem = quotient % outputBase;

                if (rem > 9)
                    resStack.Push(convertToLetter(rem));
                else
                    resStack.Push(rem);

                quotient /= outputBase;
            }

            var builder = new StringBuilder();

            if (outputBase == 16)
                builder.Append("0x");

            foreach(var e in resStack)
            {
                builder.Append(e);
            }

            return builder.ToString();
        }

        static private char convertToLetter(int num)
        {
            switch (num)
            {
                case 10: return 'A';
                case 11: return 'B';
                case 12: return 'C';
                case 13: return 'D';
                case 14: return 'E';
                case 15: return 'F';

                default: return '0';
            }
        }
    }
}
