using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Questions__CSHARP_
{
	internal class Result
	{

		public static int diagonalDifference(List<List<int>> arr)
		{
			int sumOfLeftToRight = 0;
			int sumOfRightToLeft = 0;

			for(int i = 0; i < arr.Count; i++)
            {
				sumOfLeftToRight += arr[i][i];
            }

			int x = 0;

			for(int y = arr.Count-1;y>=0; y--)
            {
				sumOfRightToLeft += arr[x][y];
				x++;
            }
			return Math.Abs(sumOfLeftToRight-sumOfRightToLeft);
		}
	}

    class Solution
    {
        public static void Main(string[] args)
        {
			List<int> a = new List<int>{ 1,2,3};
			List<int> b = new List<int>{ 4,5,6};
			List<int> c = new List<int>{ 9,8,10};

			List<List<int>> test = new List<List<int>> { a,b,c};

			Console.WriteLine(Result.diagonalDifference(test));
		}
    }
}