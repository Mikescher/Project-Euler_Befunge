<Query Kind="Program" />

/*
It is possible to write five as a sum in exactly six different ways:

~~~
4 + 1
3 + 2
3 + 1 + 1
2 + 2 + 1
2 + 1 + 1 + 1
1 + 1 + 1 + 1 + 1
~~~

How many different ways can one hundred be written as a sum of at least two positive integers?
*/

const int SUM = 100;

void Main()
{
	Stopwatch w = new Stopwatch();
	
	w.Restart();
	{
		Extended();
	}
	w.Stop();
	w.Elapsed.Dump("Extended");
	
	w.Restart();
	{
		Optimized();
	}
	w.Stop();
	w.Elapsed.Dump("Optimized");
}

void Extended()
{
	int[,] cache = new int[SUM + 1, SUM + 1]; // [FIRST_DIGIT, SUM]
	
	for (int i = 1; i <= SUM; i++)
	{
		for (int n = i-1; n >= 1; n--)
		{
			int count = 0;
			for (int v = Math.Min(i-n, n); v >= 0; v--)
			{
				count += cache[v, i-n];
			}
			cache[n, i] = count;
			
			//string.Format("{0} = {1} + {{{2}}}", i, n, count).Dump();
		}
		cache[i, i] = 1;
		
		//string.Format("{0} = {0}", i).Dump();
	}
	
	//cache.Dump();
	Enumerable.Range(0, SUM).Sum(fd => cache[fd, SUM]).Dump();
}

void Optimized()
{
	int[,] cache = new int[SUM + 1, SUM + 1];
	
	for (int i = 1; i <= SUM; i++)
	{
		int count = 0;
		for (int n = 1; n < i; n++)
		{
			count += cache[Math.Min(i-n, n), i-n];
			cache[n, i] = count;
		}
		cache[i, i] = count + 1;
	}
	
	//cache.Dump();
	cache[SUM-1, SUM].Dump();
}

/*
The big trick is - similiar to many other problems - *caching*.

This problem remembered me a little bit of problem-15.
We use a `100x100` grid to remember pre calculated sums.

So in cell [3, 6] is the amount of sums which result in `6`, start with `3` and have all summands in descending order:

~~~
3 + 3
3 + 2 + 1
3 + 1 + 1
~~~

You see `cache[3,6] = 3`.

Now to find a new value (for example `[4, 7]`) we just have to look at the our cache:

~~~
7 = 4 + x
sum(x) = 7-4 = 3

// first_digit_of_x <= first_digi, because of the descending order
sum(x) = sum([n, 3]); n = [1..3]
sum(x) = [3, 3] + [2, 3] + [1, 3] 
~~~

You see it's important not only to remember the amount but also the first (= highest) summand, 
so we can guarantee the oder of the sums (an this way that we don't count any sums multiple times).

*Note:* `cache[a, a]` is always `1`. But teh problem rules dictate that when we calculate the final result we must ignore this (`100 = 100` is not a valid solution)

Oh and this algorithmus improves the native aproach (enumerating all solutions) from `O(wtf)` to `O(n^2)`.
I'm not sure if I would be still alive when my first algorithm finishes :)

----

**Edit:** 

I did a little optimization:

The value of cell `[d, s]` is now the sum of all previous cells from `[0, s]` to `[d, s]`.

This way we don't have to iterate through all the cells from 0 to d every time.
We can just look at the biggest cell which contains the sum of all previous.

*/