<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

/*
It is well known that if the square root of a natural number is not an integer, then it is irrational. 
The decimal expansion of such square roots is infinite without any repeating pattern at all.

The square root of two is `1.41421356237309504880...`, 
and the digital sum of the first one hundred decimal digits is `475`.

For the first one hundred natural numbers, 
find the total of the digital sums of the first one hundred decimal digits for all the irrational square roots.
*/

// https://en.wikipedia.org/wiki/Methods_of_computing_square_roots#Digit-by-digit_calculation

void Main()
{
	Enumerable
		.Range(1, 99)
		.Where(p => Math.Sqrt(p) %1 != 0)
		.Select(p => DRoot(p, 100).Sum())
		.Sum()
		.Dump();
	
}

IEnumerable<int> DRoot(int r, int dc)
{
	BigInteger c = r;
	BigInteger p = 0;

	for (BigInteger ii = 0; ii < dc; ii++)
	{
		int x = 0;

		while (x * (20 * p + x) <= c)
		{
			x++;
		}
		x--;
		
		yield return (int)x;
		
		//string.Format("c:{0}  x:{1}  y:{2}  p:{3}  rem:{4}", c, x, y, p, rem).Dump();
		
		c = 100*c  - 2000*p*x - 100*x*x;
		
		p = p*10 + x;
	}
}

/*
A short look to [Wikipedia](https://en.wikipedia.org/wiki/Methods_of_computing_square_roots#Digit-by-digit_calculation) finds us a neat algorithm to calculate the square-root digit-by-digit.

I have optimized it a little bit with the target to use not so many variables:

~~~
IEnumerable<int> DRoot(int r)
{
	BigInteger c = r;
	BigInteger p = 0;
	int x = 0;

	for (ii = 0; ii < 100; ii++)
	{	
		for (x = 0;(x+1)*(20*p + (x+1)) <= c;x++);
		c = 100*c  - 2000*p*x - 100*x*x;
		p = p*10 + x;
	}
	
	return p;
}
~~~

The algorithm is pretty simple, but *god* do I hate long addition/multiplication in Befunge.

We need 120 base-10 digits for the numbers `p`and `c`.
In our program we use base-100 notation. This way we can fit the numbers in a single befunge-93 row 
**and** can simply multiply by 100 with a single left shift operation.

*/