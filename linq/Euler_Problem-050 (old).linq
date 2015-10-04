<Query Kind="Program" />

const int SUMMAX = 1000000; // 41 = 2 + 3 + 5 + 7 + 11 + 13

void Main()
{
	sumPrimes().OrderByDescending(p => p).Dump();
}

IEnumerable<long> sumPrimes()
{
	long[] primes = ESieve(SUMMAX);

	int max = 0;
	long value = 0;
	while (value + primes[max] < SUMMAX)
		value += primes[max++];
	
	value.Dump();
	
	for(int min=0;min<max;min++)
	{
		if (value + primes[max] < SUMMAX)
			value += primes[max++];
	
		long last = value;
		int lastMax = max;
		
		while(max > min )
		{
			value -= primes[--max];
			
			if (primes.Contains(value))
			{
				//(string.Join(" + ", Enumerable.Range(min, max-min).Select(p => primes[p].ToString())) + " = " + value).Dump();
				
				yield return value;
			}
			
			if (value > SUMMAX)
				throw new Exception("a");
			if (Enumerable.Range(min, max-min).Select(p => primes[p]).Sum() != value)
				throw new Exception(string.Join(" + ", Enumerable.Range(min, max-min).Select(p => primes[p].ToString())) + " = " + value);
			
		}
		value = last - primes[min];
		max = lastMax;
	}
}

public static long[] ESieve(int upperLimit) {
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
 
    List<long> numbers = new List<long>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
    numbers.Add(2);
 
    for (int i = 1; i <= sieveBound; i++) {
        if (PrimeBits.Get(i)) {
            numbers.Add(2 * i + 1);
        }
    }
 
    return numbers.ToArray();
}