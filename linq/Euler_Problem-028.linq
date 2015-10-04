<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

/*
Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:

~~~
21 22 23 24 25
20  7  8  9 10
19  6  1  2 11
18  5  4  3 12
17 16 15 14 13
~~~

It can be verified that the sum of the numbers on the diagonals is 101.

What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?
*/

const int LEN = 1001;

void Main()
{
	int number = LEN * LEN;
	int side = LEN - 1;
	
	int sum = 1;

	while (side > 0)
	{
		for (int i = 0; i < 4; i++)
		{
			sum += number;
			number -= side;
		}
		
		side -= 2;
	}
	
	sum.Dump();
}