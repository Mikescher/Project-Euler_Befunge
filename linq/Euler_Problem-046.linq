<Query Kind="Program" />

void Main()
{
	var sieve = erastothenes(10000);
	
	
	for (int i = 3;; i+=2)
	{
		if (sieve[i]) continue;
	
		bool succ = false;
		for (int j = 0; j < i; j++)
		{
			if (sieve[j] && isIntSqrt((i - j)/2))
			{
				succ = true;
				break;
			}
		}
		
		if (! succ)
		{
			Console.Out.WriteLine(i);
			return;
		}
	}
}

public bool[] erastothenes(int max)
{
	int[] result = Enumerable.Repeat(0, max).ToArray();
	
	result[0] = -1;
	result[1] = -1;
	
	for(;;)
	{
		for (int i = 0; i < max; i++)
		{
			if (result[i] == -1)
				continue;
				
			result[i] = 1;
			
			int p = i;
			while((p+i) < max)
				result[p += i] = -1;
		}
		
		return result.Select(p => p == 1).ToArray();
	}
}

public bool isIntSqrt(int x)
{
	return Math.Pow((int)Math.Sqrt(x), 2) == x;
}