<Query Kind="Program" />

void Main()
{
	Pandigitals()
		.Take(2000)
		.IsOrdered()
		.Dump();
		
	Pandigitals()
		.Take(20)
		.Dump();
		
	Pandigitals()
		.Take(200)
		.Where(IsCurious)
		.Dump();
}

public bool IsCurious(int n)
{
	for(int i = 9; i >= 3; i--)
	{
		if (n % Fac(i) == 0)
			return true;
	}
	
	return false;
}

public int Fac(int x)
{
	return x == 0 ? 1 : x+Fac(x-1);
}

public IEnumerable<int> Pandigitals()
{
	int[] numbers = new int[9]{9, 8, 7, 6, 5, 4, 3, 2, 1};	
	
	for(;;) 
	{
		yield return get(numbers);
		next(ref numbers);
	}
}

public void next(ref int[] numbers)
{
	bool[] bout = new bool[10];
	
	for(int p = 8;; p--)
	{
		bout[numbers[p]] = true;
		
		for (int i = numbers[p] - 1; i >= 1; i--)
		{
			if (bout[i])
			{
				numbers[p] = i;
				bout[i] = false;
				p++;
				
				for (int j = 9; j >= 1; j--)
				{
					if (bout[j])
					{
						numbers[p] = j;
						p++;
					}
				}
				
				return;
			}
		}
	}
}

public int get(int[] numbers)
{
	return numbers.Select((p,i) => p * (int)Math.Pow(10, 8-i)).Sum();
}

public static class MyExtensions
{
	public static bool IsOrdered<T>(this IEnumerable<T> ls)
	{
		return ls.OrderByDescending(p=>p).SequenceEqual(ls);
	}
}