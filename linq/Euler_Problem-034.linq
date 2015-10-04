<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

/*
145 is a curious number, as `1! + 4! + 5! = 1 + 24 + 120 = 145`.

Find the sum of all numbers which are equal to the sum of the factorial of their digits.

Note: as `1! = 1` and `2! = 2` are not sums they are not included.
*/

void Main()
{
	LRange(3, Fac(9)*7).Where(p => Amic(p) == p).Sum().Dump();
}

long Amic(long n) => n.ToString().ToCharArray().Select(p => Fac(p - '0')).Sum();

Dictionary<long, long> FDic = new Dictionary<long, long>();
long Fac(long n)
{
	if (n == 0) return 1;
	if (n == 1) return 1;

	if (!FDic.ContainsKey(n)) FDic[n] = LRange(1, n).Select(p => (long)p).Aggregate((a,b) => a*b);
	
	return  FDic[n];
}

IEnumerable<long> LRange(long start, long count)
{
	for (long i = 0; i < count; i++) yield return start + i;
}