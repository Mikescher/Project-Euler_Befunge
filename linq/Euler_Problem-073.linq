<Query Kind="Program" />

/*
Consider the fraction, `n/d`, where n and d are positive integers. If `n<d` and `HCF(n,d)=1`, it is called a reduced proper fraction.

If we list the set of reduced proper fractions for `d <= 8` in ascending order of size, we get:

~~~
1/8, 1/7, 1/6, 1/5, 1/4, 2/7, 1/3, 3/8, 2/5, 3/7, 1/2, 4/7, 3/5, 5/8, 2/3, 5/7, 3/4, 4/5, 5/6, 6/7, 7/8
~~~

It can be seen that there are 3 fractions between `1/3` and `1/2`.

How many fractions lie between `1/3` and `1/2` in the sorted set of reduced proper fractions for `d <= 12,000`?
*/

const int LIMIT = 50; // 12000;
const int MODULO = LIMIT/2 - LIMIT/3;

void Main()
{
	bool[,] cache = new bool[MODULO, LIMIT+1];
	(MODULO+" x "+(LIMIT+1)+" = "+(MODULO*(LIMIT+1)) + " // "+((MODULO*(LIMIT+1))/(1024.0*1024)) + " MB").Dump();
	
	int frac_count = 0;
	
	for (int d = 1; d <= LIMIT; d++)
	{
		int low = d/3;
		int up  = (d+1)/2;
		
		for (int n = low+1; n < up; n++)
		{
			if (!cache[n%MODULO, d])
			{
				frac_count++;
				
				int nn = n;
				int dd = d;
				
				while(nn <= LIMIT && dd <= LIMIT)
				{
					cache[nn%MODULO, dd] = true;
					nn+=n;
					dd+=d;
				}
			}
		}
	}
	
	frac_count.Dump();
}