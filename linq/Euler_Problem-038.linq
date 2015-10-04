<Query Kind="Program" />

void Main()
{
	CuriousNumbers().Take(1).Dump();
	CuriousNumbers().Dump();
}

public IEnumerable<string> CuriousNumbers()
{
	for(int i = 9999; i > 0; i--)
	{
		for(int d = 5; d >= 2; d--)
		{
			Int64 nm = NumberMerge(i, Enumerable.Range(2, d-1).Select(p => (Int64)(p * i)));
			if (IsPandigital(nm))
			{
				yield return String.Format("{0:0000} (x{1}) = {2}", i, d, nm);
			}
		}
	}
}

public Int64 NumberMerge(Int64 a, IEnumerable<Int64> b)
{
	if (! b.Any()) return a;
	
	Int64 b0 = b.First();
	
	Stack<Int64> stack = new Stack<Int64>();
	
	while(b0 > 0)
	{
		stack.Push(b0%10);
		b0 /= 10;
	}
	
	while (stack.Count > 0)
	{
		a *= 10;
		a += stack.Pop();
	}
	
	return NumberMerge(a, b.Skip(1));
}

public bool IsPandigital(Int64 n)
{
	int[] ar = new int[10];
	
	while(n > 0)
	{
		ar[n%10]++;
		n /= 10;
	}
	
	return ar.Skip(1).All(p => p==1) && ar.First() == 0;
}