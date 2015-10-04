<Query Kind="Program" />

void Main()
{
	var e1 = UniqueRange(1, 9, 1000, 9999) // 1d * 4d
						.Where(p => IsPandigital(p.Item1, p.Item2));
						
	var e2 = UniqueRange(10, 99, 100, 999) // 2d * 3d
						.Where(p => IsPandigital(p.Item1, p.Item2));

	Console.WriteLine(
		e1
			.Concat(e2)
			.Select(p => new{a=p.Item1, b=p.Item2, c=p.Item1*p.Item2})
			.OrderBy(p => p.c)
			.Select(p => p.a + " * " + p.b + " = " + p.c)
	);
	

	Console.WriteLine(
		e1
			.Concat(e2)
			.Select(p => new{a=p.Item1, b=p.Item2, c=p.Item1*p.Item2})
			.Select(p=>p.c)
			.Distinct()
			.Sum()
	);
}

// Define other methods and classes here

public static bool IsPandigital(int a, int b)
{
	List<bool> x = (a.ToString() + b.ToString() + (a*b).ToString())
						.ToCharArray()
						.Select(p => p - '0')
						.OrderBy(p => p)
						.Select((p, i) => (p == i+1))
						.ToList();
						
	return x.Count() == 9 && x.All(p => p);
}

public static IEnumerable<Tuple<int, int>> UniqueRange(int s1, int e1, int s2, int e2) 
{
	for (int a = s1; a <= e1; a++)
		for (int b = s2; b <= e2; b++)
				yield return Tuple.Create(a, b);
}