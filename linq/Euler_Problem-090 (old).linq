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

static readonly Tuple<int, int>[] SQUARES =
{
	Tuple.Create(0, 1),
	Tuple.Create(0, 4),
	Tuple.Create(0, 6), // 0 9 (!)
	Tuple.Create(1, 6),
	Tuple.Create(2, 5),
	Tuple.Create(3, 6),
	Tuple.Create(4, 6), // 4 9 (!)
	Tuple.Create(6, 4),
	Tuple.Create(8, 1),
};

void Main()
{
	for (int i = 0; i < 1<<9; i++)
	{
		var arr = Enumerable.Range(0, 9).Select(x => (i & (1<<x)) != 0).ToArray();
	
		Test(arr);
	}
	
	output.Count.Dump();

	foreach (var o in output.OrderBy(p => p)) o.Dump();
}

bool Test(bool[] switches)
{
	HashSet<int> left  = new HashSet<int>();
	HashSet<int> right = new HashSet<int>();
	
	for (int i = 0; i < SQUARES.Count(); i++)
	{
		if (switches[i])
		{
			left.Add(SQUARES[i].Item1);
			right.Add(SQUARES[i].Item2);
		}
		else
		{
			right.Add(SQUARES[i].Item1);
			left.Add(SQUARES[i].Item2);
		}

		if (left.Count > 6 || right.Count > 6)
		{
			return false;
		}
	}

	Pad9(left.ToList(), right.ToList());

	return true;
}

HashSet<string> x = new HashSet<string>();

void Pad9(List<int> left, List<int> right)
{
	PadL(left, right);

	if (left.Contains(6))
		PadL(left.Select(p => (p == 6) ? 9 : p).ToList(), right);

	if (right.Contains(6))
		PadL(left, right.Select(p => (p == 6) ? 9 : p).ToList());

	if (left.Contains(6) && right.Contains(6))
		PadL(left.Select(p => (p == 6) ? 9 : p).ToList(), right.Select(p => (p == 6) ? 9 : p).ToList());
}

void PadL(List<int> left, List<int> right)
{
	if (left.Count == 4)
	{
		for (int i1 = 0; i1 < 10; i1++)
		{
			if (!left.Contains(i1))
			{
				for (int i2 = 0; i2 < 10; i2++)
				{
					if (!left.Contains(i2) && i1!=i2)
						PadR(left.Concat(new[] { i1, i2 }).ToList(), right);
                }
			}
		}
	}
	else if (left.Count == 5)
	{
		for (int i1 = 0; i1 < 10; i1++)
		{
			if (!left.Contains(i1))
				PadR(left.Concat(new[] { i1 }).ToList(), right);
		}
	}
	else
	{
		PadR(left, right);
	}
}

void PadR(List<int> left, List<int> right)
{
	if (right.Count == 4)
	{
		for (int i1 = 0; i1 < 10; i1++)
		{
			if (!right.Contains(i1))
			{
				for (int i2 = 0; i2 < 10; i2++)
				{
					if (!right.Contains(i2) && i1!=i2)
						Out(left, right.Concat(new[] { i1, i2 }).ToList());
                }
			}
		}
	}
	else if (right.Count == 5)
	{
		for (int i1 = 0; i1 < 10; i1++)
		{
			if (!right.Contains(i1))
				Out(left, right.Concat(new[] { i1 }).ToList());
        }
	}
	else
	{
		Out(left, right);
	}
}

HashSet<int> hashlist = new HashSet<int>();
List<string> output = new List<string>();

void Out(List<int> left, List<int> right)
{
	if (!hashlist.Add(CalcHash(left, right))) return;

	var ll = "{" + string.Join(",", left.OrderBy(p => p)) + "}";
	var rr = "{" + string.Join(",", right.OrderBy(p => p)) + "}";
	if (ll.GetHashCode() > rr.GetHashCode())
	{
		var t = ll;
		ll = rr;
		rr = t;
	}
	var o = ll + " | " + rr;

	if (ll == rr) throw new Exception();
	if (ll.CompareTo(rr) == 0) throw new Exception();

	output.Add(o);
}

int CalcHash(List<int> left, List<int> right)
{
	int hl = 0;
	for (int i = 0; i < 10; i++) hl = hl * 2 + (left.Contains(i) ? 1 : 0);

	int hr = 0;
	for (int i = 0; i < 10; i++) hr = hr * 2 + (right.Contains(i) ? 1 : 0);

	if (hl < hr) 
		return (hl << 10) + hr;
	else 
		return (hr << 10) + hl;
}