<Query Kind="Program" />

/*
By counting carefully it can be seen that a rectangular grid measuring 3 by 2 contains eighteen rectangles:

~~~
XOO    XXO    XXX
OOO    OOO    OOO
 6      4      2


XOO    XXO    XXX
XOO    XXO    XXX
 3      2      1
~~~

Although there exists no rectangular grid that contains exactly two million rectangles, 
find the area of the grid with the nearest solution.
*/

const int TARGET = 2*1000*1000;

void Main()
{
	//ShowMap();
	//Solution_Crude();
	//Solution_Map();
	Solution_Optimized();
}

void ShowMap() 
{
	int[,] map = new int[10,10];
	for (int x = 0; x < 10; x++) for (int y = 0; y < 10; y++) map[x,y] = RectPermCount(x,y);
	
	map.Dump();
}

void Solution_Crude()
{
	const int RANGE = 100;

	int best_A = 1;
	int best_B = 1;
	int best_Diff = int.MaxValue;
	
	for (int x = 0; x < RANGE; x++)
	{
		for (int y = 0; y < x; y++)
		{
			int diff = Math.Abs(TARGET - RectPermCount(x, y));
			if (diff < best_Diff)
			{
				string.Format("{0,2}x{1,2} = diff({2,7})        // {3}",x,y,diff,x*y).Dump();
				best_A = x;
				best_B = y;
				best_Diff = diff;
			}
		}
	}
}

void Solution_Map()
{
	int best_Diff = 99999999;
	int best_WW = -1;
	int best_HH = -1;

	int width=1;
	int height=0;
	int perms=0;
	
	while(perms < TARGET)
	{
		width = 1;
		
		int basePerms = perms;
		while (width < height && perms < TARGET)//width
		{	
			if (Math.Abs(TARGET - perms) < best_Diff)
			{
				best_Diff = Math.Abs(TARGET - perms);
				best_WW = width;
				best_HH = height;
				
				string.Format("[{0,3}x{1,3}] = {2,7} ({3,4})", height, width, perms, width*height).Dump();
			}

			width++;
			perms += basePerms*width;
		}
		perms = basePerms;

		height++;
		perms += height;
	}
}

void Solution_Optimized()
{
	int best_Diff = TARGET;
	int best_A = -1;

	int width;
	int incPerms;
		
	int height=0;
	int perms=0;
	while(perms <= TARGET)
	{
		width = 1;
		incPerms = perms;
		while (width < height && incPerms < TARGET)
		{	
			int diff = Math.Abs(TARGET - incPerms);
			if (diff < best_Diff)
			{
				best_Diff = diff;
				best_A = width * height;
			}

			width++;
			incPerms += perms * width;
		}

		height++;
		perms += height;
	}
	
	best_A.Dump();
}

int RectPermCount(int w, int h)
{
	return Enumerable.Range(1, w).SelectMany(subW => Enumerable.Range(1, h).Select(subH => SingleRectPermCount(w, h, subW, subH))).Sum();
}

int SingleRectPermCount(int w, int h, int sw, int sh) 
{ 
	return (w - (sw - 1)) * (h - (sh - 1)); 
}

/*
The key to solve this problem is effectively iterating through the permutations for a given width and height (`perms[w, h]`).

First we look at the baseline with `width=1`. The basic case `perms[1,1]` is `1`.
After that `perms[1,h] = perms[1,h-1] + h` (so we can iterate easily through all these solutions).

With the baseline in place we can see that `perms[w, h] = perms[w, h-1] + perms[w, 1] * h`.

Then we just iterate through all the possibilities and search for the smallest difference.
We can stop increasing the width when `perms[w, 1] > 2,000,000` and similar stop increasing the height when `perms[w, h] > 2,000,000` or `w > h`.
The second conditions stems from the fact that `perms[w, h] == perms[h, w]` *(it's a mirrored functions)*.

Through these limiting conditions and the fact that each step is pretty fast (just a few additions and multiplications) this algorithm is *really* fast.
*(We only test around 10000 values before our search space is depleted)*
*/