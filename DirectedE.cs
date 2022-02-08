using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DirectedE
    {
        public static int[] SEARCH(int[] edgeFirst,int[] edgeNext,int j)
        {
            const int N = 6;
            const int M = 8;
            int[] start = new int[] { 1, 2, 3, 4, 2, 5, 4, 6 };
            int[] end = new int[] { 2, 3, 4, 1, 5, 4, 6, 2 };
            int[] current = new int[N];
            int[] serched = new int[M];
            int[] path = new int[M];

            for (int i = 0; i < N; i++)
            { 
                current[i] = edgeFirst[i];
            }

            int top = 1; 
            int last = M; 
            while (last >= 1)
            {
                int temp;
                if (current[j - 1] != 0)
                {
                    temp = current[j - 1];
                    serched[top - 1] = temp;
                    current[j - 1] = edgeNext[temp - 1];
                    j = end[temp - 1];
                    top++;
                }
                else
                {
                    top--;
                    temp = serched[top - 1];
                    path[last - 1] = temp;
                    j = start[temp - 1];
                    last--;
                }
            }
            return path;
        }
    }
}
