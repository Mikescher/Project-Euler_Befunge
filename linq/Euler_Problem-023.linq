<Query Kind="Program" />

void Main()
{
	const int limit = 1600;
	//const int limit = 30000;
	List<int> abundent = new List<int>();
	int[] primelist = ESieve((int)Math.Sqrt(limit));
	
	// Find all abundant numbers
	for (int i = 2; i <= limit; i++) {
		if (sumOfFactorsPrime(i, primelist) > i) {
			abundent.Add(i);
		}
	}
	
		// Make all the sums of two abundant numbers
	bool[] canBeWrittenasAbundent = new bool[limit + 1];
	for (int i = 0; i < abundent.Count; i++) {
		for (int j = i; j < abundent.Count; j++) {
			if (abundent[i] + abundent[j] <= limit) {
				canBeWrittenasAbundent[abundent[i] + abundent[j]] = true;
			} else {
				break;
			}
		}
	}
	
	Console.Out.WriteLine(Enumerable.Range(0,limit+1).Where(i => !canBeWrittenasAbundent[i]).Sum());
	Console.Out.WriteLine(Enumerable.Range(0,limit+1).Where(i => canBeWrittenasAbundent[i]));
}
private int sumOfFactors(int number) {

  int sqrtOfNumber = (int)Math.Sqrt(number);
  int sum = 1;

  //If the number is a perfect square
  //Count the squareroot once in the sum of factors
  if (number == sqrtOfNumber * sqrtOfNumber) {
      sum += sqrtOfNumber;
      sqrtOfNumber--;
  }

  for (int i = 2; i <= sqrtOfNumber; i++) {
      if (number % i == 0) {
          sum = sum + i + (number / i);
      }
  }

  return sum;
}



private int sumOfFactorsPrime(int number, int[] primelist) {
  int n = number;
  int sum = 1;
  int p = primelist[0];
  int j;
  int i = 0;

  while (p * p <= n && n > 1 && i < primelist.Length) {
      p = primelist[i];
      i++;
      if (n % p == 0) {
          j = p * p;
          n = n / p;
          while (n % p == 0) {
              j = j * p;
              n = n / p;
          }
          sum = sum * (j - 1) / (p - 1);
      }
  }
  
  //A prime factor larger than the square root remains, so add that
  if (n > 1) {
      sum *= n + 1;
  }
  return sum - number;
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
// Define other methods and classes here
