<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

/*
`2^15 = 32768` and the sum of its digits is `3 + 2 + 7 + 6 + 8 = 26`.

What is the sum of the digits of the number `2^1000`?
*/

void Main()
{
	BigInteger.Pow(2, 1000).ToString().ToCharArray().Select(p => p - '0').Sum().Dump();
}