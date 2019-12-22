using System;
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
            return "";
        }

        static private string convertFromDecimal(string inputStr, int outputBase)
        {
            return "";
        }
    }
}
