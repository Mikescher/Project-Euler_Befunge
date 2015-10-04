<Query Kind="Program" />

//const int SUMMAX = 100; // 41 = 2 + 3 + 5 + 7 + 11 + 13
//const int SUMMAX = 2000;  // (shorted)
const int SUMMAX = 1000000; // SUM[3, 545] = 997651

void Main()
{
	Enumerable.Repeat(sumPrimes(), 1).Dump();
}

string sumPrimes()
{
	long[] primes = ESieve(SUMMAX);
	
	int min = 0;
	int max = -1;
	long value = 0;
	while (value + primes[max+1] < SUMMAX)
		value += primes[++max];

	int direction = 1;
	
	while(value > 0)
	{
		for(;;)
		{
			if (primes.Contains(value))
				return string.Format("SUM[{0}, {1}] = {2} ({3} values)", min, max, value, (max-min+1));
		
			if (min+direction < 0) 
			{			
				string.Format("{0}[{1},{2}] ( {3} ) = {4,-7} |->| {5,-8}  {6}{6}{6}", (max-min+1), min, max, direction>0?'>':'<', value, "???", "X").Dump();
				break;
			}
		
			long nv;
			if (direction == -1)
				nv = value + primes[min-1] - primes[max];
			else
				nv = value - primes[min] + primes[max+1];
				
			string.Format("{0}[{1},{2}] ( {3} ) = {4,-7} |->| {5,-8}  {6}{6}{6}", (max-min+1), min, max, direction>0?'>':'<', value, nv, nv >= SUMMAX?"X":"").Dump();
			
			if (nv >= SUMMAX)
				break;
				
			value = nv;
			min += direction;
			max += direction;
			
			if (value > SUMMAX)
				throw new Exception("overflow");
			if (Enumerable.Range(min, max-min+1).Select(p => primes[p]).Sum() != value)
				throw new Exception(string.Join(" + ", Enumerable.Range(min, max-min+1).Select(p => primes[p].ToString())) + " != " + value);
		}

		if (direction == -1)
		{
			string.Format("{0}[{1},{2}] ({3}{3}{3}) = {4,-7} |->| {5,-8}", (max-min+1), min, max-1, '>', value, (value - primes[max])).Dump();
			value -= primes[max--];
		}
		else
		{
			string.Format("{0}[{1},{2}] ({3}{3}{3}) = {4,-7} |->| {5,-8}", (max-min+1), min+1, max, '<', value, (value - primes[min])).Dump();
			value -= primes[min++];
		}
			
		
		direction *= -1;
	}
	
	return "ERR";
}

public static long[] ESieve(int upperLimit) {
    int sieveBound = (int)(upperLimit - 1) / 2;
    int upperSqrt = ((int)Math.Sqrt(upperLimit) - 1) / 2;
 
    BitArray PrimeBits = new BitArray(sieveBound + 1, true);
 
    for (int i = 1; i <= upperSqrt; i++) {
        if (PrimeBits.Get(i)) {
            for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1) {
                PrimeBits.Set(j, false);
            }
        }
    }
 
    List<long> numbers = new List<long>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
    numbers.Add(2);
 
    for (int i = 1; i <= sieveBound; i++) {
        if (PrimeBits.Get(i)) {
            numbers.Add(2 * i + 1);
        }
    }
 
    return numbers.ToArray();
}