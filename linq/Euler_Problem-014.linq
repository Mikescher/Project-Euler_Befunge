<Query Kind="Program" />

/*
The following iterative sequence is defined for the set of positive longegers:

~~~
n -> n/2 (n is even)
n -> 3n + 1 (n is odd)
~~~

Using the rule above and starting with 13, we generate the following sequence:
`13 -> 40 -> 20 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1`

It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms.
Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under one million, produces the longest chain?

*NOTE: Once the chain starts the terms are allowed to go above one million.*
*/

const long LIMIT = 1 * 1000 * 1000;

void Main()
{
	long max_c = 0;
	long max_n = 0;

	bool[] cache = new bool[LIMIT];
	
	for (long x = 1; x < LIMIT; x++)
	{
		if (cache[x]) continue;
	
		long n = x;
		long c = 1;
		while (n > 1)
		{
			if (n % 2 == 0) n = n/2;
			else n = 3*n + 1;

			c++;

			if (n < LIMIT) cache[n] = true;
		}
		
		if (c > max_c)
		{
			max_n = x;
			max_c = c;
		}
	}
	
	string.Format("{0} ({1})", max_n, max_c).Dump();
}