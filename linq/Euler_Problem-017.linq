<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

/*
If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?

*NOTE: Do not count spaces or hyphens. 
For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. 
The use of "and" when writing out numbers is in compliance with British usage.*
*/

readonly int[] TAB_SINGLE = new int[] { 0, 3, 3, 5, 4, 4, 3, 5, 5, 4, 3, 6, 6, 8, 8, 7, 7, 9, 8, 8, 6 };
readonly int[] TAB_DOUBLE = new int[] { 0, 3, 6, 6, 5, 5, 5, 7, 6, 6};

void Main()
{
	Enumerable.Range(1, 1000).Select(Len).Sum().Dump();
}

int Len(int n)
{
	if (n <= 20) return TAB_SINGLE[n];
	else if (n < 100) return TAB_DOUBLE[n / 10] + Len(n % 10);
	else if (n < 1000 && n % 100 == 0) return TAB_SINGLE[n / 100] + 7;
	else if (n < 1000) return TAB_SINGLE[n / 100] + 7 + 3 + Len(n % 100);
	else return 3 + 8;

}