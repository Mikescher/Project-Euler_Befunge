<Query Kind="Program" />

/*
A common security method used for online banking is to ask the user for three random characters from a passcode.
For example, if the passcode was 531278, they may ask for the 2nd, 3rd, and 5th characters;
the expected reply would be: 317.

The text file, keylog.txt, contains fifty successful login attempts.

~~~
319 680 180 690 129 620 762 689 762 318
368 710 720 710 629 168 160 689 716 731
736 729 316 729 729 710 769 290 719 680
318 389 162 289 162 718 729 319 790 680
890 362 319 760 316 729 380 319 728 716
~~~

Given that the three characters are always asked for in order,
analyse the file so as to determine the shortest possible secret passcode of unknown length.
*/

// http://www.dickgrune.com/Programs/gnomesort.html
// http://en.wikipedia.org/wiki/Gnome_sort

List<int> KEYS = new List<int>
{
	319, 680, 180, 690, 129, 620, 762, 689, 762, 318,
	368, 710, 720, 710, 629, 168, 160, 689, 716, 731,
	736, 729, 316, 729, 729, 710, 769, 290, 719, 680,
	318, 389, 162, 289, 162, 718, 729, 319, 790, 680,
	890, 362, 319, 760, 316, 729, 380, 319, 728, 716,
};

void Main()
{
	Decode(KEYS);
	Optimized();
}

enum NodeOrder {U, L, G, E}

void Decode(List<int> k)
{
	NodeOrder[,] order = new NodeOrder[10, 10];
	
	for (int i = 0; i < 10; i++)
	{
		order[i, i] = NodeOrder.E;
	}
	
	foreach (var key in k)
	{
		var d = key.ToString().ToCharArray().Select(u => u - '0').ToList();
		
		order[d[0], d[1]] = NodeOrder.L;
		order[d[0], d[2]] = NodeOrder.L;
		order[d[1], d[2]] = NodeOrder.L;
		
		order[d[2], d[1]] = NodeOrder.G;
		order[d[2], d[0]] = NodeOrder.G;
		order[d[1], d[0]] = NodeOrder.G;
	}
	
	var result = KEYS
		.SelectMany(p => p.ToString()
		.ToCharArray()
		.Select(u => u - '0'))
		.Distinct()
		.ToList();
	
	result.Sort(new TabComparer(order));
	
	string.Join("", result.Select(p => p.ToString())).Dump();
	order.Dump();
}

class TabComparer : IComparer<int>
{
	private NodeOrder[,] Order;

	public TabComparer(NodeOrder[,] order)
	{
		Order = order;
	}
	
	public int Compare(int x, int y)
	{
		switch(Order[x, y])
		{
			case NodeOrder.L:
				return -1;
			case NodeOrder.G:
				return 1;
			case NodeOrder.E:
				return 0;
			case NodeOrder.U:
			default:
				x.Dump();
				y.Dump();
				throw new NotImplementedException();
		}
	}
}

// #########################################

void Optimized()
{
	int[,] order = new int[10, 10];
	for (int x = 0; x < 10; x++) for (int y = 0; y < 10; y++) order[x, y] = 9;
	
	
	for (int c = 0; c < 10; c++)
	{
		order[c, c] = 1;
	}
	
	foreach (var key in KEYS)
	{
		var d = key.ToString().ToCharArray().Select(u => u - '0').ToList();
		
		order[d[0], d[1]] = 0;
		order[d[0], d[2]] = 0;
		order[d[1], d[2]] = 0;
		
		order[d[2], d[0]] = 2;
		order[d[2], d[1]] = 2;
		order[d[1], d[0]] = 2;
	}
	
	var result = KEYS
		.SelectMany(p => p.ToString()
		.ToCharArray()
		.Select(u => u - '0'))
		.Distinct()
		.ToList();
	
	// ########<GNOME-SORT>########
	
	int i = 0;
	while (i < result.Count) 
	{
		
		if (i == 0 || order[result[i-1], result[i]] == 0) 
		{
			i++;
		}
		else 
		{
			var tmp = result[i]; 
			result[i] = result[i-1];
			i--;
			result[i] = tmp;
		}
	}
	
	// ######################
	
	string.Join("", result.Select(p => p.ToString())).Dump();
	order.Dump();
}

/*
This is one of the problems i really enjoyed solving.

We make the assumption that our final pass code has no duplicate digits (If we hadn't found a solution we would need to change that part).
This is a pretty good assumption because no attempt has a duplicate digit in it.

> *Side note:* This leaves us with a 8-digit code, because only 8 digits are used (`4` and `5` are missing).

First we generate a 10x10 grid where we remember the absolute ordering of the numbers from our attempts (eg `3` is before `8` or `9` is after `2`).
If we inspect this data we can see that every field (for numbers in our pass code) is set, the fifty login attempts generate more than enough data for this.

> *Side note:* In fact there are only 33 **unique** login attempts

Then we can simply sort an array of the valid digits with this ordering. And - frankly - I find this is a really neat way of doing this.

Because we sort only eight numbers, sorting-performance is not a big factor.
So I searched for the simplest (easiest to implement) sorting algorithm I could find.
This was surprisingly not Bubble-sort, but [Gnome Sort](https://en.wikipedia.org/wiki/Gnome_sort) (accordingly to the author "the simplest sort algorithm").
Which was pretty easy to implement in Befunge (and for 8 values is the runtime of O(n^2) not *that* bad).

A last thing: For a problem where I used an two-dimensional cache **and** that has input data I was surprised to fit everything in the Befunge-93 80x25 size restrictions.
*/