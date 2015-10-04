<Query Kind="Program" />

/*
In the game, Monopoly, the standard board is set up in the following way:

~~~
GO A1 CC1 A2 T1 R1 B1 CH1 B2 B3 JAIL
H2                               C1
T2                               U1
H1                               C2
CH3                              C3
R4                               R2
G3                               D1
CC3                              CC2
G2                               D2
G1                               D3
G2J  F3 U2 F2 F1 R3 E3 E2 CH2 E1 FP
~~~

A player starts on the GO square and adds the scores on two 6-sided dice to determine the number of squares they advance in a clockwise direction.
Without any further rules we would expect to visit each square with equal probability: `2.5%`.
However, landing on G2J (Go To Jail), CC (community chest), and CH (chance) changes this distribution.

In addition to G2J, and one card from each of CC and CH, that orders the player to go directly to jail,
if a player rolls three consecutive doubles, they do not advance the result of their 3rd roll.
Instead they proceed directly to jail.

At the beginning of the game, the CC and CH cards are shuffled.
When a player lands on CC or CH they take a card from the top of the respective pile and, after following the instructions, it is returned to the bottom of the pile.
There are sixteen cards in each pile, but for the purpose of this problem we are only concerned with cards that order a movement;
any instruction not concerned with movement will be ignored and the player will remain on the CC/CH square.

Community Chest (2/16 cards):
 - Advance to GO
 - Go to JAIL
Chance (10/16 cards):
 - Advance to GO
 - Go to JAIL
 - Go to C1
 - Go to E3
 - Go to H2
 - Go to R1
 - Go to next R (railway company)
 - Go to next R
 - Go to next U (utility company)
 - Go back 3 squares.

The heart of this problem concerns the likelihood of visiting a particular square. That is, the probability of finishing at that square after a roll.
For this reason it should be clear that, with the exception of G2J for which the probability of finishing on it is zero,
the CH squares will have the lowest probabilities, as `5/8` request a movement to another square,
and it is the final square that the player finishes at on each roll that we are interested in.
We shall make no distinction between "Just Visiting" and being sent to JAIL, and we shall also ignore the rule about requiring a double to "get out of jail",
assuming that they pay to get out on their next turn.

By starting at GO and numbering the squares sequentially from 00 to 39 we can concatenate these two-digit numbers to produce strings that correspond with sets of squares.

Statistically it can be shown that the three most popular squares, in order, are `JAIL (6.24%) = Square 10`, `E3 (3.18%) = Square 24`, and `GO (3.09%) = Square 00`.
So these three most popular squares can be listed with the six-digit modal string: 102400.

If, instead of using two 6-sided dice, two 4-sided dice are used, find the six-digit modal string.
*/

Random R = new Random(2);

const int GO = 0;

const int G2J = 30;
const int JAIL = 10;

const int CC1 = 2;
const int CC2 = 17;
const int CC3 = 33;
readonly int[] CC = new[] { CC1, CC2, CC3 };

const int CH1 = 7;
const int CH2 = 22;
const int CH3 = 36;
readonly int[] CH = new[] { CH1, CH2, CH3 };

const int C1 = 11;
const int E3 = 24;
const int H2 = 39;
const int R1 = 5;
const int R2 = 15;
const int R3 = 25;
const int R4 = 35;
const int U1 = 12;
const int U2 = 28;

const int RUNS = 1;
const int ROLLS = 2000000;


const int DICE_SIDES = 4;

void Main()
{
	GetMultiDistribution(RUNS, ROLLS)
		.Select((p, i) => new {Field=i, HitCount=p, Perc=Math.Round((p*100.0) / (RUNS*ROLLS), 3)})
		.OrderByDescending(p => p.HitCount)
		.Take(8)
		//.Dump()
		.Take(3)
		.Select(p => string.Format("{0:00}", p.Field))
		.Aggregate((a,b) => a+b)
		.Dump();

	Optimized(ROLLS)
		.Select((p, i) => new { Field = i, HitCount = p })
		.OrderByDescending(p => p.HitCount)
		.Take(8)
		.Dump()
		.Take(3)
		.Select(p => string.Format("{0:00}", p.Field))
		.Aggregate((a, b) => a + b)
		.Dump();
}

