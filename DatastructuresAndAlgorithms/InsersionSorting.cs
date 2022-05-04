using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresAndAlgorithms
{
    class InsersionSorting
    {
        public static void insersionsort(int[] data, int n)
        {
            int i, j;
            
            for (i = 1; i < n; i++)
            {
               int item = data[i];
                int ins = 0;
                for(j = i-1;j>=0 && ins !=1; )
                {
                    if(item<data[j])
                    {
                        data[j+1] = data[j];
                        j--;
                        data[j + 1] = item;
                    }
                    else ins = 1;
                }

            }
        }
    }
}

    
