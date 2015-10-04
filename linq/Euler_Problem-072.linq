<Query Kind="Program" />

/*
Consider the fraction, `n/d`, where `n` and `d` are positive integers.
If `n<d` and `HCF(n,d)=1`, it is called a reduced proper fraction.

If we list the set of reduced proper fractions for `d <= 8` in ascending order of size, we get:

~~~
1/8, 1/7, 1/6, 1/5, 1/4, 2/7, 1/3, 3/8, 2/5, 3/7, 1/2, 4/7, 3/5, 5/8, 2/3, 5/7, 3/4, 4/5, 5/6, 6/7, 7/8
~~~

It can be seen that there are 21 elements in this set.

How many elements would be contained in the set of reduced proper fractions for `d <= 1,000,000`?
*/

const long SIZE = 1000000; // 6000;

void Main()
{
	int[] primes = ESieve((int)SIZE / 2);
	
	int max_len = (int)Math.Log(SIZE, 2);
	
	int[] arr = new int[max_len];
	int pos = 0;
	long phi = 1;
	long val = 2;
	
	//long phisum = Enumerable.Range(0, SIZE).Select(x => (long)x).Sum();
	long phisum = (SIZE * SIZE - SIZE) / 2;
	
	for(;;)
	{
		if (val <= SIZE)
		{
			// phisum = phi + phisum - val - 1
			phisum -= val-1;
			phisum += phi;
		}

		if (pos < max_len-1 && val*primes[arr[pos]] <= SIZE)
		{
			pos++;
			arr[pos] = arr[pos-1];
			
			val *= primes[arr[pos]];
			
			phi *= primes[arr[pos]];
		}
		else
		{
			val /= primes[arr[pos]];
			
			if (pos > 0 && arr[pos-1] == arr[pos])
				phi /= primes[arr[pos]];
			else
				phi /= primes[arr[pos]] - 1;

			arr[pos]++;
			
			while(arr[pos] >= primes.Length || val*primes[arr[pos]] > SIZE)
			{
				//arr[pos] = ' ';
				pos--;
				
				if (pos < 0) goto BREAK_OUTER;
				
				val /= primes[arr[pos]];
				
				if (pos > 0 && arr[pos-1] == arr[pos])
				{
					phi /= primes[arr[pos]];
				}
				else
				{
					phi /= primes[arr[pos]] - 1;
				}
					
				arr[pos]++;
			}
			
			val *= primes[arr[pos]];
			phi *= primes[arr[pos]]-1;
		}
	}
	
	BREAK_OUTER:
	
	(">> " + phisum).Dump();
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
Quite a nice problem.

First we need the number of proper reduced fractions for a denominator `d`.
This is the amount of numbers `d<n` with `gcd(d,n) == 1`.
Coincidentally this is again Eulers Phi-Function.

Now we need to find the sum over all phi values from `1` to `1 000 000`.

First we get all the prime numbers from `2` to `limit/2` (with an [Sieve of Eratosthenes](https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes)).
Then we iterate through all possible prime combinations smaller than the limit (practically this is prime factorization).
While we do this we calculate on the side the phi value of these numbers (with the prime factorization this is trivial) and sum these values together.

For all values bigger than `LIMIT/2` where we haven't got a factorization we use `phi(p) = p-1`.
Because these *must* be prime. *(see [Eulers totient function](https://en.wikipedia.org/wiki/Euler's_totient_function))*

The rest is a bit of clever optimization, so this all does not take too long.

 - First we assume every number is prime and calculate the sum of the phi function of all these primes.
   Then when we find a number (that is not a prime) we subtract the old (wrong) value from the result and add the new (correct) value.
 - We abort our loops early when we run into a number `x > limit`. Because every other factor will only increase `x`.
 - The value of phi is always calculated from the last phi value. So we don't need to totally recalculate it in every step.

After looking a little bit around this is not ***the** fastest solution to this problem.
But it's the one I found and I think it's reasonable fast.

*/

/*

		+0	+1 	+2 	+3 	+4 	+5 	+6 	+7 	+8 	+9
		
0+ 	  	#	1 	1 	2 	2 	4 	2 	6 	4 	6
10+ 	4 	10 	4 	12 	6 	8 	8 	16 	6 	18
20+ 	8 	12 	10 	22 	8 	20 	12 	18 	12 	28
30+ 	8 	30 	16 	20 	16 	24 	12 	36 	18 	24
40+ 	16 	40 	12 	42 	20 	24 	22 	46 	16 	42
50+ 	20 	32 	24 	52 	18 	40 	24 	36 	28 	58
60+ 	16 	60 	30 	36 	32 	48 	20 	66 	32 	44
70+ 	24 	70 	24 	72 	36 	40 	36 	60 	24 	78
80+ 	32 	54 	40 	82 	24 	64 	42 	56 	40 	88
90+ 	24 	72 	44 	60 	46 	72 	32 	96 	42 	60

*/