int[] GetMultiDistribution(int runs, int rolls)
{
	int[] distro = new int[40];

	for (int i = 0; i < runs; i++)
	{
		int[] result = GetSingleDistribution(rolls);
		for (int j = 0; j < 40; j++) distro[j] += result[j];
	}

	return distro;
}

int[] GetSingleDistribution(int rolls)
{
	int[] distro = new int[40];

	int field = 0;

	int doubc = 0;
	bool doub = false;
	for (int i = 0; i < rolls; i++)
	{
		field = (field + GetDice(out doub)) % 40;

		//*
		if (doub)
		{
			doubc++;
			if (doubc == 3)
			{
				doubc = 0;
				field = JAIL;
			}
		}
		else doubc = 0;
		/*/
		if (R.Next(64) == 0) field = JAIL;
		//*/
		if (field == G2J) field = JAIL;

		if (CC.Contains(field))
		{
			int rand16 = GetCC();

			if (rand16 == 0) field = GO;
			else if (rand16 == 1) field = JAIL;
		}

		if (CH.Contains(field))
		{
			int rand16 = GetCH();

			if (rand16 == 0) field = GO;
			else if (rand16 == 1) field = JAIL;
			else if (rand16 == 2) field = C1;
			else if (rand16 == 3) field = E3;
			else if (rand16 == 4) field = H2;
			else if (rand16 == 5) field = R1;
			else if (field == CH1 && (rand16 == 6 || rand16 == 7)) field = R2;
			else if (field == CH2 && (rand16 == 6 || rand16 == 7)) field = R3;
			else if (field == CH3 && (rand16 == 6 || rand16 == 7)) field = R1;
			else if (field == CH1 && rand16 == 8) field = U1;
			else if (field == CH2 && rand16 == 8) field = U2;
			else if (field == CH3 && rand16 == 8) field = U1;
			else if (rand16 == 9) field -= 3;
		}

		distro[field]++;
	}

	return distro;
}

int GetDice(out bool doub)
{
	int a = R.Next(DICE_SIDES) + 1;
	int b = R.Next(DICE_SIDES) + 1;

	doub = a == b;
	return a + b;
}

int GetCH()
{
	return R.Next(16);
}

int GetCC()
{
	return R.Next(16);
}

string Optimized(int rolls)
{
	int[] distro = new int[40];

	int field = 0;

	for (int i = 0; i < rolls; i++)
	{
		distro[field]++;
		field = (field + R.Next(4) + R.Next(4) + 2) % 40;

		if (R.Next(64) == 0) field = JAIL;
		if (field == G2J) field = JAIL;

		if (CC.Contains(field))
		{
			int rand16 = R.Next(16);

			if (rand16 == 0) field = GO;
			else if (rand16 == 1) field = JAIL;
		}

		if (CH.Contains(field))
		{
			int rand16 = R.Next(16);

			if (rand16 == 0) field = GO;
			else if (rand16 == 1) field = JAIL;
			else if (rand16 == 2) field = C1;
			else if (rand16 == 3) field = E3;
			else if (rand16 == 4) field = H2;
			else if (rand16 == 5) field = R1;
			else if (field == CH1 && (rand16 == 6 || rand16 == 7)) field = R2;
			else if (field == CH2 && (rand16 == 6 || rand16 == 7)) field = R3;
			else if (field == CH3 && (rand16 == 6 || rand16 == 7)) field = R1;
			else if (field == CH1 && rand16 == 8) field = U1;
			else if (field == CH2 && rand16 == 8) field = U2;
			else if (field == CH3 && rand16 == 8) field = U1;
			else if (rand16 == 9) field -= 3;
		}

	}

	return distro
		.Select((p, i) => new { Field = i, HitCount = p })
		.OrderByDescending(p => p.HitCount)
		.Take(3)
		.Select(p => string.Format("{0:00}", p.Field))
		.Aggregate((a, b) => a + b);
}