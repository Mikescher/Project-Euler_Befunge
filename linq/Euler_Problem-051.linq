<Query Kind="Program" />

int[][] patterns = 
{
	new int[]{1, 1, 0, 0, 0, 1},
	new int[]{1, 0, 1, 0, 0, 1},
	new int[]{1, 0, 0, 1, 0, 1},
	new int[]{1, 0, 0, 0, 1, 1},
	new int[]{0, 1, 1, 0, 0, 1},
	new int[]{0, 1, 0, 1, 0, 1},
	new int[]{0, 1, 0, 0, 1, 1},
	new int[]{0, 0, 1, 1, 0, 1},
	new int[]{0, 0, 1, 0, 1, 1},
	new int[]{0, 0, 0, 1, 1, 1},
};

int[] board = new int[6];

void Main()
{
	for(int val=100; val <= 999; val++)
	{
		if (val%2 == 0) continue;
		if (val%5 == 0) continue;
	
		for(int pat=0; pat < 10; pat++ )
		{
			for(int d=0; d <= 2; d++ )
			{
				if (patterns[pat][0] == 0 && d == 0) continue;
			
				int gen = Generate(val, patterns[pat], d);
			
				if (isPrime(gen))
				{
					if (GetFamilySize(val, patterns[pat], d) == (8-1))
					{
						GetDigits(Generate(val, patterns[pat], d), 6)
							.Select((p,i) => patterns[pat][i] == 1 ? p.ToString() : "*")
							.Aggregate((a,b) => a+b)
							.Dump();
						gen.Dump();
						("  (" + Enumerable
							.Range(0, 10)
							.Select(p => Generate(val, patterns[pat], p))
							.Where(p => isPrime(p))
							.Select(p => p.ToString())
							.Aggregate((a,b) => a + ", " + b) + ")").Dump();
							
						
						"".Dump();
						
						return;
					}
				}
			}
		}
	}
}

int GetFamilySize(int value, int[] pattern, int start)
{
	return Enumerable
		.Range(start+1, 9-start)
		.Select(p => Generate(value, pattern, p))
		.Where(p => isPrime(p))
		.Count();
}

int Generate(int value, int[] pattern, int digit)
{
	int[] valuearr = GetDigits(value, 3).ToArray();
	
	int valarrpos = 0;
	for(int i = 0; i < 6; i++)
	{
		if (pattern[i]==1)
			board[i] = valuearr[valarrpos++];
		else
			board[i] = digit;
	}
	
	/*
	value.Dump();
	valuearr.Dump();
	pattern.Dump();
	board.Dump();
	ToNumber(board).Dump();
	"".Dump();
	//*/
	
	return ToNumber(board);
}

int ToNumber(IEnumerable<int> v)
{
	int r = 0;
	
	foreach(int d in v)
	{
		r *= 10;
		r += d;
	}
	
	return r;
}

List<int> GetDigits(int v, int c)
{
	Stack<int> s = new Stack<int>();

	while(v > 0 || c>0)
	{
		s.Push( (int)(v%10) );
		v /= 10;
		c--;
	}
	
	return s.ToList();
}

public bool isPrime(int n)
{
	if (n%2==0)return n==2;
	if (n%3==0)return n==3;

	for(int i = 7; i < n/2; i+=6)
	{
		if (n%i==0)return false;
		if (n%(i-2)==0)return false;
	}
	return n!=1;
}