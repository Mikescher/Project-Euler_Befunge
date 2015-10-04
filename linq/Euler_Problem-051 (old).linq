<Query Kind="Program" />

const int ALGMAX = 1000000;

int[] primes = ESieve(ALGMAX);

void Main()
{
	findPrimeFamily(8);
}

void findPrimeFamily(int ss)
{	
	for(int v=100000; v<ALGMAX; v++)
	{
		int fs = GetFamilySize(v);
		
		if (fs == ss)
		{
			int repl = GetReplDigit(v);
			Enumerable.Range(0, 10).Select(p => ReplDigits(v, repl, p)).Where(p => primes.Contains(p)).Dump();
			return;
		}
	}
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

int GetFamilySize(int v)
{
	int repl = GetReplDigit(v);
	return Enumerable.Range(0, 10).Select(p => ReplDigits(v, repl, p)).Where(p => primes.Contains(p)).Count();
}

int GetReplDigit(int v)
{
	return GetDigits(v).GroupBy(p => p).OrderByDescending(g => g.Count()).First().First();
}

int ReplDigits(int value, int search, int repl)
{
	return ToNumber(GetDigits(value).Select(p => p==search ? repl : p));
}

IEnumerable<int> GetDigits(long v)
{
	while(v > 0)
	{
		yield return (int)(v%10);
		v /= 10;
	}
}

int ToNumber(IEnumerable<int> v)
{
	int r = 0;
	
	foreach(int d in v)
	{
		r *= 10;
		r += d;
	}
	
	return r;
}