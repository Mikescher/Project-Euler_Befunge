<Query Kind="Program" />

void Main()
{
	LRange(144L,100000L)
		.Select(p => p * (2*p - 1))
		.Where(p => isPentagonal(p))
		//.Where(p => isTriagonal(p))
		.Dump();
}

public IEnumerable<long> LRange(long start, long end)
{
	while (start < end)
		yield return start++;
}

public bool isTriagonal(long c) 
{
	long sqrt = iSqrt(1 + 8*c);

	return sqrt*sqrt == (1 + 8*c) && sqrt % 2 == 1;
}

public bool isPentagonal(long c) 
{
	long sqrt = iSqrt(1 + 24*c);

	return sqrt*sqrt == (1 + 24*c) && sqrt % 6 == 5;
}

// http://en.wikipedia.org/wiki/Methods_of_computing_square_roots#Binary_numeral_system_.28base_2.29
long iSqrt(long a_nInput)
{
    long op  = a_nInput;
    long res = 0;
    long one = 1L << 48;
	
    while (one > op) one >>= 2;

    while (one != 0)
    {
        if (op >= res + one)
        {
            op = op - (res + one);
            res = res +  2 * one;
        }
        res >>= 1;
        one >>= 2;
    }
	
    return res;
}