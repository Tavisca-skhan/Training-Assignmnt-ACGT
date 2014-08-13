using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codejam1
{
    class Program
    {
        static void Main(string[] args)
        {
            string []str= {"ACGTGCA","CATCAT"};
            //string[] str = { "ASDASDASSASD" };
            //Program P = new Program();
          //  Console.WriteLine("hello");
            //Console.WriteLine(P.MinChanges(2,str));
            int x = MinChanges(3, str);
            Console.WriteLine(x);
            Console.ReadKey();
            //  int maxPeriod;
            // Console.WriteLine();

        }
        public static int MinChanges(int maxPeriod, string[] acgt)
        {
            int count = 0;
            int min = 0;
            int l = 1;
            string temp = "";
            for (int i = 0; i < acgt.Length; i++)
            {
                temp += acgt[i];
            }
            while (l <= maxPeriod)
            {
                int k;
                for (k = 0; k < l; k++) 
                for (int i = k; i <= temp.Length - maxPeriod; i = i + l)
                {
                    if (temp[k] != temp[i])
                    {
                        count++;
                    }

                }

                if (min == 0)
                    min = count;

                else if (count < min)
                {
                    min = count;
                }
                l++;
            }
            return min;

        }
    }
}


