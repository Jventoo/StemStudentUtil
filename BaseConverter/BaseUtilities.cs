using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StemStudentUtil.BaseConverter
{
    class BaseUtilities
    {
        static public string convertInput(int input, int inputBase, int outputBase)
        {
            return (inputBase + outputBase).ToString();
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
    }
}
