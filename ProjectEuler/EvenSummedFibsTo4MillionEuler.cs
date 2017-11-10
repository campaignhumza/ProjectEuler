using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
	static class EvenSummedFibsTo4MillionEuler
	{

		public static long EvenSummedFibsTo4Million()
		{
			long sum = 0;
			long prevprev = 0;
			long prev = 1;
			long next;
			while (prevprev < 4000000)
			{
				next = prevprev + prev;
				if (next % 2 == 0)
				{
					sum += next;
				}
				prevprev = prev;
				prev = next;
			}
			return sum;
		}

	}
}
