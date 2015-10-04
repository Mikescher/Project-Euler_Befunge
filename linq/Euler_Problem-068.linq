<Query Kind="Program" />

/*
Consider the following "magic" 3-gon ring, filled with the numbers 1 to 6, and each line adding to nine.

![](https://projecteuler.net/project/images/p068_1.gif)

Working clockwise, and starting from the group of three with the numerically lowest external node (4,3,2 in this example), each solution can be described uniquely.
For example, the above solution can be described by the set: `4,3,2; 6,2,1; 5,1,3`.

It is possible to complete the ring with four different totals: 9, 10, 11, and 12. There are eight solutions in total.

Total |      Solution Set
------|------------------------
9     |  `4,2,3; 5,3,1; 6,1,2`
9     |  `4,3,2; 6,2,1; 5,1,3`
10    |  `2,3,5; 4,5,1; 6,1,3`
10    |  `2,5,3; 6,3,1; 4,1,5`
11    |  `1,4,6; 3,6,2; 5,2,4`
11    |  `1,6,4; 5,4,2; 3,2,6`
12    |  `1,5,6; 2,6,4; 3,4,5`
12    |  `1,6,5; 3,5,4; 2,4,6`

By concatenating each group it is possible to form 9-digit strings; the maximum string for a 3-gon ring is `432621513`.

Using the numbers 1 to 10, and depending on arrangements, it is possible to form 16- and 17-digit strings.
What is the maximum 16-digit string for a "magic" 5-gon ring?

![](https://projecteuler.net/project/images/p068_2.gif)
*/

struct ResVal {public string arr; public int linesum; public string concat;}

void Main()
{
	P68_Full().Dump();   // 5-gon
	
	P68_Simple().Dump(); // 3-gon
}

IEnumerable<ResVal> P68_Full()
{
	int[] numbers = new int[10];   // bzw (numbers-1)
	bool[] pool   = new bool[10];  // false .. false

	int index = 0;
	numbers[0] = 10;
	int linesum = 0;
	
	while(index >= 0)
	{
		numbers[index]--; 
		if (numbers[index] < 0) 
		{
			index--;
			if (index >= 0) pool[numbers[index]] = false;
			continue;
		}
		
		if (pool[numbers[index]])
		{
			continue;
		}
		
		numbers.Take(index+1).Select(p => p.ToString()).Aggregate((a,b) => a+" "+b).Dump();
		
		switch(index)
		{
			case 0:
				if (numbers[0] > 5) continue;
				break;
			case 1:
				if (numbers[1] == 9) continue;
				break;
			case 2:
				linesum = numbers[0] + numbers[1] + numbers[2];
				if (numbers[2] == 9) continue;
				break;
			case 3:
				if (numbers[3] < numbers[0]) continue;
				break;
			case 4:
				if (numbers[2] + numbers[3] + numbers[4] != linesum) continue;
				if (numbers[4] == 9) continue;
				break;
			case 5:
				if (numbers[5] < numbers[0]) continue;
				break;
			case 6:
				if (numbers[4] + numbers[5] + numbers[6] != linesum) continue;
				if (numbers[6] == 9) continue;
				break;
			case 7:
				if (numbers[7] < numbers[0]) continue;
				break;
			case 8:
				if (numbers[6] + numbers[7] + numbers[8] != linesum) continue;
				if (numbers[8] == 9) continue;
				break;
			case 9:
				if (numbers[8] + numbers[9] + numbers[1] != linesum) continue;
				if (numbers[9] < numbers[0]) continue;
				break;
		}
		
		if (index < 9)
		{
			pool[numbers[index]] = true;
			index++;
			numbers[index] = 10;
		}
		else
		{
			var rnums = numbers.Select(p => (p + 1)).ToList();
		
			var sum = rnums[0] + rnums[1] + rnums[2];
			var str = rnums.Select(p => (p == 10) ? "A" : p.ToString()).Aggregate((aa, bb) => aa + " " + bb);
		
			var result = "";
			result += rnums[0].ToString() + rnums[1].ToString() + rnums[2].ToString();
			result += rnums[3].ToString() + rnums[2].ToString() + rnums[4].ToString();
			result += rnums[5].ToString() + rnums[4].ToString() + rnums[6].ToString();
			result += rnums[7].ToString() + rnums[6].ToString() + rnums[8].ToString();
			result += rnums[9].ToString() + rnums[8].ToString() + rnums[1].ToString();
		
			yield return new ResVal()
			{
				arr = str,
				linesum = sum,
				concat = result,
			};
			yield break;
		}
	}
}

IEnumerable<ResVal> P68_Simple()
{
	int[] numbers = new int[6];   // bzw (numbers-1)
	bool[] pool   = new bool[6];  // false .. false

	int index = 0;
	numbers[0] = 6;
	int linesum = 0;
	
	while(index >= 0)
	{
		numbers[index]--;
		//numbers.Take(index+1).Select(p => p.ToString()).Aggregate((a,b) => a+" "+b).Dump();
		if (numbers[index] < 0) 
		{
			index--;
			if (index >= 0) pool[numbers[index]] = false;
			continue;
		}
		
		if (pool[numbers[index]])
		{
			continue;
		}
		
		switch(index)
		{
			case 0:
				if (numbers[0] >= 4) continue;
				break;
			case 1:
				break;
			case 2:
				linesum = numbers[0] + numbers[1] + numbers[2];
				break;
			case 3:
				if (numbers[3] < numbers[0]) continue;
				break;
			case 4:
				if (numbers[2] + numbers[3] + numbers[4] != linesum) continue;
				break;
			case 5:
				if (numbers[4] + numbers[5] + numbers[1] != linesum) continue;
				if (numbers[5] < numbers[0]) continue;
				break;
		}
		
		if (index < 5)
		{
			pool[numbers[index]] = true;
			index++;
			numbers[index] = 6;
		}
		else
		{
			var rnums = numbers.Select(p => (p + 1)).ToList();
		
			var sum = rnums[0] + rnums[1] + rnums[2];
			var str = rnums.Select(p => p.ToString()).Aggregate((aa, bb) => aa + " " + bb);
		
			var result = "";
			result += rnums[0].ToString() + rnums[1].ToString() + rnums[2].ToString();
			result += rnums[3].ToString() + rnums[2].ToString() + rnums[4].ToString();
			result += rnums[5].ToString() + rnums[4].ToString() + rnums[1].ToString();
		
			yield return new ResVal()
			{
				arr = str,
				linesum = sum,
				concat = result,
			};
		}
	}
}