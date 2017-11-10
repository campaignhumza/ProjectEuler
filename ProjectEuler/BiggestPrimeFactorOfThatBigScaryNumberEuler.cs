using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
	static class BiggestPrimeFactorOfThatBigScaryNumberEuler
	{

		public static long BiggestPrimeFactorOfThatBigScaryNumber(long scaryNum)
		{
			long max = 0;
			long res = scaryNum;
				for (long i = 2; i <= res; i++)
				{
					if (res <= 1)
					{
						break;
					}
					if ((res % i == 0) && IsPrime(i))
					{
						max = i;
						res = res / i;
					}
				}
			return max;
		}

		public static bool IsPrime(long x)
		{
			for (int i = 2; i < x; i++)
			{
				if (x % i == 0)
				{
					return false;
				}
			}

			return true;
		}
	}
}
