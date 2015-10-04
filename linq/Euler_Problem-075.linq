<Query Kind="Program" />

/*
It turns out that 12 cm is the smallest length of wire
that can be bent to form an integer sided right angle triangle in exactly one way,
but there are many more examples.

~~~
12 cm: (3,4,5)
24 cm: (6,8,10)
30 cm: (5,12,13)
36 cm: (9,12,15)
40 cm: (8,15,17)
48 cm: (12,16,20)
~~~

In contrast, some lengths of wire, like 20 cm,
cannot be bent to form an integer sided right angle triangle,
and other lengths allow more than one solution to be found;
for example, using 120 cm it is possible to form exactly three different integer sided right angle triangles.

~~~
120 cm: (30,40,50), (20,48,52), (24,45,51)
~~~

Given that L is the length of the wire, 
for how many values of `L <= 1,500,000` can exactly one integer sided right angle triangle be formed?
*/

int LIMIT = 3000;//*/1500000;

// http://en.wikipedia.org/wiki/Pythagorean_triple#Generating_a_triple
void Main()
{
	Solve().Dump("Solve");
}

int Solve()
{
	int[] cache = new int[LIMIT + 1];
	int result = 0;
	
	for (int n = 1; 4*n*n + 6*n + 2 <= LIMIT; n++)
	{
		for (int m = n+1; 2*m*m + 2*m*n <= LIMIT; m++)
		{
			int a = m*m - n*n;
			int b = 2*m*n;
			int c = m*m + n*n;
			
			if (a > b) {int t = a; a = b ; b = t;};
			
			int sum = a + b + c;
			
			for (int k = 1; sum*k <= LIMIT; k++)
			{
				int hash = k*((a * 7 + b) * 5 + c);
				
				if (cache[sum*k] == 0)
				{
					cache[sum*k] = hash;
					result++;
				}
				else if (cache[sum*k] == hash)
				{
					//cache[sum*k] = hash;
				}
				else if (cache[sum*k] > 0)
				{
					cache[sum*k] = -1;
					result--;
				}
			}
		}
	}

	return result;
}