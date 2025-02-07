using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    public static class InputHelper
    {

        public static bool ValidateInputInt(out int result, int min = 1)
        {

            bool valid = int.TryParse(Console.ReadLine(), out result);
            if (!valid || result < min)
            {
                Console.WriteLine($" enter  value >= {min} ");
                return false;
            }
            return true;
        }

        public static bool ValidateInputDouble(out double result, double min = 0)
        {

            bool valid = double.TryParse(Console.ReadLine(), out result);
            if (!valid || result < min)
            {
                Console.WriteLine($" the value must be Number and >= {min}.");
                return false;
            }
            return true;
        }

    }
}
