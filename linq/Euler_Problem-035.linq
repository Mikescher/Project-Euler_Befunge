<Query Kind="Program" />

void Main()
{
	var sieve = ESieve(1000000);


	Console.WriteLine(CheckCircularPrimes(111337, sieve));

	Console.WriteLine(
		sieve.Where(p => CheckCircularPrimes(p, sieve))
	);
	
}

public bool CheckCircularPrimes(int prime, int[] sieve){
    int multiplier = 1;
    int number = prime / 10;
    int count = 1;
 
    while (number > 0) {
		if (number%2 == 0 || number%5 == 0)
			return false;
	
        number /= 10;
        multiplier *= 10;
        count++;
    }
 
    int d;
    number = prime;
    for (int i = 0; i < count; i++) {
        if(! sieve.Contains(number))
			return false;
 
        d = number % 10;
        number = d * multiplier + number / 10;
    }
 
    return true;
}

public int[] ESieve(int upperLimit) {
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
 
    List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
    numbers.Add(2);
 
    for (int i = 1; i <= sieveBound; i++) {
        if (PrimeBits.Get(i)) {
            numbers.Add(2 * i + 1);
        }
    }
 
    return numbers.ToArray();
}
