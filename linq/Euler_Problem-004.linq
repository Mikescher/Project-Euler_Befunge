<Query Kind="Program" />

/*
A palindromic number reads the same both ways.
The largest palindrome made from the product of two 2-digit numbers is `9009 = 91 x 99`.

Find the largest palindrome made from the product of two 3-digit numbers.
*/

const long COMP = 600851475143;

void Main()
{
	Enumerable
		.Range(0, 899)
		.SelectMany(a => Enumerable
							.Range(0, 899)
							.Select(b => new { A = 999 - a, B = 999 - b, P = (999 - a) * (999 - b) }))
		.Where(p => IsPalindrome(p.P))
		.OrderByDescending(p => p.P)
		.First()
		.Dump();
}

private bool IsPalindrome(int number)
{
	int reversed = 0;
	int k = number;

	while (k > 0)
	{
		reversed *= 10;
		reversed += k % 10;
		k /= 10;
	}
	return number == reversed;
}