<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

/*
A permutation is an ordered arrangement of objects.
For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4.
If all of the permutations are listed numerically or alphabetically, we call it lexicographic order.
The lexicographic permutations of 0, 1 and 2 are:

~~~
012   021   102   120   201   210
~~~

What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
*/

const int NUMBER = 1 * 1000 * 1000;

void Main()
{
	List<int> unused = Enumerable.Range(0, 10).ToList();
	
	int limit = NUMBER-1;
	
	for (int i = 0; i < 10; i++)
	{
		for (int d = unused.Count - 1; d >= 0; d--)
		{
			if (d * Fac(9 - i) <= limit)
			{
				limit -= d * Fac(9 - i);
				
				Console.Write(unused[d]);
				
				unused.RemoveAt(d);
				break;
			}
		}
	}
	
}

int Fac(int x)
{
	if (x == 0) return 1;
	if (x == 1) return 1;
	return Enumerable.Range(1, x).Aggregate((a, b) => a * b);
}