<Query Kind="Program" />

/*
It is easily proved that no equilateral triangle exists with integral length sides and integral area. 
However, the almost equilateral triangle 5-5-6 has an area of 12 square units.

We shall define an almost equilateral triangle to be a triangle 
for which two sides are equal and the third differs by no more than one unit.

Find the sum of the perimeters of all almost equilateral triangles with integral side lengths 
and area and whose perimeters do not exceed one billion (1,000,000,000).
*/

// Pells formula

// @see http://www.mathblog.dk/project-euler-94-almost-equilateral-triangles/

// = 518408346

void Main()
{
	Stopwatch clock = Stopwatch.StartNew();
	var result = Pellforce();
	"".Dump();
    $" = {result} ( == 518408346 )".Dump();
	"".Dump();
	$"Solution took {clock.Elapsed.TotalMilliseconds} ms".Dump();
	
	if (result != 518408346) "ERROR".Dump("ERROR");
}

bool D = true;

public long Pellforce()
{
	long x = 2;
	long y = 1;
	
	long limit = 1000*1000*1000;
	long result = 0;

	while (2 * x <= limit)
	{
		// b = a+1
		if (x > 2 && (2 * x) % 3 == 1 && (y * (x - 2)) % 3 == 0)
		{
			result += 2 * x - 2;

			if (D) $"({(2 * x - 1) / 3,9}, {(2 * x - 1) / 3,9}, {(2 * x - 1) / 3 - 1,9}),    =>   perimeter = {2 * x - 2,9}, area = {(y * (x - 2))/3,16}".Dump();
		}

		//b = a-1
		if ((2 * x) % 3 == 2 && (y * (x + 2)) % 3 == 0)
		{
			result += 2 * x + 2;
			
			if (D) $"({(2 * x + 1)/3,9}, {(2 * x + 1)/3,9}, {(2 * x + 1)/3 + 1,9}),    =>   perimeter = {2*x + 2,9}, area = {(y * (x + 2))/3,16}".Dump();
		}

		long nextx = 2 * x + y * 3;
		long nexty = y * 2 + x;

		x = nextx;
		y = nexty;
	}

	return result;

}