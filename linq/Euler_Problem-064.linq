<Query Kind="Program" />

/*
All square roots are periodic when written as continued fractions and can be written in the form:

~~~
sqrt(N) = a0 + 1 / (a1 + 1 / (a2 + 1 / (a3 + ... )))
~~~

For example, let us consider `sqrt(23)`:

~~~
sqrt(23) 
 = 4 + sqrt(23) - 4 
 = 4 + 1 / ( 1 / ( sqrt(23) - 4 ) )	
 = 4 + 1 / ( 1 + ( sqrt(23) - 3 ) / 7)
~~~

If we continue we would get the following expansion:
~~~
sqrt(23) = 4 + 1/(1 + 1/(3 + 1/(1 + 1/(8 + ... ))))
~~~

The process can be summarised as follows:

     |                        |                         |                     
-----|------------------------|-------------------------|----------------------
`a0` | `4`, `1/(sqrt(23) - 4` | `1*(sqrt(23) + 4) /  7` | `1 + (sqrt(23) - 3)/7`
`a1` | `1`, `7/(sqrt(23) - 3` | `7*(sqrt(23) + 3) / 14` | `3 + (sqrt(23) - 3)/2`
`a2` | `3`, `2/(sqrt(23) - 3` | `2*(sqrt(23) + 3) / 14` | `1 + (sqrt(23) - 4)/7`
`a3` | `1`, `7/(sqrt(23) - 4` | `7*(sqrt(23) + 4) /  7` | `8 + (sqrt(23) - 4)/1`
`a4` | `8`, `1/(sqrt(23) - 4` | `1*(sqrt(23) + 4) /  7` | `1 + (sqrt(23) - 3)/7`
`a5` | `1`, `7/(sqrt(23) - 3` | `7*(sqrt(23) + 3) / 14` | `3 + (sqrt(23) - 3)/2`
`a6` | `3`, `2/(sqrt(23) - 3` | `2*(sqrt(23) + 3) / 14` | `1 + (sqrt(23) - 4)/7`
`a7` | `1`, `7/(sqrt(23) - 4` | `7*(sqrt(23) + 4) /  7` | `8 + (sqrt(23) - 4)/1`

It can be seen that the sequence is repeating. For conciseness, we use the notation `sqrt(23) = [4;(1,3,1,8)]`, to indicate that the block `(1,3,1,8)` repeats indefinitely.

The first ten continued fraction representations of (irrational) square roots are:

~~~
sqrt( 2) = [1;(2)],         period=1
sqrt( 3) = [1;(1,2)],       period=2
sqrt( 5) = [2;(4)],         period=1
sqrt( 6) = [2;(2,4)],       period=2
sqrt( 7) = [2;(1,1,1,4)],   period=4
sqrt( 8) = [2;(1,4)],       period=2
sqrt(10) = [3;(6)],         period=1
sqrt(11) = [3;(3,6)],       period=2
sqrt(12) = [3;(2,6)],       period=2
sqrt(13) = [3;(1,1,1,1,6)], period=5
~~~

Exactly four continued fractions, for `N <= 13`, have an odd period.

How many continued fractions for `N <= 10000` have an odd period?
*/

void Main()
{
	Enumerable
		.Range(1,10000)
		.Select(p => GetContinuedFraction(p, 0, 1))
		.Where(p => p.Count() % 2 == 0)
		.Count()
		.Dump();
}

// https://en.wikipedia.org/wiki/Integer_square_root
int isqrt(int n)
{
	int pxk = 0;
	int xk = n;
	for(;;)
	{
		int nxk = (xk + n/xk)/2;
		
		if (nxk == xk)  return xk;
		if (nxk == pxk) return xk;
		
		pxk = xk;
		xk = nxk;
	}
}

IEnumerable<int> GetContinuedFraction(int sqrt, int add, int div)
{
	if (Math.Pow(isqrt(sqrt), 2) == sqrt)
	{
		yield return isqrt(sqrt);
		yield break;
	}	

	for(int idx = 0;;idx++)
	{
		int s1_m = (isqrt(sqrt)+add)/div;
	
		yield return s1_m;

		add  = s1_m*div - add;
	
		if (div == 1 && idx > 0) break;
	
		div = (sqrt - add*add) / div;
	}
}