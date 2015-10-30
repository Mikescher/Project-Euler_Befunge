<Query Kind="Program" />

/*
The smallest number expressible as the sum of a prime square, prime cube, and prime fourth power is 28. 
In fact, there are exactly four numbers below fifty that can be expressed in such a way:

28 = 2^2 + 2^3 + 2^4
33 = 3^2 + 2^3 + 2^4
49 = 5^2 + 2^3 + 2^4
47 = 2^2 + 3^3 + 2^4

How many numbers below fifty million can be expressed as the sum of a prime square, 
prime cube, and prime fourth power?s
*/

const int LIMIT = 50 * 1000 * 1000;
//const int LIMIT = 370;

void Main()
{
	int counter = 0;
	int anticounter = 0;

	var found = new bool[LIMIT];
	var primes = ESieve((int)Math.Sqrt(LIMIT)); //7071
	primes.Length.Dump();
	
	for (int a = 0; a < primes.Length; a++)
	{
		int pa = primes[a]*primes[a];
	
		for (int b = 0; b < primes.Length && (pa+primes[b]*primes[b]*primes[b]) <= LIMIT; b++)
		{
			int pb = pa+primes[b]*primes[b]*primes[b];
		
			for (int c = 0; c < primes.Length && (pb+primes[c]*primes[c]*primes[c]*primes[c]) <= LIMIT; c++)
			{
				int pc = pb+primes[c]*primes[c]*primes[c]*primes[c];

				if (!found[pc])
				{
					found[pc] = true;
					counter++;
				}
				else
				{
					anticounter++;
				}
			}
		}
	}

	counter.Dump();
	anticounter.Dump();
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

//B93 Tricks

/*
Use 60bit per array cell (50MB -> 800KB)

Cache powers of 2

Bit Set --> ADD 2^n
Bit Get --> MOD 2^(n+1)   --   DIV 2^n

Sieve in same array that is later cache
(~1000 primes)

SQRT(50M) => 7071 
*/