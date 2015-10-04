<Query Kind="Program" />

/*
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*/

const long COMP = 600851475143;

void Main()
{
	long value = 1;

	for (long mult = 1; mult <= 20; mult++)
	{
		string.Format("{1,10}  -->  MULT BY {0,2}  -->  {2,10} X", mult, value, value * mult).Dump();
		value *= mult;

		for (long divisor = 2; divisor <= 20; divisor++)
		{
			while (value % divisor == 0 && LRange(1, mult).All(p => (value / divisor) % p == 0))
			{
				string.Format("{1,10}  -->  div  by {0,2}  -->  {2,10}", divisor, value, value / divisor).Dump();
				value /= divisor;
			}
		}
	}

	"".Dump();
	value.Dump();
}

IEnumerable<long> LRange(long start, long count)
{
	for (long i = 0; i < count; i++) yield return start + i;
}