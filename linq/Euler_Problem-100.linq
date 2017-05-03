<Query Kind="Program" />

/*
If a box contains twenty-one coloured discs, composed of fifteen blue discs and six red discs, 
and two discs were taken at random, it can be seen that the probability of taking two blue discs, 
`P(BB) = (15/21)x(14/20) = 1/2`.

The next such arrangement, for which there is exactly 50% chance of taking two blue discs at random, 
is a box containing eighty-five blue discs and thirty-five red discs.

By finding the first arrangement to contain over `10^12 = 1,000,000,000,000` discs in total, 
determine the number of blue discs that the box would contain.
*/
//===================================================================================================//
/*
 Solutions:
 ==========
 
 b    | r    | n
 -----|------|-----
 15   | 6    | 21
 85   | 35   | 120
 493  | 204  | 697
 2871 | 1189 | 4060
 
*/
//===================================================================================================//
/*
n = count of disks
b = blue disks
r = red  disks


b+r = n
b < n
r < n
n > 10^12

(b/n)*((b-1)/(n-1)) = 1/2
2*b*(b-1) = n * (n-1)
2*b^2 - 2*b = n^2 - n
2 * (b^2 - b) = n^2-n
0.5 * (2b)^2 - (2b) = (n)^2 - (n)
2*(b^2) - 2b = (n)^2 - (n)

b = 1/2 ( sqrt(2n^2 - 2n + 1) + 1 )
bzw
n = 1/2 ( sqrt(8b^2 - 8b + 1) + 1)

sqrt(8b^2 - 8b + 1) must be int (and odd, which it is implicit) and bigger 10^12

*/
/*
!wa Integer solutions:
www.wolframalpha.com/input/?i=2*b*b-2b+%3D+n*n-n

b = (1/8) * (  2*(3-2*s)^m  +  s*(3-2*s)^m  +  2*(3+2*s)^m  -  s*(3+2*s)^m  +  4)
n = (1/4) * (   -(3-2*s)^m  -  s*(3-2*s)^m  -    (3+2*s)^m  +  s*(3+2*s)^m  +  2)
m element Z, 
m>=0
*/

// solution: b=756872327473    r=313506783024    n=1070379110497 

public class SqNum 
{ 
	public long Real=1;
	public long SqRoot = 0;
	public SqNum() { }
	public SqNum(long r, long s) {Real=r;SqRoot=s;}
}

const long MAX = 1L * 1000 * 1000 * 1000 * 1000;

void Main()
{
	//Solve_Bruteforce();
	//Solve_Walpha();
	Solve_Bef();
}

public void Solve_Bruteforce()
{
	for (long n = 1L /* * 1000 * 1000 * 1000 * 1000*/; ; n++)
	{
		//if (n % (1000 * 1000) == 0) n.Dump();

		if (isISqrt(2 * n * n - 2 * n + 1)) // <- overflow
		{
			long sq = (long)(Math.Sqrt(2 * n * n - 2 * n + 1) + 1);
			if (sq % 2 == 0)
			{
				long b = (long)(0.5 * sq);
				long r = n - b;
				$"b={b.ToString().PadRight(14)}  r={r.ToString().PadRight(14)}  n={n.ToString().PadRight(14)}".Dump();
			}
		}
	}
}

public void Solve_Walpha()
{
	for (int m = 2;; m++)
	{
		long n = CalcN(m);
		long b = CalcB(m);
		long r = n - b;
		$"b={b.ToString().PadRight(14)}  r={r.ToString().PadRight(14)}  n={n.ToString().PadRight(14)}".Dump();

		if (n > MAX) return;
	}
}

public void Solve_Bef()
{
	long tmp;

	long vr_pos = 1; // (3+2*s)^m
	long vs_pos = 0;
	
	long vr_neg = 1; // (3-2*s)^m
	long vs_neg = 0;

	for (;;)
	{
		tmp = vr_pos;
		vr_pos = 3 * vr_pos + 4 * vs_pos;
		vs_pos = 3 * vs_pos + 2 * tmp;

		tmp = vr_neg;
		vr_neg = 3 * vr_neg - 4 * vs_neg;
		vs_neg = 3 * vs_neg - 2 * tmp;

		long n = (2 + 2 * vs_pos - 1 * vr_pos - 2 * vs_neg - 1 * vr_neg) / 4;
		long b = (4 - 2 * vs_pos + 2 * vr_pos + 2 * vs_neg + 2 * vr_neg) / 8;

		long r = n - b;

		$"b={b.ToString().PadRight(14)}  r={r.ToString().PadRight(14)}  n={n.ToString().PadRight(14)}".Dump();

		if (n > MAX) return;
	}
}

public long CalcN(long m)
{
	// n = (1/4) * (-(3-2*s)^m  -  s*(3-2*s)^m  -  (3+2*s)^m  +  s*(3+2*s)^m  +  2)

	SqNum p1 = Mult(new SqNum(-1, 00), Pot(new SqNum(3, -2), m));  // -1 * (3 - 2*s)^m
	SqNum p2 = Mult(new SqNum(00, -1), Pot(new SqNum(3, -2), m));  // -s * (3 - 2*s)^m
	SqNum p3 = Mult(new SqNum(-1, 00), Pot(new SqNum(3, +2), m));  // -1 * (3 + 2*s)^m
	SqNum p4 = Mult(new SqNum(00, +1), Pot(new SqNum(3, +2), m));  // +s * (3 + 2*s)^m

	SqNum r = Add(p1, p2, p3, p4, new SqNum(2, 0));

	// n = (1/4) * (p1 + p2 + p3 + p4 + 2)
	
	if (r.SqRoot != 0)   throw new Exception($"SqRoot = {r.SqRoot} | Real = {r.Real} | (s <> 0)");
	if (r.Real % 4 != 0) throw new Exception($"SqRoot = {r.SqRoot} | Real = {r.Real} | (r%4 <> 0)");
	
	return r.Real / 4;
}

