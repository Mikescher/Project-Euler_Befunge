<Query Kind="Program" />

/*
A Pythagorean triplet is a set of three natural numbers, `a < b < c`, for which, `a^2 + b^2 = c^2`

For example, `3^2 + 4^2 = 9 + 16 = 25 = 5^2`.

There exists exactly one Pythagorean triplet for which `a + b + c = 1000`. Find the product abc.
*/

const int TARGET = 1000;

void Main()
{
	for (int a = 1; a < TARGET; a++)
	{
		for (int b = 1; b < a; b++)
		{
			var c = Math.Sqrt(a*a + b*b);
			
			if (c%1 == 0 && a+b+c == TARGET) string.Format("{0} * {1} * {2} => {3}", a, b, c, a * b * c).Dump();
		}
	}
}