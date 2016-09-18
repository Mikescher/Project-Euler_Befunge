<Query Kind="Program" />

/*
The proper divisors of a number are all the divisors excluding the number itself.
For example, the proper divisors of 28 are 1, 2, 4, 7, and 14.
As the sum of these divisors is equal to 28, we call it a perfect number.

Interestingly the sum of the proper divisors of 220 is 284 and the sum of the
proper divisors of 284 is 220, forming a chain of two numbers.
For this reason, 220 and 284 are called an amicable pair.

Perhaps less well known are longer chains.
For example, starting with 12496, we form a chain of five numbers:

~~~
12496 -> 14288 -> 15472 -> 14536 -> 14264 (-> 12496 -> ...)
~~~

Since this chain returns to its starting point, it is called an amicable chain.

Find the smallest member of the longest amicable chain with no element exceeding one million.
*/

// => 14316

const int MAX = 1000 * 1000;

void Main()
{
	Euler().Dump();
}

//int SumDivisors(int x) => SumDivisors1(x);  // 2500 ms
//int SumDivisors(int x) => SumDivisors2(x);  // 0750 ms
int SumDivisors(int x) => SumDivisors3(x);    // 0250 ms

int Euler()
{
	bool[] cache = new bool[MAX];
	int maxLength = 0;
	int shortestMLElement = MAX;

	List<int> path = new List<int>();
	for (int start = 6; start < MAX; start++)
	{
		if (cache[start]) continue;

		path.Clear();
		path.Add(start);

		int curr = SumDivisors(start);
		for (; curr > 0 && curr < MAX && curr != start; curr = SumDivisors(curr))
		{
			bool fe_f = false;
			int fe_c = 0;
			for (int i = 0; i < path.Count; i++)
			{
				if (path[i] == curr)
				{
					fe_f = true;
					fe_c = path.Count - i;

					(" > " + path.Skip(i).Select(p => $"{p}").Concat(new List<string>() { $"({curr})" }).Aggregate((a,b)=>a+" "+b)).Dump();
					"".Dump();
					
					if (fe_c > maxLength) { maxLength = fe_c; shortestMLElement = path[i]; }
					else break;
				}

				//cache[pel] = fe_f ? fe_c : -1;
				if (fe_f && shortestMLElement > path[i]) shortestMLElement = path[i];
			}
			
			if (fe_f) break;
			
			if (cache[curr])
			{
				break;
			}

			path.Add(curr);
			cache[curr] = true;
		}
	}
	
	return shortestMLElement;
}

#region SumDivisors1

int LeastPower(int a, int x)
{
	int b = a;
	while (x % b == 0) b *= a;
	return b;
}

int SumDivisors1(int x)
{
	int t = x;
	int result = 1;

	//  Handle two specially.
	{
		int p = LeastPower(2, t);
		result *= p - 1;
		t /= p / 2;
	}

	//  Handle odd factors.
	for (int i = 3; i * i <= t; i += 2)
	{
		int p = LeastPower(i, t);
		result *= (p - 1) / (i - 1);
		t /= p / i;
	}

	//  At this point, t must be one or prime.
	if (1 < t)
		result *= 1 + t;

	return result - x;
}

#endregion

#region SumDivisors2

int[] P = null;

int SumDivisors2(int n)
{
	if (P == null) P = ESieve((int)Math.Ceiling(Math.Sqrt(MAX)));

	int sum = 1;
	int x = n;
	for (int i = 0; i < P.Length; ++i)
	{
		if (P[i] > x / P[i]) break;    	/* remaining primes won't divide x */
		if (x % P[i] == 0)
		{           					/* P[i] is a divisor of n */
			int sub = P[i] + 1;   		/* add in power of P[i] */
			x /= P[i];                 	/* reduce x by P[i] */
			while (x % P[i] == 0)
			{    						/* while P[i] still divides x */
				x /= P[i];             	/* reduce x */
				sub = sub * P[i] + 1;  	/* add by another power of P[i] */
			}
			sum *= sub;                	/* product of sums */
		}
	}
	if (x > 1) sum *= x + 1;           	/* if x > 1, then x is prime */
	return sum - n;
}

public int[] ESieve(int upperLimit)
{
	int sieveBound = (int)(upperLimit - 1) / 2;
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

#endregion

#region SumDivisors3

int[] S = null;

int[] DivSieve()
{
	int[] r = new int[MAX];
	
	for (int i = 1; i <= MAX/2; i++)
	{
		for (int j = 2; i*j < MAX; j++)
		{
			r[i*j] += i;
		}
	}
	
	return r;
}

int SumDivisors3(int x)
{
	if (S == null) S = DivSieve();
	
	return S[x];
}

#endregion