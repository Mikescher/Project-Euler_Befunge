<Query Kind="Program" />

/*
Consider the fraction, `n/d`, where `n` and `d` are positive integers. If `n<d` and `HCF(n,d)=1`, 
it is called a reduced proper fraction.
If we list the set of reduced proper fractions for `d <= 8` in ascending order of size, we get:

~~~
1/8, 1/7, 1/6, 1/5, 1/4, 2/7, 1/3, 3/8, 2/5, 3/7, 1/2, 4/7, 3/5, 5/8, 2/3, 5/7, 3/4, 4/5, 5/6, 6/7, 7/8
~~~

It can be seen that `2/5` is the fraction immediately to the left of `3/7`.

By listing the set of reduced proper fractions for `d <= 1,000,000` in ascending order of size, 
find the numerator of the fraction immediately to the left of `3/7`.
*/

void Main()
{
	long result_d = 0;
	long result_n = 0;
	
	long dist_num = 1;
	long dist_denom = 1;
	
	for (long i = 1; i <= 1000000; i++)
	{
		if ((i*3)%7 == 0) continue;
		
		{
			var c_d = (i*3)/7 + 0;
			var c_n = i;
			
			var d_n = Math.Abs(c_d * 7 - 3 * c_n);
			var d_d = c_n * 7;
			
			if (d_n * dist_denom < dist_num * d_d)
			{
				dist_num = d_n;
				dist_denom = d_d;
				result_d = c_d;
				result_n = c_n;
			}
		}
	}
	
	for (int i = 1; i < result_d; i++)
	{
		if (result_n%i == 0 && result_d % i == 0)
		{
			result_n /= i;
			result_d /= i;
		}
	}
	
	result_d.Dump();
	new string('-', Math.Max(result_d.ToString().Length, result_n.ToString().Length)).Dump();
	result_n.Dump();
}