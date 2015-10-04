<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

/*
By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.

~~~
3
7 4
2 4 6
8 5 9 3
~~~

That is, 3 + 7 + 4 + 9 = 23.

Find the maximum total from top to bottom of the triangle below:

~~~
...
~~~

*NOTE: As there are only 16384 routes, it is possible to solve this problem by trying every route.
However, Problem 67, is the same challenge with a triangle containing one-hundred rows;
it cannot be solved by brute force, and requires a clever method! ;o)*
*/

int[][] PYRAMID = new int[][]
{
	new int[] { 75 },
	new int[] { 95, 64 },
	new int[] { 17, 47, 82 },
	new int[] { 18, 35, 87, 10 },
	new int[] { 20, 04, 82, 47, 65 },
	new int[] { 19, 01, 23, 75, 03, 34 },
	new int[] { 88, 02, 77, 73, 07, 63, 67 },
	new int[] { 99, 65, 04, 28, 06, 16, 70, 92 },
	new int[] { 41, 41, 26, 56, 83, 40, 80, 70, 33 },
	new int[] { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 },
	new int[] { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 },
	new int[] { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 },
	new int[] { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 },
	new int[] { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 },
	new int[] { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 },
};

void Main()
{
	int[,] cache = new int[PYRAMID.Length, PYRAMID.Length];

	for (int x = 0; x < PYRAMID[PYRAMID.Length - 1].Length; x++)
	{
		cache[PYRAMID.Length - 1, x] = PYRAMID[PYRAMID.Length - 1][x];
    }

	for (int y = PYRAMID.Length - 2; y >= 0; y--)
	{
		for (int x = 0; x < PYRAMID[y].Length; x++)
		{
			cache[y, x] = PYRAMID[y][x] + Math.Max(cache[y+1, x+1], cache[y+1, x]);
		}
	}
	
	cache[0, 0].Dump();
}