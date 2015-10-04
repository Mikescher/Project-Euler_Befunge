<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

/*
Let `d(n)` be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
If `d(a) = b and d(b) = a`, where `a != b`, then a and b are an amicable pair and each of a and b are called amicable numbers.

For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore `d(220) = 284`.
The proper divisors of 284 are 1, 2, 4, 71 and 142; so `d(284) = 220`.

Evaluate the sum of all the amicable numbers under 10000.
*/

int LIMIT = 10000;

void Main()
{
	Enumerable.Range(1, LIMIT).Where(a => a == D(D(a)) && a != D(a) && D(a) > 0).Sum().Dump();
}

Dictionary<int, int> DD = new Dictionary<int, int>();
int D(int n)
{
	if (n > LIMIT) return -1;
	if (n == 0) return 0;

	if (!DD.ContainsKey(n)) DD[n] = Enumerable.Range(1, n-1).Where(p => n%p == 0).Sum();
	
	return DD[n]; 
}

int NOD(int number)
{
	int nod = 0;
	int sqrt = (int)Math.Sqrt(number);

	for (int i = 1; i <= sqrt; i++)
	{
		if (number % i == 0) nod += 2;
	}
	if (sqrt * sqrt == number) nod--;

	return nod;
}