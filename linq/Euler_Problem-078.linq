<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

/*
Let p(n) represent the number of different ways in which n coins can be separated into piles.
For example, five coins can be separated into piles in exactly seven different ways, so p(5)=7.

~~~
OOOOO
OOOO   O
OOO    OO
OOO    O   O
OO     OO  O
OO     O   O  O
O      O   O  O  O
~~~

Find the least value of n for which p(n) is divisible by one million.
*/

const int DIV = 100*9*9;//1000000;

void Main()
{
	//PentagonalSequence().Dump();
	//GetPDict().Dump();
	Optimized().Dump();
	
	//MathBlog().Dump();
}

int Optimized()
{
	int[] cache = new int[60000];

	cache[0] = 1;

	for (int n = 1;; n++)
	{
		int value = 0;
		for (int m = 0;; m++)
		{
			int pen = (3 * (+m/2 + 1) * (+m/2 + 1) + (+m/2 + 1) * ((m%2)*2 - 1)) / 2;
			
			if (n < pen) break;
			
			value -= cache[n - pen] * (((m/2)%2)*2 - 1);
		}
		
		cache[n] = (value % DIV);
		
		if (cache[n] == 0) 
		{
			return n;
		}
	}
}

int GetPDict()
{
	var result = new Dictionary<int, int>();

	result[0] = 1;

	for (int n = 1;; n++)
	{
		int value = 0;
		int sign = 0;
		foreach (var pen in PentagonalSequence())
		{
			int next = n - pen;
			if (next < 0) break;
			if ((sign/2)%2 == 0) value += result[next];
			else                 value -= result[next];
			sign++;
		}
		result[n] = (value % DIV);
		
		if (value % DIV == 0) return n;
	}
}

IEnumerable<int> PentagonalSequence()
{
	for (int m = 0;; m++)
	{
		if (m %2 == 0)
			yield return (3 * (+m/2 + 1) * (+m/2 + 1) - (+m/2 + 1)) / 2;
		else
			yield return (3 * (-m/2 - 1) * (-m/2 - 1) - (-m/2 - 1)) / 2;
	}
}

int MathBlog()
{
	List<int> p = new List<int>();
	p.Add(1);
				
	int n = 1;            
	while(true){
		int i = 0;
		int penta = 1;
		p.Add(0);
	
		while (penta <= n){                    
			int sign = (i % 4 > 1) ? -1 : 1;
			p[n] += sign * p[n - penta];
			p[n] %= 1000000;
			i++;
					
			int j = (i % 2 == 0) ? i / 2 + 1 : -(i / 2 + 1);
			penta = j * (3 * j - 1) / 2;
		} 
					
		if (p[n] == 0) break;
		n++;
	}
	
	return n;
}

/*

Again the algorithm is from [MathBlog](http://www.mathblog.dk/project-euler-78-coin-piles/).
I can't really say that I understand the algorithm fully (and the MathBlog guy says he neither).

But for the best explanation you better read his article.

*/

/*
-- Mathblog --

To me this was a rather easy problem to solve, and now you might ask why since it doesn’t seem straight forward. The answer to that lies in the fact that I was reading the problem description a good while ago since as mentioned earlier it is the first problem which has been solved by less than 5000 people. A day or so later I listened to the second episode of Strongly Connect Components where Bruce Reznick mentioned that his prime research is on integer partitions and he mentions the  exact example given in the problem description.

So before starting on the problem I had a very good idea where I should look for a possible solution. A quick search on Google turned up the Wikipedia page on integer partitions where the section on generating functions seems to provide the methodology for solving this problem.
Generating functions

The generating function for p(n) is given as

\displaystyle \sum_{n=0}^\infty p(n)x^n = \prod_{k=1}^\infty \frac{1}{1-x^k}

Which according to wikipedia can be rewritten as

p(n) = p(n – 1)  + p(k – 2) – p(k – 5) – p(k – 7) + p(k – 12) + p(k – 15) – p(k – 22)…

where p(0) = 1 and p(n)  = 0 for n < 0.

The sequence to use are the generalized pentagonal numbers which are given on the 
form f(k) = k(3k-1)/2 for both negative and positive k.  
This can be written as a positive sequence of integers m=1,2,3,…. such that

\displaystyle k = \left\{\begin{array}{ll} m/2 1 & \text{if } k \equiv 0 \text{ mod } 2,\\ -m/2-1 & \text{else }\end{array}\right.

where the division is an integer division.

The signs of the function follows the pattern +,+,-,-,+,+,-,-…. so that is pretty easy to replicate.

So if we know all previous integer divisions we can also calculate the next one.

I don’t say I completely understand the underlying theory of the integer partition formula, 
so I wont go into details about it. But you can start at wikipedia for info.
Avoiding BigInteger

My first implementation of the code for the generating function included the use of the BigInteger class. 
However that becomes cumbersome. So we want to eliminate that. 
However, since we are not interested in finding the actual number of partitions but just the first one 
divisible by 1.000.000 and since we are summing up things we only need to save the last 7 digits.  
So we just take modulo of 1.000.000 before we store the result.
C# implementation of the code

Since we now have all we need in order to implement the code, I don’t think I need to blabber on. Here is the code

~~~
List<int> p = new List<int>();
p.Add(1);
             
int n = 1;            
while(true){
    int i = 0;
    int penta = 1;
    p.Add(0);
 
    while (penta <= n){                    
        int sign = (i % 4 > 1) ? -1 : 1;
        p[n] += sign * p[n - penta];
        p[n] %= 1000000;
        i++;
                  
        int j = (i % 2 == 0) ? i / 2 + 1 : -(i / 2 + 1);
        penta = j * (3 * j - 1) / 2;
    } 
                 
    if (p[n] == 0) break;
    n++;
}
Wrapping up

Now that we have the code lets execute it and get the solution
~~~
	
n = 55374 is the least value for which p(n) is divisible by 1.000.000
Solution took 299,6262 ms

I can execute the code in just under 300ms, which I guess is pretty okay for this problem. 
However if you have more efficient methods I would be most interested in hearing about it.
*/