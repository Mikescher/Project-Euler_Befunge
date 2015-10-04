<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

/*
The square root of 2 can be written as an infinite continued fraction.

~~~
sqrt(2) = 1 + 1/(2 + 1/(2 + 1/(2 + 1/(2 + ...))))
~~~
The infinite continued fraction can be written, `sqrt(2) = [1;(2)]`, `(2)` indicates that `2` repeats ad infinitum.
In a similar way, `sqrt(23) = [4;(1,3,1,8)]`.

It turns out that the sequence of partial values of continued fractions for square roots provide the best rational approximations.
Let us consider the convergents for `sqrt(2)`.

~~~
1 + 1/2                      = 3/2
1 + 1/(2+ 1/2)               = 7/5
1 + 1/(2+ 1/(2+ 1/2))        = 17/12
1 + 1/(2+ 1/(2+ 1/(2+ 1/2))) = 41/29
~~~

Hence the sequence of the first ten convergents for `sqrt(2)` are:
~~~
1, 3/2, 7/5, 17/12, 41/29, 99/70, 239/169, 577/408, 1393/985, 3363/2378, ...
~~~

What is most surprising is that the important mathematical constant,

~~~
e = [2; 1,2,1, 1,4,1, 1,6,1 , ... , 1,2k,1, ...]
~~~

The first ten terms in the sequence of convergents for `e` are:
~~~
2, 3, 8/3, 11/4, 19/7, 87/32, 106/39, 193/71, 1264/465, 1457/536, ...
~~~

The sum of digits in the numerator of the 10th convergent is `1+4+5+7=17`.

Find the sum of digits in the numerator of the 100th convergent of the continued fraction for `e`.
*/

void Main()
{
	DumpFrac(100);
}

void DumpFrac(int prec)
{
	BigInteger top = 0;
	BigInteger bot = 1;
	
	for(prec-- ;prec >= 0; prec--)
	{
		BigInteger frac = GetFrac(prec);
		
		top += bot*frac;
		
		BigInteger temp = top;top=bot;bot=temp;
		
		//(bot + " / " + top).Dump();
	}
	
	(bot + " / " + top).Dump();
		
	"".Dump();
	bot.ToString().ToCharArray().Select(p => p - '0').Sum().Dump();
}

int GetFrac(int idx)
{
	if (idx == 0) return 2;
	if ((idx-1) % 3 == 0) return 1;
	if ((idx-1) % 3 == 1) return ((idx+1)/3)*2;
	if ((idx-1) % 3 == 2) return 1;
	return 2;
}