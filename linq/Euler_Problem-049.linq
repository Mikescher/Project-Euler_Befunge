<Query Kind="Program" />

public int[] sieve = ESieve(10000);

void Main()
{
	// functional correct
	Enumerable
		.Range(1000,3340-1000)
		.Where(p => sieve.Contains(p))
		.Where(p => sieve.Contains(p+3330))
		.Where(p => sieve.Contains(p+6660))
		.Where(p => isPerm(p, p+3330, p+6660))
		.Select(p => p + " " + (p+3330) + " " + (p+6660))
		.Dump();
		
	// Befunge impl
	Enumerable
		.Range(1488,3340-1488)
		.Where(p => isMPerm(p))
		.Where(p => isPrime(p))
		.Where(p => isPrime(p+3330))
		.Where(p => isPrime(p+6660))
		.Select(p => p + " " + (p+3330) + " " + (p+6660))
		.Dump();
		
	// test Mult-Permutation-Test
	Enumerable
		.Range(11,1000000)
		//.Where(p => !getDigits(p).Contains(0))
		.Where(p => isMPerm(p) ^ isPerm(p, p+3330, p+6660))
		.Select(p => p + " " + (p+3330) + " " + (p+6660))
		.Dump();
	
	// test isPrime
	Enumerable
		.Range(0, 10000)
		.Where(p => isPrime(p) ^ sieve.Contains(p))
		.Dump();
	
	// List permutables
	Enumerable
		.Range(1000,3340-1000)
		.Where (p => isPerm(p, p+3330, p+6660))
		.Select(p => p + " " + (p+3330) + " " + (p+6660))
		.Dump();
}

public static int[] ESieve(int upperLimit) {
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

public IEnumerable<int> getDigits(int v)
{
	while(v > 0)
	{
		yield return v%10;
		v /= 10;
	}
}

public bool listEquals<T>(IEnumerable<T> aa, IEnumerable<T> bb)
{
	List<T> a = aa.OrderBy(p => p).ToList();
	List<T> b = bb.OrderBy(p => p).ToList();
	
	for(int i=0; i < Math.Min(a.Count, b.Count); i++)
	{
		if (! a[i].Equals(b[i]))
			return false;
	}
	
	return a.Count == b.Count;
}

public bool isMPerm(int a)
{
	return isMPerm(a, a+3330, a+6660);
}

public bool isPerm(int a, int b, int c)
{
	return listEquals(getDigits(a), getDigits(b)) && listEquals(getDigits(a), getDigits(c));
}

public bool isMPerm(int a, int b, int c)
{
	return isMPerm(a, b) && isMPerm(b, c);
}

public bool isMPerm(int aa, int bb)
{
	return getDigits(aa).Select(p=>p+2).Aggregate((a,b)=>a*b) == getDigits(bb).Select(p=>p+2).Aggregate((a,b)=>a*b);
}

public bool isPrime(int n)
{
	if (n%2==0)return n==2;
	if (n%3==0)return n==3;

	for(int i = 7; i < n/2; i+=6)
	{
		if (n%i==0)return false;
		if (n%(i-2)==0)return false;
	}
	return n!=1;
}