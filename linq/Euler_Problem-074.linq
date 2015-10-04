<Query Kind="Program" />

/*
The number 145 is well known for the property that the sum of the factorial of its digits is equal to 145:

~~~
1! + 4! + 5! = 1 + 24 + 120 = 145
~~~

Perhaps less well known is 169, in that it produces the longest chain of numbers that link back to 169;
it turns out that there are only three such loops that exist:

~~~
169 -> 363601 -> 1454 -> 169
871 -> 45361 -> 871
872 -> 45362 -> 872
~~~

It is not difficult to prove that EVERY starting number will eventually get stuck in a loop. For example,

~~~
69 -> 363600 -> 1454 -> 169 -> 363601 (-> 1454)
78 -> 45360 -> 871 -> 45361 (-> 871)
540 -> 145 (-> 145)
~~~

Starting with 69 produces a chain of five non-repeating terms,
but the longest non-repeating chain with a starting number below one million is sixty terms.

How many chains, with a starting number below one million, contain exactly sixty non-repeating terms?
*/

const int LIMIT = 1000000;

void Main()
{
	DoIt();
}

void DoIt()
{
	int result = 0;
	int[] seqlengths = new int[LIMIT+1];
	seqlengths[169] = 3;
	seqlengths[363601] = 3;
	seqlengths[1454] = 3;
	seqlengths[871] = 2;
	seqlengths[45361] = 2;
	seqlengths[872] = 2;
	seqlengths[45362] = 2;
	
	for (int i = 1; i <= LIMIT; i++) 
	{
		int n = i;                
		int count = 0;
		int arrpos = 0;
		List<int> seq = new List<int>(60);
		seq.Add(0);
					
		while (seq[arrpos] != n) 
		{                    
			seq.Add(n);arrpos++;
			n = FacSum(n);
			count++;
	
			if(n <= LIMIT && seqlengths[n] > 0)
			{
				count += seqlengths[n];
				break;
			}
		}
		if (count == 60) result++;
	
		for (int j = 1; j <= arrpos; j++) 
		{
			if (seq[j] <= LIMIT) seqlengths[seq[j]] = count + 1 - j;
		}
	}
	
	result.Dump();
}

int[] f = {1,1, 2, 6, 24, 120, 720, 5040, 40320, 362880};
public int FacSum(int n){
    int temp = n;
    int facsum = 0;
 
    while (temp > 0) {
        facsum += f[temp % 10];
        temp /= 10;
    }
    return facsum;
}