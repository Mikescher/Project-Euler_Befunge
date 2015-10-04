<Query Kind="Program" />

void Main()
{
	Enumerable
		.Range(1, 1000)
		.Select(p => new {number=p, calc=digitAt(p), real=realDigitAt(p)})
		.All(p => p.calc == p.real)
		.Dump();
		
	new List<int>{1, 10, 100, 1000, 10000, 100000, 1000000}
		.Select(realDigitAt)
		.Aggregate((a,b) => a*b)
		.Dump();
		
	Enumerable
		.Range(1, 1000)
		.Select(p => new {number=p, calc=digitAt(p), real=realDigitAt(p)})
		.Dump();
}

public int digitAt(int pos)
{

	int digitcount = 1;
	int digitvalue = 1;
	while(pos > digitvalue * 9 * digitcount)
	{
		pos -= digitvalue * 9 * digitcount;
		digitcount++;
		digitvalue *= 10;
	}
	
	int value = digitvalue + (pos - 1)/digitcount;
	int digit = digitcount - (pos - 1)%digitcount - 1;
	
	return getInternalDigit(value, digit);
}

public int getInternalDigit(int value, int digit)
{
	for(int i = 0; i < digit; i++) value /= 10;
	
	return value % 10;
}

public int realDigitAt(int pos)
{
	return String.Join("", Enumerable.Range(1, pos).Select(p => p.ToString())).ToCharArray().Take(pos).Last() - '0';
}