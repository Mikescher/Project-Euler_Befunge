<Query Kind="Program" />

/*
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
*/

const long COMP = 600851475143;

void Main()
{
	long start = (long)(Math.Sqrt(COMP) - Math.Sqrt(COMP)%2 + 1);

	for (long c = start; ; c-=2)
	{
		if (COMP % c == 0 && LRange(2, c/2).All(p => c % p != 0))
		{
			c.Dump();
			return;
		}
	}
}

IEnumerable<long> LRange(long start, long count)
{
	for (long i = 0; i < count; i++) yield return start + i;
}