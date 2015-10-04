<Query Kind="Program" />

void Main()
{
	Enumerable
		.Range(1, 10 * 1000)
		.Select(p => 10 * 1000 - p)
		.Select(p => new {Number = p, Lychrel = Lychrel(p)})
		.Where(p => p.Lychrel > 50)
		.Dump();
}

private int Lychrel(long number)
{
	number += GetReversed(number);
		
	for (int i = 0; i <= 50; i++)
	{
		long rev = GetReversed(number);
		if (rev == number) return i;
		number += rev;
	}
	
	return 51;
}

private long GetReversed(long number)
{
    long reversed = 0;
    long k = number;
 
    while (k > 0) {
        reversed *= 10;
        reversed += k % 10;
        k /= 10;
    }
	
    return reversed;
}