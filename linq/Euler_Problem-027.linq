<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

/*
Euler discovered the remarkable quadratic formula:

~~~
n^2 + n + 41
~~~

It turns out that the formula will produce 40 primes for the consecutive values n = 0 to 39.
However, when `n = 40`, `402 + 40 + 41 = 40(40 + 1) + 41` is divisible by 41, and certainly when `n = 41`, `41^2 + 41 + 41` is clearly divisible by 41.

The incredible formula  `n^2 - 79n + 1601` was discovered, which produces 80 primes for the consecutive values n = 0 to 79. The product of the coefficients, -79 and 1601, is -126479.

Considering quadratics of the form:

~~~
n^2 + an + b, where |a| < 1000 and |b| < 1000
~~~

where `|n|` is the modulus/absolute value of n
e.g. `|11| = 11` and `|-4| = 4`

Find the product of the coefficients, a and b, for the quadratic expression that produces the maximum number of primes for consecutive values of n, starting with `n = 0`.
*/

const int LIMIT = 1000;

void Main()
{
	int max_count = -1;
	int max_coeff = -1;

	var SIEVE = new HashSet<int>(ESieve(LIMIT*LIMIT).ToList());
	
	for (int a = -LIMIT; a < LIMIT; a++)
	{
		if (a % 2 == 0) continue;
		
		foreach (var b in SIEVE.TakeWhile(bb => bb < LIMIT))
		{
			int ccc = Enumerable.Range(0, int.MaxValue).TakeWhile(n => SIEVE.Contains(n * n + a * n + b)).Count();
		
			if (ccc > max_count)
			{
				max_count = ccc;
				max_coeff = a*b;
			}
		}
	}
	
	string.Format("{0} ({1})", max_coeff, max_count).Dump();
}

public int[] ESieve(int upperLimit)
{
	int sieveBound = (upperLimit - 1) / 2;
	int upperSqrt = ((int)Math.Sqrt(upperLimit) - 1) / 2;

	BitArray PrimeBits = new BitArray(sieveBound + 1, true);

	for (int i = 1; i <= upperSqrt; i++)
	{
		if (PrimeBits.Get(i))
		{
			for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1)
			{
				PrimeBits.Set(j, false);
			}
		}
	}

	List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
	numbers.Add(2);
	for (int i = 1; i <= sieveBound; i++)
	{
		if (PrimeBits.Get(i))
		{
			numbers.Add(2 * i + 1);
		}
	}

	return numbers.ToArray();
}