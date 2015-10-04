<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

void Main()
{
	int max = 0;

	for (int a = 0; a < 100; a++)
	{
		for (int b = 0; b < 100; b++)
		{
			max = Math.Max(max, dsum(a, b));
		}
	}
	
	max.Dump();
}

int dsum(int a, int b)
{
	return BigInteger.Pow(a, b).ToString().ToCharArray().Select(p => p - '0').Sum();
}