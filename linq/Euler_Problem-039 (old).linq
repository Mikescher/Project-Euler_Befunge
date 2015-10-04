<Query Kind="Program" />

public struct Tpl {public int A,B,C;}

void Main()
{
	T3_Combinations()
		.Where(p => p.A*p.A + p.B*p.B == p.C*p.C)
		
		.GroupBy(p=>p.A+p.B+p.C)
		.Select(p => new {number=p.First().A+p.First().B+p.First().C, count = p.Count(), all=p.ToList()})
		.OrderByDescending(p => p.count)
		
		.Dump();
}

public IEnumerable<Tpl> T3_Combinations()
{
	for(int a = 1; a <= 998; a++)
	{
		for(int b = a+1; b <= (999-a); b++)
		{
			for(int c = 1; c <= (1000-b-a); c++)
			{
				yield return new Tpl(){A=a, B=b, C=c};
			}
		}
	}
}