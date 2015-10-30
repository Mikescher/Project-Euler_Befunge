<Query Kind="Program" />

/*
A spider, **S**, sits in one corner of a cuboid room, measuring `6 by 5 by 3`, 
and a fly, **F**, sits in the opposite corner. 
By travelling on the surfaces of the room the shortest "straight line" 
distance from **S** to **F** is 10 and the path is shown on the diagram.

However, there are up to three "shortest" path candidates for any given cuboid and 
the shortest route doesn't always have integer length.

It can be shown that there are exactly `2060` distinct cuboids, ignoring rotations, 
with integer dimensions, up to a maximum size of `M by M by M`, 
for which the shortest route has integer length when `M = 100`. 
This is the least value of M for which the number of solutions first exceeds two thousand; 
the number of solutions when `M = 99` is `1975`.

Find the least value of M such that the number of solutions first exceeds one million.
*/

//const int LIMIT = 1 * 1000 * 1000;
const int LIMIT = 2000;

void Main()
{
	int sum = 0;
	for (int i = 1;; i++)
	{
		sum += CuboidCount2(i);

		if (sum >= LIMIT)
		{
			sum.Dump("Distinct values");
			i.Dump("M");
			IMAX.Dump("IMAX");
			return;
		}
	}

}

int CuboidCount1(int M)
{
	int cnt = 0;

	for (int b = 1; b <= M; b++)
	{
		for (int c = 1; c <= b; c++)
		{
			if (Math.Sqrt(M * M + (b + c) * (b + c)) % 1 == 0.0)
			{
				cnt++;
			}
		}
	}

	return cnt;
}

int CuboidCount2(int M)
{
	int cnt = 0;

	for (int bc = 1; bc <= M; bc++)
	{
		if (isISqrt(M * M + bc * bc))
		{
			cnt += bc/2;
		}
	}

	for (int bc = M+1; bc <= 2 * M; bc++)
	{
		if (isISqrt(M * M + bc * bc))
		{
			cnt += M - (bc+1)/2 + 1;
		}
	}

	return cnt;
}

int CuboidCount3(int M)
{
	int cnt = 0;

	for (int bc = 2*M; bc >= 0; bc--)
	{
		if (isISqrt(M * M + bc * bc))
		{
			if (bc <= M) cnt += bc / 2;
			else         cnt += M - (bc+1)/2 + 1;

		}
	}

	return cnt;
}

int IMAX = 0;

public bool isISqrt(int x)
{
	IMAX = Math.Max(IMAX, x);

	// http://www.ask-math.com/properties-of-square-numbers.html
	// http://www.johndcook.com/blog/2008/11/17/fast-way-to-test-whether-a-number-is-a-square/
	// http://stackoverflow.com/questions/295579/fastest-way-to-determine-if-an-integers-square-root-is-an-integer

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
	if (x % 3  == 2) return false;

	return Math.Pow(isqrt(x), 2) == x;
}

// https://en.wikipedia.org/wiki/Integer_square_root
int isqrt(int n)
{
	int pxk = 0;
	int xk = n;
	for (;;)
	{
		int nxk = (xk + n / xk) / 2;

		if (nxk == xk) return xk;
		if (nxk == pxk) return xk;

		pxk = xk;
		xk = nxk;
	}
}


/*

The spider essentially travels on the hypotenuse of a triangle with the sides `A` and `B+C`.
For it to be the shortest path the condition `A <= B+C` must be true.

The amount of integer-cuboids for a given value M is "All integer-cuboids with `A=M`" plus integer-cuboids(M-1).
In our loop we start with `M=1` and increment it in every step.
We also remember the last value (for `M-1`) and loop until the value exceeds one million.

For a given value `A = M` we go through all possible `BC` value (`0 <= BC <= 2*A`) and test if `M^2 + BC^2` is an integer-square.
If such a number is found and `BC <= A` then this means we have found `BC/2` additional cuboids (there are `BC/2` different `B+C = BC` combinations where `B <= C`)
If, on the other hand `BC > A` then we have only found `A - (BC + 1)/2 + 1` additional cuboids (because the condition`A <= BC` must be satisfied).

One of the more interesting parts was the `isSquareNumber()` function, which test if a number `x` has an integer square-root.
To speed this function up *(it takes most of the runtime)* we can eliminate around 12% of the numbers with a few clever tricks.
For example if the last digit of `x` is `2`, x is never a perfect square-number. Or equally if the last hex-digit is `7`.
In our program we test twelve conditions like that:

~~~
(x % 64)  > 57
(x % 16) ==  2
(x % 16) ==  3
(x % 16) ==  5
(x % 16) ==  6
(x % 16) ==  7
(x % 16) ==  8
(x % 16)  >  9
(x % 10) ==  2
(x % 10) ==  3
(x % 10) ==  7
(x %  3) ==  2
~~~
**Sources:**
 - [ask-math.com](http://www.ask-math.com/properties-of-square-numbers.html)
 - [johndcook.com](http://www.johndcook.com/blog/2008/11/17/fast-way-to-test-whether-a-number-is-a-square/)
 - [stackoverflow.com](http://stackoverflow.com/questions/295579/fastest-way-to-determine-if-an-integers-square-root-is-an-integer)

If none of this pre-conditions is true we have to manually test the number.
We use the same the same [integer-squareroot](https://en.wikipedia.org/wiki/Integer_square_root) algorithm as in previous problems.
If `isqrt(x)^2 == x` the we can be sure that x is a perfect square number.

*/