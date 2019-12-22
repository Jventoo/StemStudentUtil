using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StemStudentUtil.BaseConverter
{
    class BaseExceptionHandler
    {
        public const int MAX_BASE_NUMBER = 16;

        
        /* Check if supplied input is alphanumerical using only letters A - F.
           Converts lowercase letters to upper if needed. Returns corrected string in output param */
        public bool checkInput(string input, out string newSTR)
        {
            var builder = new StringBuilder();

            foreach (char c in input)
            {
                int charVal = c;

                if (charVal > 96 && charVal < 103)
                    builder.Append(char.ToUpper(c));
                else if ((charVal > 47 && charVal < 58) || (charVal > 64 && charVal < 71))
                    builder.Append(c);
                else
                {
                    newSTR = "INVALID";
                    return false;
                }
            }

            newSTR = builder.ToString();
            return true;
        }

        // Check if the input string's characters are consistent with its base
        public bool checkIfInputConsistent(string input, int numeralBase)
        {
            int upperBound = 0, lowerBound = 47;

            if (numeralBase < 11)
            {
                switch (numeralBase)
                {
                    case 0:
                        return false;

                    case 1:
                        lowerBound = 48;
                        upperBound = 50;
                        break;

                    default:
                        upperBound = 48 + numeralBase;
                        break;
                }
            }
            else
            {
                upperBound = 55 + numeralBase;
            }

            foreach (char c in input)
            {
                int charVal = c;
                if (charVal >= upperBound || charVal <= lowerBound)
                    return false;
            }

            return true;
        }

        public bool checkCustomBaseInput(string input, out int baseNum)
        {
            int temp = 0;
            bool parse = Int32.TryParse(input, out temp);


            if (!parse /*|| temp == 0*/ || (temp - MAX_BASE_NUMBER > 0))
            {
                baseNum = -1;
                return false;
            }

            baseNum = temp;
            return true;
        }
    }
}
