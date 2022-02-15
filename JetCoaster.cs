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
            int num = 0;
            int tmq = 0;
            int tmp = 0;

            Queue<int> qu = new Queue<int>();
            for (int i = 0; i < g.Length; i++)
            {  //キューにグループごとの人数を追加
                qu.Enqueue(g[i]);
            }
            while (r > 0)
            {
                for (int n = 0; n < g.Length; n++)
                {
                    tmq += qu.Peek();  //行列の先頭を取得(取出さない)
                    if (tmq <= k)  //取出したグループの人数が定員以下の時
                    { 
                        tmp = qu.Dequeue(); //値を取得(削除する)
                        num += tmp;
                        qu.Enqueue(tmp);  //値を代入
                    }
                    else
                    {
                        break;
                    }
                }
                tmq = 0;
                r--;
            }
            return num;
        }
            
    }
}
