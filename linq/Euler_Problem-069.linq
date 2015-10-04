<Query Kind="Program" />

/*
Euler's Totient function, `phi(n)` (sometimes called the phi function), 
is used to determine the number of numbers less than n which are relatively prime to n. 
For example, as 1, 2, 4, 5, 7, and 8, are all less than nine and relatively prime to nine, `phi(9)=6`.

n  | Relatively Prime | phi(n) | n/phi(n)
---------------------------------------
2  | 1                | 1      |  2
3  | 1,2              | 2      |  1.5
4  | 1,3              | 2      |  2
5  | 1,2,3,4          | 4      |  1.25
6  | 1,5              | 2      |  3
7  | 1,2,3,4,5,6      | 6      |  1.1666...
8  | 1,3,5,7          | 4      |  2  
9  | 1,2,4,5,7,8      | 6      |  1.5
10 | 1,3,7,9          | 4      |  2.5

It can be seen that n=6 produces a maximum `n/phi(n)` for `n <= 10`.

Find the value of `n <= 1,000,000` for which `n/phi(n)` is a maximum.
*/
void Main()
{
	PhiMathBlog().Dump();

	/*
	var sieve = PhiSieve(40);

	Enumerable.Range(0, 40)
		.Select(p => new
		{
			Number = p,
			Phi = Phi(p),
			Sieve = sieve[p],
		})
		.Where(p => p.Phi != p.Sieve)
		.Dump();
	*/


	/*
	Enumerable
		.Range(1, 100)
		.Select(vin => new
		{
			n = vin,
			pn = Phi(vin),
		})
		.Select(vin => new
		{
			n = vin.n,
			pn = vin.pn,
			npn = vin.n * 1.0 / vin.pn,
		})
		.OrderByDescending(p => p.npn)
		.Dump();
	*/
}

/*
http://codeforces.com/blog/entry/8989

a). phi(p) = p - 1. Where p is prime. 
    All the numbers from 1 to p - 1 are coprime to p.

b). phi(a * b) = phi(a) * phi(b) where a and b are coprime.

c). phi(p^k) = p^k - p^(k - 1). Note that here ^ denotes power. 
    Here all the numbers from 1 to p^k are coprime to p^k except all the multiples of p, 
	which are exactly p^(k -1).

(coprime == gcd of 1)

*/

int PhiMathBlog()
{
	int result = 1;
	int[] primes = ESieve(200);
	int i = 0;
	int limit = 1000000;
	
	while(result * primes[i] < limit){
		result *= primes[i];
		i++;
	}
	
	return result;
}

int[] PhiSieve(int MAX)
{
	List<int> primes = new List<int>();

	int[] sieve = new int[MAX];
	sieve[1] = 1;
	
	for(int i = 1; i < MAX; i++)
	{
		if (sieve[i] != 0) 
		{
			foreach(var prime in primes)
			{
				if (prime*i >= MAX) break;
				if (i%prime == 0) continue;
				
				sieve[prime*i] = sieve[i] * (prime - 1);
				((prime*i)+" =0> "+(sieve[i] * (prime - 1))+" ("+i+" * "+prime+")").Dump();
			}
		
			continue;
		}
		
		sieve[i] = i-1;
		((i)+" =1> "+(i-1) + " (prime)").Dump();
		int idx = primes.Count();
		primes.Add(i);
		
		
		int mult = i*i;
		for(int p = 2; mult < MAX; p++, mult *= i)
		{
			sieve[mult] = mult - (mult/i);
			((mult)+" =2> "+(mult - (mult/i)) + "("+i+"^"+p+")").Dump();
		}
		
		for(int n = 2; n < i; n++)
		{
			if (n == i) continue;
			if (n*i >= MAX) break;
			
			sieve[n*i] = sieve[n] * sieve[i];	
			((n*i)+" =3> "+(sieve[n] * sieve[i]) + " ("+n+" * " + i+")").Dump();
		}
	}
	
	return sieve;
}

int Phi(int n)
{
	return Enumerable.Range(1, n).Where(p => GCD(p, n) == 1).Count();
}

int GCD(int a, int b)
{
    return b == 0 ? a : GCD(b, a % b);
}

public int[] ESieve(int upperLimit) {

  int sieveBound = (int)(upperLimit - 1) / 2;
  int upperSqrt = ((int)Math.Sqrt(upperLimit) - 1) / 2;

  BitArray PrimeBits = new BitArray(sieveBound + 1, true);

  for (int i = 1; i <= upperSqrt; i++) {
      if (PrimeBits.Get(i)) {
          for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1) {
              PrimeBits.Set(j, false);
          }
      }
  }

  List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
  numbers.Add(2);
  for (int i = 1; i <= sieveBound; i++) {
      if (PrimeBits.Get(i)) {
          numbers.Add(2 * i + 1);
      }
  }

  return numbers.ToArray();
}   