using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StemStudentUtil.UnitConverter
{
    class UnitUtilities
    {


        static public void setComboBoxes(string selection)
        {
            switch (selection)
            {
                case "Data": 
                    break;
                case "Energy": return;
                case "Length": return;
                case "Mass": return;
                case "Temperature": return;
                case "Time": return;
                case "Other": return;
            }
        }
    }
}
