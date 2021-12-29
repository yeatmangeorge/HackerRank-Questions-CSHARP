using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Questions__CSHARP_
{
    internal class CountingSort1
    {
        class Result
        {

            /*
             * Complete the 'countingSort' function below.
             *
             * The function is expected to return an INTEGER_ARRAY.
             * The function accepts INTEGER_ARRAY arr as parameter.
             */


            public static List<int> countingSort(List<int> arr)
            {
                List<int> resultsList=new List<int>(100);
                resultsList.AddRange(Enumerable.Repeat(0, 100));

                foreach (int i in arr)
                {
                    resultsList[i]++;
                }

                return resultsList;
            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
            }
        }
    }
}
