using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class JetCoaster
    {
        public static int ride(int k,int[] g,int r)
        {
            int x = 0;
            int n = 0;
            int num = 0;
            int s = 0;
            
            while (r > 0)
            {
                for (int h = 0; h < g.Length; h++)
                {
                    s += g[h];
                }
                if (k > s)
                {
                    k = s;
                }
                else
                {
                    s = 0;
                }
                for (int i = n; k >= x + g[i % g.Length]; i++)
                {
                    x += g[i % g.Length];
                    n = i%g.Length+1;
                }
                num += x;
                x = 0;
                r--;
            }
                return num;
        }
    }
}
