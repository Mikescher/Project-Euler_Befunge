<Query Kind="Program" />

/*
The first known prime found to exceed one million digits was discovered in 1999, 
and is a Mersenne prime of the form `2^6972593−1`;
it contains exactly 2,098,960 digits. 
Subsequently other Mersenne primes, of the form `2^p−1`, have been found which contain more digits.

However, in 2004 there was found a massive non-Mersenne prime which contains 2,357,207 digits: `28433*2^7830457+1`.

Find the last ten digits of this prime number.
*/

//8739992577

void Main()
{
	Solve64Bit();
	Solve32Bit();
}

void Solve64Bit()
{
	const ulong MOD10 = 10000000000;

	ulong number = 28433;
	for (int i = 0; i < 7830457; i++)
	{
		number = number * 2;
		number = number % MOD10;
	}

	number = number + 1;
	number = number % MOD10;

	number.Dump();
}

void Solve32Bit()
{
	int[] digits = new int[10];

	digits[0] = 0;
	digits[1] = 0;
	digits[2] = 0;
	digits[3] = 0;
	digits[4] = 0;
	digits[5] = 2;
	digits[6] = 8;
	digits[7] = 4;
	digits[8] = 3;
	digits[9] = 3;

	for (int i = 0; i < 7830457; i++)
	{
		int carry = 0;
		for (int d = 9; d >= 0; d--)
		{
			int n = digits[d] * 2 + carry;
			carry = n / 10;
			digits[d] = n % 10;
		}
	}

	{
		int carry = 1;
		for (int d = 9; d >= 0; d--)
		{
			int n = digits[d] + carry;
			carry = n / 10;
			digits[d] = n % 10;
		}
	}

	string.Join("", digits).Dump();
}

// ======== Main file ========
/*
Well this was a really easy one.
We simply multiply the number `28433` 7830457-times with two.
After each multiplication we modulo the result with 2^10 to prevent an overflow and in the end we add one.
This is really simple (the program operates completely on the stack) and works perfectly as long as our interpreter uses at least 64bit numbers.
(But this is a condition for a lot of programs I have written here)

But just for fun I have written an alternative version that uses only 32bit numbers.
You can find it under `Euler_Problem-097 (32bit).b93`
*/

// ======== 32 bit file ========
/*
This is an alternative solution for Problem-097 where we keep our internal numbers small enough that an 32bit interpreter can run this program.
The "trick" is that we represent our number as a list of ten digits and then manually multiply it with two (7830457-times). *(see: long-multiplication)*
Because we only have ten digits (and ignore the carry of the highest digit) we get the modulo operation free-house.

Even with this limitation this is a really easy problem. Don't ask me why it has sch a high number...
*/