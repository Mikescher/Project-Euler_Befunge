<Query Kind="Program" />

/*
Euler's Totient function, `phi(n)` [sometimes called the phi function], 
is used to determine the number of positive numbers less than or equal to n which are relatively prime to n. 
For example, as 1, 2, 4, 5, 7, and 8, are all less than nine and relatively prime to nine, `phi(9)=6`.

The number 1 is considered to be relatively prime to every positive number, so `phi(1)=1`.

Interestingly, `phi(87109)=79180`, and it can be seen that `87109` is a permutation of `79180`.

Find the value of `n`, `1 < n < 10^7`, for which `phi(n)` is a permutation of n and the ratio `n/phi(n)` produces a minimum.
*/
void Main()
{
	long best = 1;
	long phiBest = 0;
	
	int limit = 10000000;
	int lowerbound = 2000;
	int upperbound = 5000;
	long[] primes = ESieve(lowerbound, upperbound);                       
	
	for (int i = 0; i < primes.Length; i++) 
	{                                
		for (int j = i+1; j < primes.Length; j++) 
		{
			long n = primes[i] * primes[j];                    
			if (n > limit) break;
			
			long phi = (primes[i] - 1) * (primes[j] - 1);                    
			
			//double ratio = ((double) n) / phi;
			
			if (isPerm(n, phi) &&  n*phiBest < best*phi) 
			{
				best = n;
				phiBest = phi;
				
				("{"+best + " | " + phiBest + "}").Dump();
			}                                    
		}
	}
	
	Console.WriteLine("The permutation with the smallest ratio is {0}", best);
	Console.WriteLine("This gives us the fraction {0}", best * 1.0 / phiBest);
}

public long[] ESieve(int lowerLimit, int upperLimit) 
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
	
	List<long> numbers = new List<long>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
	
	if (lowerLimit < 3) 
	{
		numbers.Add(2);
		lowerLimit = 3;
	}
	
	for (int i = (lowerLimit-1)/2; i <= sieveBound; i++) 
	{
		if (PrimeBits.Get(i)) 
		{
			numbers.Add(2 * i + 1);
		}
	}
	
	return numbers.ToArray();
}

private bool isPerm(long m, long n) 
{
	return GetCubeHash(m) == GetCubeHash(n);
}

long GetCubeHash(long value)
{
	long sum = 0;
	while (value > 0)
	{
		sum += (long)Math.Pow((long)9, (1 + value%10));
		value /= 10;
	}
	return sum;
}