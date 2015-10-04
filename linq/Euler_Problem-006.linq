<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

/*
The sum of the squares of the first ten natural numbers is,
`1^2 + 2^2 + ... + 10^2 = 385`

The square of the sum of the first ten natural numbers is,
`(1 + 2 + ... + 10)^2 = 552 = 3025`

Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is `3025 - 385 = 2640`.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
*/

void Main()
{
	var pos = BRange(1,100).Aggregate((a,b) => a+b) * BRange(1,100).Aggregate((a,b) => a+b);
	var sop = BRange(1,100).Select(p => p*p).Aggregate((a,b) => a+b);

	(pos - sop).Dump();
}

IEnumerable<BigInteger> BRange(BigInteger start, BigInteger count)
{
	for (long i = 0; i < count; i++) yield return start + i;
}