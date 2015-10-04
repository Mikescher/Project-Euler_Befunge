<Query Kind="Program" />

public struct Tpl {public int A,B,C;}

void Main()
{
	Enumerable
		.Range(1, 500)
		.Select(p => 2*p)
		.Select(p => new {number=p, count=0, all=Tuples(p)})
		.Select(p => new {number=p.number, count=p.all.Count(), all=p.all.ToList()})
		.Where(p => p.count > 0)
		.OrderByDescending(p => p.count)
		.Dump();
}


public IEnumerable<Tpl> Tuples(int p)
{
	// [ p = a+b+c ]

	// a = a
	// b = p*(p-2a) / 2*(p-a)
	// c = p-(b+a)
	
	return Enumerable  
		.Range(2, p/3)
		.Where(a => p*(p-2*a) % (2*(p-a)) == 0)
		.Select(a=> new Tpl{A=a, B=(p*(p-2*a) / (2*(p-a))), C=p-a-(p*(p-2*a) / (2*(p-a)))})
		.Where(x => x.A < x.B);
}