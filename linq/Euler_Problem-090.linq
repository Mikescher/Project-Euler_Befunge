<Query Kind="Program" />

/*

Each of the six faces on a cube has a different digit (0 to 9) written on it;
the same is done to a second cube.
By placing the two cubes side-by-side in different positions we can form a variety of 2-digit numbers.

For example, the square number 64 could be formed:

~~~
  +-------+     +-------+
 /       /|    /       /|
+-------+ |   +-------+ |
|       | |   |       | |
|   6   | +   |   4   | +
|       |/    |       |/
+-------+     +-------+
~~~

In fact, by carefully choosing the digits on both cubes it is possible to display
all of the square numbers below one-hundred: `01`, `04`, `09`, `16`, `25`, `36`, `49`, `64`, and `81`.

For example, one way this can be achieved is by placing `{0, 5, 6, 7, 8, 9}` on one cube 
and `{1, 2, 3, 4, 8, 9}` on the other cube.

However, for this problem we shall allow the `6` or `9` to be turned upside-down 
so that an arrangement like `{0, 5, 6, 7, 8, 9}` and `{1, 2, 3, 4, 6, 7}` allows 
for all nine square numbers to be displayed; otherwise it would be impossible to obtain `09`.

In determining a distinct arrangement we are interested in the digits on each cube, not the order.

 - `{1, 2, 3, 4, 5, 6}` is equivalent to `{3, 6, 4, 1, 2, 5}`
 - `{1, 2, 3, 4, 5, 6}` is distinct from `{1, 2, 3, 4, 5, 9}`

But because we are allowing `6` and `9` to be reversed, the two distinct sets in 
the last example both represent the extended set `{1, 2, 3, 4, 5, 6, 9}` for the 
purpose of forming 2-digit numbers.

How many distinct arrangements of the two cubes allow for all of the square numbers to be displayed?

*/

bool[] switches = Enumerable.Repeat(false, 9).ToArray();

int cLeft = 0;
int cRight = 0;

bool[] ctrLeft = Enumerable.Repeat(false, 10).ToArray();
bool[] ctrRight = Enumerable.Repeat(false, 10).ToArray();

List<int> hashes = new List<int>();

int resultCounter = 0;

void Main()
{
	for (; ;)
	{
		ClearVars();

		SetCounter();

		if (cLeft <= 6 && cRight <= 6) PadL();
		
		if (!IncSwitches()) return;
	}
}

void ClearVars()
{
	cLeft = 0;
	cRight = 0;
	ctrLeft = Enumerable.Repeat(false, 10).ToArray();
	ctrRight = Enumerable.Repeat(false, 10).ToArray();
}

bool IncSwitches()
{
	for (int i = 8; ; i--)
	{
		switches[i] = ! switches[i];
		if (switches[i]) return true;
		if (i == 0)
		{
			// ######## FIN ########

			resultCounter.Dump();
			
			return false;

			// #####################
		}
	}
}

void SetCounter()
{
	for (int i = 9; i > 0; i--)
	{
		int square = (i) * (i);
		int v1 = square / 10;
		int v2 = square % 10;
		if (v2 == 9) v2 = 6;

		if (switches[i-1])
		{
			if (!ctrLeft[v1]) cLeft++;
			ctrLeft[v1] = true;
			if (!ctrRight[v2]) cRight++;
			ctrRight[v2] = true;
		}
		else
		{
			if (!ctrLeft[v2]) cLeft++;
			ctrLeft[v2] = true;
			if (!ctrRight[v1]) cRight++;
			ctrRight[v1] = true;
		}
	}
}

void PadL()
{
	if (cLeft < 6)
	{
		for (int i1 = 9; i1 >= 0; i1--)
		{
			if (ctrLeft[i1]) continue;
			
			ctrLeft[i1] = true;
			
			if (cLeft < 5)
			{
				for (int i2 = 9; i2 >= 0; i2--)
				{
					if (ctrLeft[i2]) continue;

					ctrLeft[i2] = true;
					PadR();                                    //0
					ctrLeft[i2] = false;
				}
			}
			else
			{
				PadR();                                        //1
			}

			ctrLeft[i1] = false;
		}
	}
	else
	{
		PadR();                                                //2
	}
}

void PadR()
{
	if (cRight < 6)
	{
		for (int i1 = 9; i1 >= 0; i1--)
		{
			if (ctrRight[i1]) continue;

			ctrRight[i1] = true;

			if (cRight < 5)
			{
				for (int i2 = 9; i2 >= 0; i2--)
				{
					if (ctrRight[i2]) continue;

					ctrRight[i2] = true;
					Pad9();                                // 0
					ctrRight[i2] = false;
				}
			}
			else
			{
				Pad9();                                    // 1
			}

			ctrRight[i1] = false;
		}
	}
	else
	{
		Pad9();                                            // 2
	}
}

//---------------------------------------------------------------------------

void Pad9()
{
	Out();                                                // 0

	if (ctrLeft[6] && !ctrLeft[9] && ctrRight[6] && !ctrRight[9])
	{
		ctrLeft[6] = false;
		ctrLeft[9] = true;

		ctrRight[6] = false;
		ctrRight[9] = true;

		Out();                                         // 2

		ctrLeft[6] = true;
		ctrLeft[9] = false;

		ctrRight[6] = true;
		ctrRight[9] = false;
	}

	if (ctrLeft[6] && !ctrLeft[9])
	{
		ctrLeft[6] = false;
		ctrLeft[9] = true;

		Out();                                           // 1

		ctrLeft[6] = true;
		ctrLeft[9] = false;
	}

	if (ctrRight[6] && !ctrRight[9])
	{
		ctrRight[6] = false;
		ctrRight[9] = true;

		Out();                                         // -1

		ctrRight[6] = true;
		ctrRight[9] = false;
	}
}

int x = 0;
void Out()
{
	var hash = CalcHash();
	if (hashes.Contains(hash)) return;
	
	hashes.Add(hash);

	/*
	var ll = "{" + ctrLeft.Select((b, i) => new { b, i }).Where(p => p.b).Select(p => p.i.ToString()).Aggregate((a, b) => a + "," + b) + "}";
	var rr = "{" + ctrRight.Select((b, i) => new { b, i }).Where(p => p.b).Select(p => p.i.ToString()).Aggregate((a, b) => a + "," + b) + "}";
	if (ll.GetHashCode() > rr.GetHashCode())
	{
		var t = ll;
		ll = rr;
		rr = t;
	}
	string.Format("{0} | {1}", ll, rr).Dump();
	//*/
	
	/*
	x++.Dump();
	ctrLeft.Select(p =>  p ? "1" : "0").Aggregate((a, b) => a + b).Dump();
	ctrRight.Select(p => p ? "1" : "0").Aggregate((a, b) => a + b).Dump();
	"".Dump();
	//*/
	
	resultCounter++;
}

int CalcHash()
{
	int hl = 0;
	for (int i = 0; i < 10; i++) hl = hl*2 + (ctrLeft[i]?1:0);

	int hr = 0;
	for (int i = 0; i < 10; i++) hr = hr*2 + (ctrRight[i]?1:0);
	
	if (hl < hr) return hl * 1024 + hr;
	else         return hr * 1024 + hl;
}