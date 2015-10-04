<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

/*
Consider quadratic Diophantine equations of the form:

~~~
x^2 – Dy^2 = 1
~~~

For example, when `D=13`, the minimal solution in `x` is `649^2 – 13×180^2 = 1`.

It can be assumed that there are no solutions in positive integers when D is square.

By finding minimal solutions in `x` for `D = {2, 3, 5, 6, 7}`, we obtain the following:

~~~
3^2 – 2×2^2 = 1
2^2 – 3×1^2 = 1
9^2 – 5×4^2 = 1
5^2 – 6×2^2 = 1
8^2 – 7×3^2 = 1
~~~

Hence, by considering minimal solutions in `x` for `D <= 7`, the largest `x` is obtained when `D=5`.

Find the value of `D <= 1000` in minimal solutions of `x` for which the largest value of `x` is obtained.
*/

/*
https://en.wikipedia.org/wiki/Diophantine_equation
https://en.wikipedia.org/wiki/Pell%27s_equation
https://en.wikipedia.org/wiki/Generalized_continued_fraction
http://www.maths.surrey.ac.uk/hosted-sites/R.Knott/Fibonacci/cfINTRO.html#section9.4
*/

/*
maximum bigint size = 40 (bei base-10)
                    = 04 (bei base-2147483648)
 
					
*/

void Main()
{
//GetDiphSolution(109).Dump();
//GetConvergents(109).Take(30).Dump();


	CalcFast().Dump();

//*
	Enumerable
		.Range(3, 1000)
		.Where(p => Math.Pow(isqrt(p), 2) != p)
		.Select(p => new {idx = p, diph = GetDiphSolution(p)})
		.OrderByDescending(p => p.diph.N)
		.Dump();
//*/
}

int CalcFast()
{
	BigInteger N_2; // pre last
	BigInteger N_1; // last
	BigInteger N_0; // now
	
	BigInteger D_2; // pre last
	BigInteger D_1; // last
	BigInteger D_0; // now

	int cf_add;
	int cf_div;
	
	int cf_frac_m;
	
	int isqrt_D;

	int max_idx = -1;
	BigInteger max_val = 0;

	for(int D = 3; D < 1000; D++)
	{
		isqrt_D = isqrt(D);
	
		if (isqrt_D*isqrt_D == D) continue;
	
		N_2 = 0;
		D_2 = 1;
		
		N_1 = 1;
		D_1 = 0;
		
		cf_add = 0;
		cf_div = 1;
		
		for(;;)
		{
			cf_frac_m = (isqrt_D + cf_add) / cf_div;
		
			N_0 = cf_frac_m * N_1 + 1 * N_2;
			D_0 = cf_frac_m * D_1 + 1 * D_2;

			if (N_0*N_0 - D * D_0*D_0 == 1)
			{
				if (N_0 > max_val) {max_val = N_0; max_idx = D;}
				break;
			}
			
			cf_add  = cf_frac_m * cf_div - cf_add;
			cf_div = (D - cf_add * cf_add) / cf_div;
			
			N_2 = N_1;
			N_1 = N_0;
			
			D_2 = D_1;
			D_1 = D_0;
		}
	}
	
	return max_idx;
}

Frac GetDiphSolution(int D)
{
	return GetConvergents(D).FirstOrDefault(p => p.N*p.N - D * p.D*p.D == 1);
}

IEnumerable<Frac> GetConvergents(int sqrt)
{
	List<int> cfrac = GetContinuedFraction(sqrt).ToList();
	
	Func<int, long> b = (idx) => ((idx < cfrac.Count) ? (cfrac[idx]) : (cfrac[(idx-1)%(cfrac.Count-1)+1]));
	
	List<Frac> past = new List<Frac>();
	
	past.Add(new Frac(1, 0));
	past.Add(new Frac(b(0), 1));
	yield return past[1];
	
	for(int n = 2;;n++)
	{
		var N = b(n-1) * past[n-1].N + 1 * past[n-2].N;
		var D = b(n-1) * past[n-1].D + 1 * past[n-2].D;
	
		var f = new Frac(N, D);
		past.Add(f);
		yield return f;
	}
}

IEnumerable<int> GetContinuedFraction(int sqrt) { foreach(var i in GetContinuedFraction(sqrt,0,1)) yield return i; }

IEnumerable<int> GetContinuedFraction(int sqrt, int add, int div)
{
	if (Math.Pow(isqrt(sqrt), 2) == sqrt)
	{
		yield return isqrt(sqrt);
		yield break;
	}
	
	for(int idx = 0;;idx++)
	{
		int s1_m = (isqrt(sqrt)+add)/div;
	
		yield return s1_m;

		add  = s1_m*div - add;
	
		if (div == 1 && idx > 0) break;
	
		div = (sqrt - add*add) / div;
	}
}

// https://en.wikipedia.org/wiki/Integer_square_root
int isqrt(int n)
{
	int pxk = 0;
	int xk = n;
	for(;;)
	{
		int nxk = (xk + n/xk)/2;
		
		if (nxk == xk)  return xk;
		if (nxk == pxk) return xk;
		
		pxk = xk;
		xk = nxk;
	}
}

class Frac 
{
	private readonly BigInteger numerator;
	public BigInteger N { get {return numerator;}}
	private readonly BigInteger denominator;
	public BigInteger D { get {return denominator;}}
	
	public Frac(BigInteger n, BigInteger d) {numerator=n; denominator=d;}
}