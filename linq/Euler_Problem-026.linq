<Query Kind="Program" />

void Main() // 1 1 1 1 1 6 1 1 1 2 1 6
{

	Console.WriteLine(Enumerable
						.Range(1,1000)
						.Select(getRepCo)
						.Select((p,i) => new {idx = i+1, val = p})
						//.Where(p => p.val > 900)
					);
	//Console.WriteLine(getRepCo(7));
}

int[] grid = new int[1000];

int getRepCo(int d) //   1/d
{
	for(int i = 0; i < 1000; grid[i++] = 0);
	
	int current = 1;
	int position = 0;
	while(true)
	{
		current = (current*10) % d;
		position++;
		
		if (grid[current] != 0)
			return position - grid[current];
		else
			grid[current] = position;
	}
}