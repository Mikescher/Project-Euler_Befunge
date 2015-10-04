<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

/*
`n!` means `n x (n - 1) x ... x 3 x 2 x 1`

For example, `10! = 10 x 9 x ... x 3 x 2 x 1 = 3628800`,
and the sum of the digits in the number `10!` is `3 + 6 + 2 + 8 + 8 + 0 + 0 = 27`.

Find the sum of the digits in the number `100!`
*/

void Main()
{
	Enumerable
		.Range(1, 100)
		.Select(p => new BigInteger(p))
		.Aggregate((a,b) => a*b)
		.ToString()
		.ToCharArray()
		.Select(p => p - '0')
		.Sum()
		.Dump();
		
}