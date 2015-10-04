<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

/*
In England the currency is made up of pound, £, and pence, p, and there are eight coins in general circulation:

1p, 2p, 5p, 10p, 20p, 50p, £1 (100p) and £2 (200p).

It is possible to make £2 in the following way:

1 x £1 + 1 x 50p + 2 x 20p + 1 x 5p + 1 x 2p + 3 x 1p

How many different ways can £2 be made using any number of coins?
*/

int[] COINS = new int[] { 1, 2, 5, 10, 20, 50, 100, 200 };
int TARGET = 200;

void Main()
{
	int[] ammu = new int[9];

	int sum = 0;

	int rrr = 0;

	for (; ;)
	{
		if (sum == TARGET) 
		{ 
			rrr++; 
			//ammu.Select(p => string.Format("{0,3}", p)).Aggregate((a, b) => a + " " + b).Dump(); 
		}
		
		ammu[0]++;
		sum += COINS[0];

		int pos = 0;
		while (sum > TARGET)
		{
			sum -= ammu[pos] * COINS[pos];
			ammu[pos] = 0;
			pos++;

			if (pos >= COINS.Length)
			{
				rrr.Dump();
				return;
			}
			
			ammu[pos]++;
			sum += COINS[pos];

		}
	}
}