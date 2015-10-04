<Query Kind="Program" />

void Main()
{
	int steps = 0;

	for (int k = 0; ; k++)
	{
		for (int j = k - 1; j > 0; j--)
		{
			steps++;
		
			int pk = k * (3 * k - 1) / 2;
			int pj = j * (3 * j - 1) / 2;
			
			if (isPentagonal(pk - pj) & isPentagonal(pk+pj)) 
			{
				Console.Out.WriteLine(String.Format("P_k = P({0}) = {1}", k, pk));
				Console.Out.WriteLine(String.Format("P_j = P({0}) = {1}", j, pj));
				Console.Out.WriteLine();
				Console.Out.WriteLine(String.Format("D = {0}", pk - pj));
				Console.Out.WriteLine();
				Console.Out.WriteLine(String.Format("MaxSqrt = {0:#,0}", maxSqrt));
				Console.Out.WriteLine();
				Console.Out.WriteLine(String.Format("Steps = {0:#,0}", steps));
				
				return;
			}
		}
	}
}

public int maxSqrt = 0;

public bool isPentagonal(int c) 
{
	maxSqrt = Math.Max(maxSqrt, 1+24*c);

	int sqrt = iSqrt(1 + 24*c);

	return sqrt*sqrt == (1 + 24*c) && sqrt % 6 == 5;
}

// http://en.wikipedia.org/wiki/Methods_of_computing_square_roots#Binary_numeral_system_.28base_2.29
int iSqrt(int a_nInput)
{
    int op  = a_nInput;
    int res = 0;
    int one = 1 << 30;
	
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