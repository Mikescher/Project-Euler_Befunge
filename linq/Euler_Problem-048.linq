<Query Kind="Program" />

void Main()
{
	long cnt = 10000000000;

	Enumerable.Range(1, 1000)
		.Select(p => iPow(p, p, cnt) % cnt)
		.Aggregate((a,b) => (a+b) % cnt)
		.Dump();
}

public IEnumerable<long> LRange(long start, long count)
{
	long i = 0;
	while (i < count)
	{
		yield return start + i;
		i++;
	}
}

public long iPow(long x, long p, long mod)
{
	long result = 1;
	while (p-- > 0) 
	{
		result *= x;
		result %= mod;
	}
	return result;
}
