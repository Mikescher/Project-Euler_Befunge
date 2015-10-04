<Query Kind="Program" />

void Main() {
	//diagonalNumbers().Dump();

	int all = 1;
	int primes = 0;

	foreach(int dn in diagonalNumbers()) 
	{
		if (isMRPrime(dn)) primes++;
		all++;

		if (primes * 10 < all) 
		{
			((((all - 2) / 4) * 2) + 3).Dump();
			return;
		}

	}

}

IEnumerable<int> diagonalNumbers() 
{
	int num = 1;
	int diff = 2;

	for (;;) 
	{
		yield return num += diff;
		yield return num += diff;
		yield return num += diff;
		yield return num += diff;

		diff += 2;
	}
}

// http://en.wikipedia.org/wiki/Miller-Rabin_primality_test
private bool isMRPrime(int n) 
{
	if (n <= 1) return false;
	if (n == 2) return true;
	if (n % 2 == 0) return false;
	if (n < 9) return true;
	if (n % 3 == 0) return false;
	if (n % 5 == 0) return false;

	//  correct for n < 1,373,653,
	if (Witness(2, n)) return false;
	if (Witness(3, n)) return false;
		
	return true;
}


private bool Witness(int a, int n) 
{
	int t = 0;
	int u = n - 1;
	while (u % 2 == 0) 
	{
		t++;
		u /= 2;
	}

	long xi1 = ModularExp(a, u, n);
	
	for (; t > 0; t--) 
	{
		if (((xi1 * xi1) % n == 1) && (xi1 != 1) && (xi1 != (n - 1))) return true;
		xi1 = (xi1 * xi1) % n;
	}
	
	if (xi1 != 1) return true;
	return false;
}


private long ModularExp(int a, int b, int n) // (a^b) % n
{
	int k = 0;
	int bt = b;
	int bi = 1;
	while (bt > 0) 
	{
		k++;
		bt /= 2;
		bi *= 2;
	}

	long d = 1;
	
	for (k--; k >= 0; k--) 
	{
		d = (d * d) % n;
		bi /= 2;
		
		if (((b / bi) % 2) > 0) 
		{
			d = (d * a) % n;
		}
	}

	return d;
}
