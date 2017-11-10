
namespace ProjectEuler
{
	class LargestPalindromeOf3DigitMultiplicationEuler
	{

		public static int LargestPalindromeOf3DigitMultiplication()
		{
			return 5;
		}

		public static bool IsPalindrome(int bitchIMightBe)
		{
			var strnum = bitchIMightBe.ToString().ToCharArray();

			for( int i = 0, len = strnum.Length; i < (len / 2); i++)
			{
				if (strnum[0] != strnum[len - 1 - i])
				{
					return false;
				}
			}
			return true;
		}
	}
}
