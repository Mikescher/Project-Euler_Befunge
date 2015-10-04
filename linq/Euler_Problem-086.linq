<Query Kind="Program" />

/*
A spider, S, sits in one corner of a cuboid room, measuring `6 by 5 by 3`, and a fly, F, sits in the opposite corner.
By travelling on the surfaces of the room the shortest "straight line" distance from S to F is `10` and the path is shown on the diagram.

However, there are up to three "shortest" path candidates for any given cuboid and the shortest route doesn't always have integer length.

It can be shown that there are exactly `2060` distinct cuboids, ignoring rotations, with integer dimensions, 
up to a maximum size of `M by M by M`, for which the shortest route has integer length when `M = 100`. 
This is the least value of M for which the number of solutions first exceeds two thousand; 
the number of solutions when `M = 99` is `1975`.

Find the least value of M such that the number of solutions first exceeds one million.

*/

const int LIMIT = 100;

void Main()
{
	Brute();

	//	Fail();
}

void Brute()
{
	int ccc = 0;

	for (int a = 1; a <= LIMIT; a++)
	{
		for (int b = 1; b <= a; b++)
		{
			for (int c = 1; c <= b; c++)
			{
				var p1 = Math.Sqrt((a + b) * (a + b) + c * c);
				var p2 = Math.Sqrt((a + c) * (a + c) + b * b);
				var p3 = Math.Sqrt((c + b) * (c + b) + a * a);
				
				var pmin = Math.Min(p1, Math.Min(p2, p3));
			
				if (p1 % 1 == 0 && p1 == pmin)
					ccc++;
				else if (p2 % 1 == 0 && p2 == pmin)
					ccc++;
				else if (p3 % 1 == 0 && p3 == pmin)
					ccc++;
			}
		}
	}
	ccc.Dump();
}

void Fail()
{
	bool[,,] cache = new bool[LIMIT, LIMIT, LIMIT];

	for (int m = 0; m < LIMIT; m++)
	{
		for (int n = 0; n < m; n++)
		{
			// y^2 + b^2 = c^2
			int a = m * m - n * n;
			int b = 2 * m * n;
			int c = m * m + n * n;
			if (a > b) { int t = a; a = b; b = t; };

			for (int k = 0; k * b < LIMIT; k++)
			{
				int ka = k * a;
				int kb = k * b;
				int kc = k * c;

				for (int seg = 1; seg <= ka / 2 && ka - seg <= kb; seg++) cache[seg, ka - seg, kb] = true;
				for (int seg = 1; seg <= kb / 2 && kb - seg <= kb; seg++) cache[seg, kb - seg, ka] = true;
			}
		}
	}

	int cnt = 0;
	for (int c = 0; c < LIMIT; c++)
		for (int b = 0; b <= c; b++)
			for (int a = 0; a <= b; a++)
				if (cache[a, b, c]) { cnt++; string.Format("[{0} - {1} - {2}]", a, b, c).Dump();}
				
	cnt.Dump();
}
