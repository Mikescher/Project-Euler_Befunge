<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

void Main()
{
	//*
	Enumerable
		.Range(1, 1000)
		.Select(p => new{N=numerator(p), D=denominator(p)})
		//.Where(p => dcnt(p.N) > dcnt(p.D))
		.Select(p => new{CN=dcnt(p.N), CD=dcnt(p.D)})
		.Where(p => p.CN > p.CD)
		.Dump();
	//*/
		
	Enumerable
		.Range(1, 22)
		.Select(p => new{N=numerator(p), D=denominator(p)})
		.Select(p => new{N=p.N, D=p.D, CN=dcnt(p.N), CD=dcnt(p.D)})
		.Dump();
}

// A123335
Dictionary<BigInteger, BigInteger> n_dict = new Dictionary<BigInteger, BigInteger>();
BigInteger numerator(BigInteger n) {
	if (n == 0) return 1;
	if (n == 1) return 1;
	
	if (n_dict.ContainsKey(n)) return n_dict[n];
	
	n_dict.Add(n, 2*numerator(n-1) + numerator(n-2));
	return n_dict[n];
}

//  A000129
Dictionary<BigInteger, BigInteger> d_dict = new Dictionary<BigInteger, BigInteger>();
BigInteger denominator(BigInteger n) {
	if (n == 0) return 0;
	if (n == 1) return 1;
	
	if (d_dict.ContainsKey(n)) return d_dict[n];
	
	d_dict.Add(n, 2*denominator(n-1) + denominator(n-2));
	return d_dict[n];
}

BigInteger dcnt(BigInteger number) {
	return number.ToString().Length;
}