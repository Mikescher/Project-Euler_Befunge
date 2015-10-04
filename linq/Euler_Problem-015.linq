<Query Kind="Program" />

/*
Starting in the top left corner of a 2x2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.

![Grid Image](/data/blog/Befunge/p015.gif)

How many such routes are there through a 20x20 grid?
*/

void Main()
{
	long[,] grid = new long[21,21];
	
	for (int x = 0; x < 21; x++)
	{
		for (int y = 0; y < 21; y++)
		{
			if (x == 0 || y == 0)
			{
				grid[x, y] = 1;
			}
			else
			{
				grid[x, y] = grid[x-1, y] + grid[x, y-1];
			}
		}
	}
	
	grid[20, 20].Dump();
}