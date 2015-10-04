<Query Kind="Program" />

void Main()
{
	var sieve = ESieve(1000000);
	
	Console.WriteLine(
		getRLPrimes(0, sieve)
			.Sum()
	);
	
	Console.WriteLine(
		getRLPrimes(0, sieve)
	);
	
	Console.WriteLine(
		getRLPrimes(0, sieve)
		.OrderBy(p => p)
	);
}

public List<int> getRLPrimes(int num, int[] sieve)
{
	List<int> result = new List<int>();

	for(int d = 9; d > 0; d--)
	{
		if (sieve.Contains(num*10 + d)) {
			if (IsLRPrime(num*10 + d, sieve))
				result.Add(num*10 + d);
				
			result.AddRange(getRLPrimes(num*10+d, sieve));
		}
	}
	
	return result;
}

public bool IsLRPrime(int num, int[] sieve) 
{
	if (num < 10) return false;

	int multiplicator = 1;
	int k = num / 10;
	while (k > 0)
	{
		k /= 10;
		multiplicator *= 10;
	}
	
	while(num > 0)
	{
		if (! sieve.Contains(num))
			return false;
			
		num %= multiplicator;
		multiplicator /= 10;
	}
	
	return true;
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