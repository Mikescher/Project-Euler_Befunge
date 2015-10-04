<Query Kind="Program">
  <Namespace>System</Namespace>
  <Namespace>System.Collections</Namespace>
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>System.Diagnostics</Namespace>
  <Namespace>System.Linq</Namespace>
</Query>

/* Euler-060

The primes 3, 7, 109, and 673, are quite remarkable. 
By taking any two primes and concatenating them in any order the result will always be prime. 
For example, taking 7 and 109, both 7109 and 1097 are prime. 
The sum of these four primes, 792, represents the lowest sum for a set of four primes with this property.

Find the lowest sum for a set of five primes for which any two primes concatenate to produce another prime.
*/

/*
const int PRIME_SIZE  = 1000;
const int SIEVE_SIZE  = 9 * PRIME_SIZE;
const int PRIME_COUNT = 4;
/*/
const int PRIME_SIZE  = 3300;
const int SIEVE_SIZE  = 10 * PRIME_SIZE;
const int PRIME_COUNT = 5;
//*/

int[] primes; 

void Main(string[] args) {
	BruteForce();
}


public void BruteForce() {
	Stopwatch clock = Stopwatch.StartNew();

	int result = int.MaxValue;
	primes = ESieve(SIEVE_SIZE).Take(PRIME_SIZE).ToArray();
		
	HashSet<int>[] pairs = new HashSet<int>[primes.Length];
	
	int depth = 1;
	int[] indizies = new int[PRIME_COUNT + 1];
	indizies[0] = 0;
	indizies[1] = 0;
	int currentsum = 0;
	while(depth > 0) {
		indizies[depth]++;
	
		if (indizies[depth] == primes.Length)
		{
			depth--;
			currentsum -= primes[indizies[depth]];
		}
		else if (currentsum + primes[indizies[depth]] * (PRIME_COUNT - depth) >= result)
		{
			depth--;
			currentsum -= primes[indizies[depth]];
		}
		else if (Enumerable.Range(1, depth-1).Any(p => !pairs[indizies[p]].Contains(primes[indizies[depth]])))
		{
			// continue;
		}
		else
		{
			MakePairs(ref pairs, indizies[depth]);
			
			if (depth != PRIME_COUNT)
			{
				currentsum += primes[indizies[depth]];
				depth++;
				
				indizies[depth] = indizies[depth-1];
			}
			else
			{
				if (currentsum + primes[indizies[depth]] < result) result = currentsum + primes[indizies[depth]];
				
				Console.WriteLine(string.Join(" + ", Enumerable.Range(0, depth).Select(p => primes[indizies[p]].ToString()) ) + " = " + (currentsum + primes[indizies[depth]]));
				
				depth--;
				currentsum -= primes[indizies[depth]];
			}
		}
	
	}

	clock.Stop();
	Console.WriteLine("Lowest sum of {1} primes {0}", result, PRIME_COUNT);
	Console.WriteLine("Solution took {0} ms", clock.ElapsedMilliseconds);
	
	pairs
		.Select((p, i) => new {Value=p, Index=i, Prime=primes[i]})
		.Where(p => p.Value != null)
		.OrderByDescending(p => p.Value.Count())
		.Dump();
}

private void MakePairs(ref HashSet<int>[] pairs, int a) {
	if (pairs[a] != null) return;
	pairs[a] = new HashSet<int>();
	
	for (int b = a + 1; b < primes.Length; b++) {
		if (isPrime(concat(primes[a], primes[b])) && isPrime(concat(primes[b], primes[a]))) 
		{
			pairs[a].Add(primes[b]);
		}
	}
}

private int concat(int a, int b) {
	int c = b;
	while (c > 0) {
		a *= 10;
		c /= 10;
	}

	return a + b;
}

private bool isPrime(int n) {
	if (n <= 1) return false;
	if (n == 2) return true;
	if (n % 2 == 0) return false;
	if (n < 9) return true;
	if (n % 3 == 0) return false;
	if (n % 5 == 0) return false;

	int[] ar = new int[] {
		2, 3
	};
	for (int i = 0; i < ar.Length; i++) {
		if (Witness(ar[i], n)) return false;
	}
	return true;
}

private bool Witness(int a, int n) {
	int t = 0;
	int u = n - 1;
	while ((u & 1) == 0) {
		t++;
		u >>= 1;
	}

	long xi1 = ModularExp(a, u, n);
	long xi2;

	for (int i = 0; i < t; i++) {
		xi2 = xi1 * xi1 % n;
		if ((xi2 == 1) && (xi1 != 1) && (xi1 != (n - 1))) return true;
		xi1 = xi2;
	}
	if (xi1 != 1) return true;
	return false;
}

private long ModularExp(int a, int b, int n) {
	long d = 1;
	int k = 0;
	while ((b >> k) > 0) k++;

	for (int i = k - 1; i >= 0; i--) {
		d = d * d % n;
		if (((b >> i) & 1) > 0) d = d * a % n;
	}

	return d;
}

public int[] ESieve(int upperLimit) {

	int sieveBound = (int)(upperLimit - 1) / 2;
	int upperSqrt = ((int) Math.Sqrt(upperLimit) - 1) / 2;

	BitArray PrimeBits = new BitArray(sieveBound + 1, true);

	for (int i = 1; i <= upperSqrt; i++) {
		if (PrimeBits.Get(i)) {
			for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1) {
				PrimeBits.Set(j, false);
			}
		}
	}

	List < int > numbers = new List < int > ((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
	numbers.Add(2);
	for (int i = 1; i <= sieveBound; i++) {
		if (PrimeBits.Get(i)) {
			numbers.Add(2 * i + 1);
		}
	}

	return numbers.ToArray();
}