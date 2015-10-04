<Query Kind="Program" />

/*
It is possible to write ten as the sum of primes in exactly five different ways:

~~~
7 + 3
5 + 5
5 + 3 + 2
3 + 3 + 2 + 2
2 + 2 + 2 + 2 + 2
~~~

What is the first value which can be written as the sum of primes in over five thousand different ways?
*/

const int MAX = 100;

const int LIMIT = 5000;

void Main()
{
	Extended();	
}

void Extended()
{
	int[] primes = ESieve(MAX + 1);

	int[,] cache = new int[MAX + 1, primes.Length]; // sum, last_summand (index)
	
	for (int sum = 1;; sum++)
	{
		int total = 0;
		for (int n = 0; n < primes.Length && primes[n] <= sum; n++)
		{
			int summand = primes[n];
			int rem = sum - summand;
			
			if (rem > 0)
			{
				int count = 0;
				for (int v = n; v >= 0; v--)
				{
					count += cache[rem, v];
				}
				cache[sum, n] = count;
				total += count;
				
				//string.Format("{0} = {1} + {{{2}}}", sum, summand, count).Dump();
			}
			else
			{
				cache[sum, n] = 1;
		
				//string.Format("{0} = {0}", sum).Dump();
			}
		}
		if (total > LIMIT)
		{
			//cache.Dump();
			sum.Dump();
			return;
		}
	}
}

public int[] ESieve(int upperLimit) {

  int sieveBound = (int)(upperLimit - 1) / 2;
  int upperSqrt = ((int)Math.Sqrt(upperLimit) - 1) / 2;

  BitArray PrimeBits = new BitArray(sieveBound + 1, true);

  for (int i = 1; i <= upperSqrt; i++) {
      if (PrimeBits.Get(i)) {
          for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1) {
              PrimeBits.Set(j, false);
          }
      }
  }

  List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
  numbers.Add(2);
  for (int i = 1; i <= sieveBound; i++) {
      if (PrimeBits.Get(i)) {
          numbers.Add(2 * i + 1);
      }
  }

  return numbers.ToArray();
}

/*
For an extended explanation please look at problem-076, it's basically the same..

Yet again we remember already caclulated values in an grid.
The only difference is now that our y-axis is the prime index (We generate a few primes with an [Sieve of Eratosthenes](https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes)).

And once we find a number which count is greater five thousand we abort and print this number.

The only mayor difference to problem-076 is that now not every summand is valid.
It is possible that you can use `prime[7]` but not `prime[6]`.
So we have to look at each possible summand individually.
This makes unfortunately the optimization where we remember the sum of all values invalid.
*/