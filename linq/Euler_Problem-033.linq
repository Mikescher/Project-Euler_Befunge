<Query Kind="Program" />

/*

The fraction 49/98 is a curious fraction, 
as an inexperienced mathematician in attempting to simplify it may incorrectly believe that 
49/98 = 4/8, which is correct, is obtained by cancelling the 9s.

We shall consider fractions like, 30/50 = 3/5, to be trivial examples.

There are exactly four non-trivial examples of this type of fraction, less than one in value, 
and containing two digits in the numerator and denominator.

If the product of these four fractions is given in its lowest common terms, 
find the value of the denominator.

*/

void Main()
{
	Console.WriteLine(
	
		Range(10, 99, 10, 99)
			.Select (p => new {a=p.Item1, b=p.Item2})
			.Where  (p => p.a < p.b)
			.Where  (p => isDCF(p.a, p.b))
	);


	Console.WriteLine(
	
		Range(10, 99, 10, 99)
			.Select (p => new {a=p.Item1, b=p.Item2})
			.Where  (p => p.a < p.b)
			.Where  (p => isDCF(p.a, p.b))
		
			.Aggregate ((pa,pb) => new 
			{
				a=pa.a*pb.a / GCD(pa.a*pb.a, pa.b*pb.b), 
				b=pa.b*pb.b / GCD(pa.a*pb.a, pa.b*pb.b)
			})
	);
}

public static IEnumerable<Tuple<int, int>> Range(int s1, int e1, int s2, int e2) 
{
	for (int a = s1; a <= e1; a++)
		for (int b = s2; b <= e2; b++)
				yield return Tuple.Create(a, b);
}

public static bool isDCF(int a, int b)
{
	if (a/10 == b/10 && a/10 != 0)
		if (isSameFraction(a, b, a%10, b%10)) return true;
	
	if (a/10 == b%10 && a/10 != 0)
		if (isSameFraction(a, b, a%10, b/10)) return true;
	
	if (a%10 == b/10 && a%10 != 0)
		if (isSameFraction(a, b, a/10, b%10)) return true;
	
	if (a%10 == b%10 && a%10 != 0)
		if (isSameFraction(a, b, a/10, b/10)) return true;
	
	return false;
}

public static bool isSameFraction(int a1, int b1, int a2, int b2)
{
	return a1*b2 == a2*b1;
}


static int GCD(int a, int b)
{
    return b == 0 ? a : GCD(b, a % b);
}