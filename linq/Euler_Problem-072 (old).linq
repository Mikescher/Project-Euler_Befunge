<Query Kind="Program" />

/*
Consider the fraction, `n/d`, where `n` and `d` are positive integers. If `n<d` and `HCF(n,d)=1`, it is called a reduced proper fraction.

If we list the set of reduced proper fractions for `d <= 8` in ascending order of size, we get:

~~~
1/8, 1/7, 1/6, 1/5, 1/4, 2/7, 1/3, 3/8, 2/5, 3/7, 1/2, 4/7, 3/5, 5/8, 2/3, 5/7, 3/4, 4/5, 5/6, 6/7, 7/8
~~~

It can be seen that there are 21 elements in this set.

How many elements would be contained in the set of reduced proper fractions for `d <= 1,000,000`?

*/

const int SIZE = 100;

void Main()
{
	// 00 => not set
	// +1 => proper
	// -1 => can be reduced
	// -2 => invalid
	var sieve = new sbyte[SIZE, SIZE]; 
	
	int result = 0;
	
	int direction = -1;
	int n = 0;
	int d = 0;
	while (n < SIZE && d < SIZE)
	{
		//("{"+n+"|"+d+"} " + ((sieve[n, d] == 0)?"+":"-")).Dump();
		
		if (d <= n)
		{
			sieve[n, d] = -2;
		} 
		else if (sieve[n, d] == 0)
		{
			sieve[n, d] = 1;
			result++;
				
			int i_n = 2*(n+1);
			int i_d = 2*(d+1);
			
			while (i_n <= SIZE && i_d <= SIZE)
			{
				sieve[i_n-1, i_d-1] = -1;
			
				i_n += n+1;
				i_d += d+1;
			}
		}
		
		n += direction;
		d -= direction;
		
		if (n < 0 || d >= SIZE)
		{
			direction = -direction;
			n++;
			
			if (d >= SIZE)
			{
				n += direction;
				d -= direction;
			}
		}
		else if (d < 0 || n >= SIZE)
		{
			direction = -direction;
			d++;
			
			if (n >= SIZE)
			{
				n += direction;
				d -= direction;
			}
		}
	}
	
	result.Dump();
	
	sieve.Dump();
	
	for (int nn = 0; nn < SIZE; nn++) for (int dd = 0; dd < SIZE; dd++) if (sieve[nn, dd] == 1) ((nn+1) + "/" + (dd+1)).Dump();
}