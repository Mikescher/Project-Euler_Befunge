<Query Kind="Program" />

void Main()
{
	findAllSixPerms().Take(1).Dump();
}

IEnumerable<int> findAllSixPerms()
{
	for(int ibase = 10; ; ibase *= 10)
	{
		for(int v = ibase/10; v < ibase/6; v++)
		{
			if (isSixPerm(v))
			{
				yield return v;
			}
		}
	}
}

public bool isSixPerm(int v)
{
	return Enumerable.Range(1, 6)
		.Select(p=>p*v)
		.Select(getMPermHash)
		.Distinct()
		.Count()
		.Equals(1);
}

public int getMPermHash(int aa)
{
	return getDigits(aa)
		.Select(p => p+2)
		.Aggregate((a,b) => a*b);
}

public IEnumerable<int> getDigits(int v)
{
	while(v > 0)
	{
		yield return v%10;
		v /= 10;
	}
}
