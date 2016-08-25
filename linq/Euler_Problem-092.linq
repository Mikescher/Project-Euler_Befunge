<Query Kind="Program" />

/*
A number chain is created by continuously adding the square of the digits in a number to 
form a new number until it has been seen before.

For example,

44 → 32 → 13 → 10 → 1 → 1
85 → 89 → 145 → 42 → 20 → 4 → 16 → 37 → 58 → 89

Therefore any chain that arrives at 1 or 89 will become stuck in an endless loop. 
What is most amazing is that EVERY starting number will eventually arrive at 1 or 89.

How many starting numbers below ten million will arrive at 89?
*/

const int SIZE = 10 * 1000 * 1000;
readonly int CACHESIZE = 568; // max = 9^2 * 7 = 567    ~    8*71

void Main()
{
	int counter89 = 0;

	int[] cache = new int[CACHESIZE];

	cache[1] = 1;
	cache[89] = 89;

	int[] history = new int[8];
	int hPointer = 0;
	
	int stepCounter = 0;
	
	for (int i = SIZE; i >= 1; i--)
	{
		var n = i;
		
		for (;;stepCounter++)
		{
			if (n < CACHESIZE)
			{
				if (cache[n] == 0) history[hPointer++] = n;

				if (cache[n] == 1)
				{
					
					while (hPointer > 0) cache[history[--hPointer]] = 1;

					break;
				}
				if (cache[n] == 89)
				{
					counter89++;
					while (hPointer > 0) cache[history[--hPointer]] = 89;
						
					break;
				}
			}

			n = Next(n);
		}
	}
	
	counter89.Dump("Result"); // 8581146
	stepCounter.Dump("Steps");
}

int Next(int n)
{
	int r = 0;
	while (n > 0)
	{
		r += (n%10)*(n%10);
		n/=10;
	}
	return r;
}