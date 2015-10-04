<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
</Query>

void Main()
{
	Console.WriteLine( 
		Range(2, 101, 2, 101)
			.Select(p => System.Numerics.BigInteger.Pow(p.Item1, p.Item2))
			.Select(p => SIntHash(p))
			.Distinct()
			.Count()
		);
		
	Console.WriteLine( 9183 );
		
	Console.WriteLine( SIntHash( System.Numerics.BigInteger.Pow(97, 48) ) );
}

// Define other methods and classes here

public static int SIntHash(System.Numerics.BigInteger i) 
{
	System.Numerics.BigInteger sum = 0;
	
	foreach(var x in GetDigits(i)) sum = (sum*9 + x) % 357913941;
	
	return (int)sum;
}

public static List<int> GetDigits(System.Numerics.BigInteger i)
{
	List<int> xl = new List<int>();
	for (; i > 0; xl.Insert(0, (int)(i % 10)), i /= 10) ;
	return xl;
}

public static List<Tuple<int, int>> Range(int s1, int e1, int s2, int e2) 
{
	List<Tuple<int, int>> r = new List<Tuple<int, int>>();
	
	for (int a = s1; a < e1; a++)
		for (int b = s2; b < e2; b++)
			r.Add(Tuple.Create(a, b));
			
	return r;
}