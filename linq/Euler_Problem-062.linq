<Query Kind="Program" />

/*
The cube, `41063625 (345^3)`, can be permuted to produce two other cubes: `56623104 (384^3)` and `66430125 (405^3)`. 
In fact, `41063625` is the smallest cube which has exactly three permutations of its digits which are also cube.

Find the smallest cube for which exactly five permutations of its digits are cube.
*/

public const int PERM_COUNT = 5;

public class REP {public long combhash; public long small_cube; public int count;}

void Main()
{
	var dict = new List<REP>();
	
	for(long val = 1;; val++)
	{
		long cube = val*val*val;
		long hash = GetCombinatoricHash(cube);
		
		REP v_rep = dict.SingleOrDefault(p => p.combhash == hash);
		if (v_rep != null)
		{
			v_rep.count++;
			
			if (v_rep.count == PERM_COUNT)
			{
				v_rep.Dump();
				dict.Count().Dump();
				dict.Dump();
				return;
			}
		}
		else
		{
			dict.Add( new REP(){combhash = hash, small_cube = cube, count=1} );
		}
	}
	
}

long GetCombinatoricHash(long value)
{
	long sum = 0;

	while (value > 0)
	{
		sum += (long)Math.Pow((long)9, (1 + value%10));
		value /= 10;
	}
	
	return sum;
}