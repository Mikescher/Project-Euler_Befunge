<Query Kind="Program" />

void Main() // 134043
{
	var sieve = ESieve(200000);

	for(int i=0;;i+=4)
	{
		if (getDistinctPFCount(i, sieve)==4)
			if (test(i, sieve))
				break;
	}
}

public bool test(int p, int[] sieve)
{
	int cc = 0;
	for(int i = (p-3);i <= (p+3);i++)
	{
		if (i==p || getDistinctPFCount(i, sieve)==4)
		{
			cc++;
			
			if (cc == 4)
			{
				cc++;
				Console.WriteLine(string.Format("{0}: {1,-24} := {2}", i-3, string.Join(" * ", listPF(i-3, sieve)), getDistinctPFCount(i-3, sieve)));
				Console.WriteLine(string.Format("{0}: {1,-24} := {2}", i-2, string.Join(" * ", listPF(i-2, sieve)), getDistinctPFCount(i-2, sieve)));
				Console.WriteLine(string.Format("{0}: {1,-24} := {2}", i-1, string.Join(" * ", listPF(i-1, sieve)), getDistinctPFCount(i-1, sieve)));
				Console.WriteLine(string.Format("{0}: {1,-24} := {2}", i-0, string.Join(" * ", listPF(i-0, sieve)), getDistinctPFCount(i-0, sieve)));
			
				Console.WriteLine();
				Console.WriteLine();
				
				return true;
			}
		}
		else 
		{
			if (i > p)
				return false;
			
			cc=0;
		}
	}
	
	return false;
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

public int getDistinctPFCount(int num, int[] primes)
{
	int c = 0;
	for(int i = 0; primes[i] <= num; i++)
	{
		if (num % primes[i] == 0)
		{
			c++;
			num /= primes[i];
		}
	}
	return c;
}

public IEnumerable<int> listPF(int num, int[] primes)
{
	for(int i = 0; primes[i] <= num; i++)
	{
		while (num % primes[i] == 0){
			num /= primes[i];
			yield return primes[i];
		}
	}
}