public long CalcB(long m)
{
	// b = (1/8) * (  2*(3-2*s)^m  +  s*(3-2*s)^m  +  2*(3+2*s)^m  -  s*(3+2*s)^m  +  4)

	SqNum p1 = Mult(new SqNum(+2, 00), Pot(new SqNum(3, -2), m));  // +2  * (3 - 2*s)^m
	SqNum p2 = Mult(new SqNum(00, +1), Pot(new SqNum(3, -2), m));  // +s  * (3 - 2*s)^m
	SqNum p3 = Mult(new SqNum(+2, 00), Pot(new SqNum(3, +2), m));  // +2  * (3 + 2*s)^m
	SqNum p4 = Mult(new SqNum(00, -1), Pot(new SqNum(3, +2), m));  // -s  * (3 + 2*s)^m

	SqNum r = Add(p1, p2, p3, p4, new SqNum(4, 0));

	// n = (1/8) * (p1 + p2 + p3 + p4 + 4)

	if (r.SqRoot != 0)   throw new Exception($"SqRoot = {r.SqRoot} | Real = {r.Real} | (s <> 0)");
	if (r.Real % 8 != 0) throw new Exception($"SqRoot = {r.SqRoot} | Real = {r.Real} | (r%8 <> 0)");

	return r.Real / 8;
}

public SqNum Pot(SqNum input, long pot)
{
	var n = new SqNum();
	for (int i = 0; i < pot; i++) n = Mult(n, input);
	return n;
}

public SqNum Mult(SqNum a, SqNum b)
{
	return new SqNum() 
	{
		Real=a.Real*b.Real + a.SqRoot * b.SqRoot * 2,
		SqRoot = a.SqRoot * b.Real + a.Real * b.SqRoot
	};
}

public SqNum Add(params SqNum[] p)
{
	return new SqNum()
	{
		Real = p.Sum(x => x.Real),
		SqRoot = p.Sum(x => x.SqRoot),
	};
}

// @see Euler-086
public bool isISqrt(long x)
{
	if (x % 16 > 9) return false;
	if (x % 64 > 57) return false;
	if (x % 16 == 2) return false;
	if (x % 16 == 3) return false;
	if (x % 16 == 5) return false;
	if (x % 16 == 6) return false;
	if (x % 16 == 7) return false;
	if (x % 16 == 8) return false;
	if (x % 10 == 2) return false;
	if (x % 10 == 3) return false;
	if (x % 10 == 7) return false;
	if (x % 3 == 2) return false;

	return Math.Pow(isqrt(x), 2) == x;
}

// https://en.wikipedia.org/wiki/Integer_square_root
long isqrt(long n)
{
	long pxk = 0;
	long xk = n;
	for (; ;)
	{
		long nxk = (xk + n / xk) / 2;

		if (nxk == xk) return xk;
		if (nxk == pxk) return xk;

		pxk = xk;
		xk = nxk;
	}
}

/*
Let's say `b` is the number of blue disks, `r` the number of red disks 
and `n` is the total number.
From the problem description we can infer this:
~~~
b+r = n                    (1)
0 < b < n                  (2)
0 < r < n                  (3)
n > 10^12                  (4)
(b/n)*((b-1)/(n-1)) = 1/2  (5)
~~~

Now we can user (1) and (2) to get a formula for `b` and `n`:

~~~
(b/n)*((b-1)/(n-1)) = 1/2
2*b*(b-1) = n * (n-1)
2*b^2 - 2*b = n^2 - n
2 * (b^2 - b) = n^2-n
0.5 * (2b)^2 - (2b) = (n)^2 - (n)
2*(b^2) - 2b = (n)^2 - (n)

b = 1/2 ( sqrt(2n^2 - 2n + 1) + 1 )
~~~

For the last formula we search for integer solutions.
We can now either solve this manually with diophantine equations,
or we ask [Wolfram|Alpha](www.wolframalpha.com/input/?i=2*b*b-2b+%3D+n*n-n).
Which gives us the following two formulas:

~~~
s = sqrt(2)

b = (1/8) * (  2*(3-2*s)^m  +  s*(3-2*s)^m  +  2*(3+2*s)^m  -  s*(3+2*s)^m  +  4)
n = (1/4) * (   -(3-2*s)^m  -  s*(3-2*s)^m  -    (3+2*s)^m  +  s*(3+2*s)^m  +  2)

m element Z, m >= 0
~~~

We can see both formulas contain the expression sqrt(2), which is not 
only fractional but also irrational. Which is a problem with the strict integer
operations in befunge.

But we can sidestep this by using a special number notation `r * 1 + s * sqrt(2)`.
In every step we calculate the "real" part of the number plus a multiple of `sqrt(2)`.
This is kinda like the common notation of [imaginary numbers](https://en.wikipedia.org/wiki/Imaginary_number).

Now all we have to do is create algorithms for addition and multiplication in our new number format.

~~~
(r1 + s1 * sqrt(2)) + (r2 + s2 * sqrt(2)) = (r1+r2) + (s1+s2) * sqrt(2)
(r1 + s1 * sqrt(2)) * (r2 + s2 * sqrt(2)) = (r1*r2+2*s1*s2) + (s1*r2+r1*s2) * sqrt(2)
~~~

Now we can use the formulas from Wolfram|Alpha until we find a value for `n > 10^12`.

In the end this problem wasn't that hard to code when all the prepreations were done.
Also it's pretty fast.
*/