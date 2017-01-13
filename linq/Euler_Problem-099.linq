<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Numerics</Namespace>
</Query>

/*
Comparing two numbers written in index form like 2^11 and 3^7 is not difficult, 
as any calculator would confirm that 2^11 = 2048 < 3^7 = 2187.

However, confirming that 632382^518061 > 519432^525806 would be much more difficult, 
as both numbers contain over three million digits.

Using [base_exp.txt](https://projecteuler.net/project/resources/p099_base_exp.txt), 
a 22K text file containing one thousand lines with a base/exponent pair on each line, 
determine which line number has the greatest numerical value.

NOTE: The first two lines in the file represent the numbers in the example given above.

*/
const string URL = @"http://projecteuler.net/project/resources/p099_base_exp.txt";
readonly string FILE = Path.Combine(Path.GetTempPath(), "cache_99.txt");

class LX
{
	public int Line;
	public long Base;
	public long Expo;

	public long ApproxLen1;
	public long ApproxLen2;
}

// 709

void Main()
{
	if (!File.Exists(FILE)) File.WriteAllText(FILE, new WebClient().DownloadString(URL));

	var data = File
		.ReadAllLines(FILE)
		.Select((p, i) => new LX() { Line = i+1, Base = long.Parse(p.Split(',')[0]), Expo = long.Parse(p.Split(',')[1]) })
		.Select(l => new LX() {Line = l.Line, Base = l.Base, Expo = l.Expo, ApproxLen1 = Approx1(l.Base, l.Expo), ApproxLen2 = Approx2(l.Base, l.Expo)})
		.ToList();

	data.OrderByDescending(l => l.ApproxLen2).Dump();
}

long Approx1(long ibase, long iexpo)
{
	return (long)(Math.Log(ibase, 2) * iexpo);
}

const long FACT = 1 * 1000 * 1000; // 1mil

long Approx2(long ibase, long iexpo)
{
	long n = 0;
	long logs = 1;
	while (logs * 2 < ibase) { logs *= 2; n++; }

	long y = FACT * ibase;
	for (int i = 0; i < n; i++) y /= 2;

	long exporp = 0;
	long msum = 0;
	while (y > 1 * FACT)
	{
		long m = 0;
		while (y < 2 * FACT) { y = (y * y) / FACT; m++; }

		y /= 2;

		msum += m;

		long rp = iexpo;
		for (int i = 0; i < msum; i++) rp /= 2;
		if (rp == 0) break;
		exporp += rp;
	}
	
	return n * iexpo + exporp;
}

/*
For every number we normalize the Exponentiation to base 2.
(We search the equivalent Power `2^x`).
And then we only compare the exponents with each other, practically this
means we compare the length of the number in binary representation.

We chose 2 as our base because this way we don't have to worry too much about 
the precision of our calculations (befunge has no native floating point values).
If we would have found two entries with the same (overall highest) exponent, we would 
have to calculate the exponent to a higher precision, but fortunately this did not happen.

From `b^e` we can get the normalized fraction `2^(e * log2(b))`.
But because befunge has no log2 operator we have to go through the dirty work of manually approximating log2.

We use [this][1] algorithm to calculate log2.

First we calculate the integer part by simple searching the biggest number `2^n` where `2^n < b`

Then the real part equals `log2(2^(-n) * b)`, because we don't want to caclulate with real numbers we 
insert a Precision factor `F` (in this program we used a value of 1 million).

Now `y = 2^-n * b` and `rp = log2(y)`. We calculate y by dividing b n-times with two.

Our final result will be `r = n * e + rp * e`. We can already calculate `n*e`, the only missing part is `rp*e`, 
which we will call `exporp`.

Then we repeat the following steps until the value of exporp is no longer changing:

 - count the number of times `m` we have to square `y` until `y >= 2` 
 - `y = y^(2^m) / 2`
 - add `m` to `msum`, the collective sum of all calculated `m` values until now
 - divide `e` `msum`-times by two and add the result to `exporp`

Now we have calculated `exporp`, our result is `r = n * e + exporp`.

With this method we can calculate the exponent of our normalized exponentiation.
Next we simply iterate through the whole inpt and search the line number with the greatest base2-exponent.

[1]: https://en.wikipedia.org/wiki/Binary_logarithm#Iterative_approximation
*/