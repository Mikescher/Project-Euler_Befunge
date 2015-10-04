<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

/*
The 5-digit number, `16807=7^5`, is also a fifth power.
Similarly, the 9-digit number, `134217728=8^9`, is a ninth power.

How many n-digit positive integers exist which are also an nth power?
*/

void Main()
{
	Enumerable
		.Range(1, int.MaxValue)
		.Select(GetNDigitPowerNumber)
		.TakeWhile(p => p != null)
		.Select((p, i) => p == null ? "NULL" : string.Format("{1}^{2:00} = {0} (total = {3})", BigInteger.Pow(p.Value, i), p, i, GetNDigitPowerNumberCount(i+1)))
		.Dump();
		
	Enumerable
		.Range(1, int.MaxValue)
		.Select(GetNDigitPowerNumberCount)
		.TakeWhile(p => p > 0)
		.Sum()
		.Dump("Total Sum");
}

int? GetNDigitPowerNumber(int n)
{
	BigInteger min = BigInteger.Pow(10, n-1);
	BigInteger max = BigInteger.Pow(10, n);

	int i = 1;
	
	BigInteger pow = BigInteger.Pow(i, n);
	while(pow < max && i <= 9)
	{
		if (pow >= min) return i;
	
		pow = BigInteger.Pow(++i, n);
	}
	
	return (int?)null;
}

int GetNDigitPowerNumberCount(int n)
{
	int i = 1;
	
	while(i < 10)
	{
		var size = BigInteger.Pow(i, n).ToString().Length;
		
		if (size == n) return 10 - i;
		if (size > n) return 0;
		
		i++;
	}
	
	return 0;
}
