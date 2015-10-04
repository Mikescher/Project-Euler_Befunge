<Query Kind="Program" />

int[] perm = Enumerable.Repeat(-1, 10).ToArray();
bool[] digits = Enumerable.Repeat(false, 10).ToArray();
int position = 9;

// 123 div by 2
// 234 div by 3
// 345 div by 5
// 456 div by 7
// 567 div by 11
// 678 div by 13
// 789 div by 17

void Main()
{
	int steps = 0;
	long sum = 0;
		
	while (position < 10)
	{
		inc();
		steps++;

		switch (position)
		{
			case 9:
			case 8:
			case 7:
				// NOP
				break;
			case 6:
				if (getSubStrNum(7, 8, 9) % 17 != 0) dec();
				break;
			case 5:
				if (getSubStrNum(6, 7, 8) % 13 != 0) dec();
				break;
			case 4:
				if (getSubStrNum(5, 6, 7) % 11 != 0) dec();
				break;
			case 3:
				if (getSubStrNum(4, 5, 6) % 7 != 0) dec();
				break;
			case 2:
				if (getSubStrNum(3, 4, 5) % 5 != 0) dec();
				break;
			case 1:
				if (getSubStrNum(2, 3, 4) % 3 != 0) dec();
				break;
			case 0:
				if (getSubStrNum(1, 2, 3) % 2 != 0) dec();
				break;
			case -1:
				position++;
				Console.Out.WriteLine(string.Join(" ", perm.Select(p => string.Format("{0,2}", p))));
				sum += getSubStrNum(0, 1, 2, 3, 4, 5, 6, 7, 8, 9);
				break;
		}
	}
	
	Console.Out.WriteLine();
	Console.Out.WriteLine(sum + " (" + steps + " steps)");
}

void inc()
{
	for(int i = perm[position] + 1; i < 10; i++)
	{
		if (! digits[i]) 
		{
			if (perm[position] >= 0) digits[perm[position]] = false;
			
			digits[i] = true;
			perm[position] = i;
			position--;
			return;
		}
	}
	
	dec();
}

void dec()
{	
	if (perm[position] >= 0)
	{
		digits[perm[position]] = false;
		perm[position] = -1;
	}
	position++;
}

long getSubStrNum(params int[] pos)
{
	return Enumerable
		.Range(0, pos.Length)
		.Select(p => (long)Math.Pow(10, p))
		.Select((p, i) => p * perm[pos.Reverse().ToArray()[i]])
		.Sum();
}