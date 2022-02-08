using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     public class kuriage
    {
        public static int kurigae10(int j)
        {
            if (j==0)
            {
                return j;
            }
            else if (j % 10 > 0)
            {

                return j - (j % 10) + 10;

            }
            else if (0 > j % 10)

            {
                return j - (j % 10) - 10;
            }
            return j;
        }
    }
}
