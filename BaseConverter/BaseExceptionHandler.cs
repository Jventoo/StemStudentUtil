using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StemStudentUtil.BaseConverter
{
    class BaseExceptionHandler
    {
        const int MAX_BASE_NUMBER = 20;

        public bool checkInput(string input, out int inputNum)
        {
            int temp = 0;
            bool parse = Int32.TryParse(input, out temp);

            if (!parse)
            {
                inputNum = -1;
                return false;
            }

            inputNum = temp;
            return true;
        }

        public bool checkCustomBaseInput(string input, out int baseNum)
        {
            int temp = 0;
            bool parse = Int32.TryParse(input, out temp);


            if (!parse || temp == 0 | (temp - MAX_BASE_NUMBER > 0))
            {
                baseNum = -1;
                return false;
            }

            baseNum = temp;
            return true;
        }
    }
}
