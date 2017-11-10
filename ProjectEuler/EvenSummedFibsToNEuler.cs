

namespace ProjectEuler
{
	static class EvenSummedFibsToNEuler
	{

		public static long EvenSummedFibsToN(int n)
		{
			long sum = 0;
			long prevprev = 0;
			long prev = 1;
			long next;
			while (prevprev < n)
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
