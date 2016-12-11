<Query Kind="Program">
  <Namespace>System.Net</Namespace>
  <Namespace>System.Windows</Namespace>
</Query>

/*
By replacing each of the letters in the word CARE with 1, 2, 9, and 6 respectively, 
we form a square number: 1296 = 36^2. What is remarkable is that, 
by using the same digital substitutions, the anagram, RACE, 
also forms a square number: 9216 = 96^2. 
We shall call CARE (and RACE) a square anagram word pair and specify further 
that leading zeroes are not permitted, 
neither may a different letter have the same digital value as another letter.

Using [words.txt](https://projecteuler.net/project/resources/p098_words.txt), 
a 16K text file containing nearly two-thousand common English words, 
find all the square anagram word pairs 
(a palindromic word is NOT considered to be an anagram of itself).

What is the largest square number formed by any member of such a pair?

NOTE: All anagrams formed must be contained in the given text file.
*/

// 18769 (BOARD <> BROAD)

const string URL = @"http://projecteuler.net/project/resources/p098_words.txt";
readonly string FILE = Path.Combine(Path.GetTempPath(), "cache_98.txt");

List<Tuple<string, string, long, long>> result = new List<Tuple<string, string, long, long>>();

void Main()
{
	if (!File.Exists(FILE)) File.WriteAllText(FILE, new WebClient().DownloadString(URL));

	var data0 = File.ReadAllText(FILE).Split(',').Select(p => p.Trim('"')).ToList();
	
	//GetPalindromicHash("YOUTH").Dump();
	
	//Evaluate("CARE", "RACE");
	
	Run(data0);
	
	result.OrderByDescending(p => Math.Max(p.Item3, p.Item4)).Dump();
}

void Run(List<string> data0)
{
	var data = data0.Select(p => Tuple.Create(p, GetPalindromicHash(p))).ToArray();

	for (int i1 = 0; i1 < data.Length - 1; i1++)
	{
		for (int i2 = i1 + 1; i2 < data.Length; i2++)
		{
			if (data[i1].Item2 == data[i2].Item2)
			{
				Evaluate(data[i1].Item1, data[i2].Item1);
			}
		}
	}
}

void Evaluate(string a, string b)
{
	long min = IntPow(10, a.Length-1);
	long max = IntPow(10, a.Length) - 1;

	long start = isqrt(min-1)+1;
	long end = isqrt(max);
	
	for (long currsqn = start; currsqn <= end; currsqn++)
	{
		if (currsqn*currsqn < min) throw new Exception("MIN");
		if (currsqn*currsqn > max) throw new Exception("MAX");
		
		TestSAWP(a, b, currsqn*currsqn);
	}
}

void TestSAWP(string a, string b, long num)
{
	int[] mapC = new int[10];
	int[] mapN = new int[26];
	for (int i = 0; i < 10; i++) mapC[i] = 999;
	for (int i = 0; i < 26; i++) mapN[i] = 999;

	// FILL MAP
	for (int i = a.Length - 1; i >= 0 ; i--)
	{
		int chrn = a[i] - 'A';
		int n = (int)((num / IntPow(10, a.Length - i - 1)) % 10);
		
		if (mapN[chrn] == 999) 
			mapN[chrn] = n;
		else if (mapN[chrn] == n) 
			mapN[chrn] = n;
		else 
			return;

		if (mapC[n] == 999)
			mapC[n] = chrn;
		else if (mapC[n] == chrn)
			mapC[n] = chrn;
		else
			return;
	}

	// Calc [B]
	long vb = 0;
	for (int i = 0; i < b.Length; i++)
	{
		int chrn = b[i] - 'A';

		if (mapN[chrn] == 999) return;
		if (mapN[chrn] == 0 && i == 0) return;
		
		vb *= 10;
		vb += mapN[chrn];
	}

	if (vb >= num && isISqrt(vb))
	{
		result.Add(Tuple.Create(a, b, num, vb));
	}
}

long GetPalindromicHash(string x)
{
	long v = 0;
	foreach (var chr in x)
	{
		// works max for 5 occurences of same char in string
		// otherwise we would need a bigger Base for our exponentiation
		// but that would be too big for our 64bit numbers
		// 25th_root(2^63) = 2^(63/25) = 5.735
		v += IntPow(5, chr-'A');
	}
	return v;
}

long IntPow(long x, long pow)
{
	long ret = 1;
	while (pow != 0)
	{
		if ((pow & 1) == 1)
			ret *= x;
		x *= x;
		pow >>= 1;
	}
	return ret;
}

// @see Euler-086
public bool isISqrt(long x)
{
	if (x % 16 > 9) return false;
	if (x % 64 > 57) return false;
	if (x % 16 == 2) return false;
	if (x % 16 == 3) return false;
	if (x % 16 == 5) return false;
	if (x % 16 == 6) return false;
	if (x % 16 == 7) return false;
	if (x % 16 == 8) return false;
	if (x % 10 == 2) return false;
	if (x % 10 == 3) return false;
	if (x % 10 == 7) return false;
	if (x % 3 == 2) return false;

	return IntPow(isqrt(x), 2) == x;
}

// @see Euler-086
long isqrt(long n)
{
	long pxk = 0;
	long xk = n;
	for (; ;)
	{
		long nxk = (xk + n / xk) / 2;

		if (nxk == xk) return xk;
		if (nxk == pxk) return xk;

		pxk = xk;
		xk = nxk;
	}
}

void OutData(List<string> data0)
{
	StringBuilder b = new StringBuilder();
	for (int i = 0; i < data0.Count; i++)
	{
		if (i > 0 && i % 9 == 0) b.AppendLine();
		b.Append(string.Format("{0,-16}", data0[i]));
	}
	File.WriteAllText(@"C:\asdxas.txt", b.ToString());
}

/*
With this problem I tried a little bit differen methology with designing the problem.
Programs with massive (16k) input are always kind of ugly in befunge because 
all of the data must be in the program code, so I thought I can at least try a little bit around.

In this program I seperated the code, as much as I could, into independent subprograms.
All subprograms can use the [1,0]-[9,0] fields as temporary values, get their input 
from the stack and write their output also to the stack.
Then I combined them together to build the whole program.

All the subprograms are in my [BefungePrograms git repo](https://gogs.mikescher.com/gitmirror/BefungePrograms)

This resulted in more readable code and (hopefully) snippets that I can reuse in other programs.
But the code doesn't compress as good (which nobody cares about in this problem, cause of the giant input size)
and I'm sure I could optimize it a lot by using more global state and shared variables etc.

I think for my next programs I will continue as I did before and sometimes use independent code snippets
(for example for the integer-squareroot function) but for the big main program I will write it all together.

The program works like so:

1. First we calculate a "palindromic hash value" for each input word, this is a hash algorithm that 
   has no collisions as long as there are max five repeated letters in a word and has the same value for 
   palindroms.
   Practically it is a 26-digit number in base-5 where each digit denotes the amount a specific letter occurs in our word.
   We can not use a larger number than 5 for our base because then we would overflow our 64bit numbers.
   
2. Next we go through our palindromic list and search for palindroms (words with the same hash)
   With some clever sorting tricks we could do this in `log2(n)`, but I will leave this as an 
   exercise for ther reader and and implement in naively in `n^2`

3. For each word we iterate through all the squares with the correct digit count.
   This means we start with `j`, where `j = 10^(len - 1)` and wnd with `k`, where `k = (10^len) - 1`
   
4. Now (for each square) we can generate the numeric value for word B with word A + square as our map.
   When we generate our char->digit map (as an 26 element array) we also generate a digit->char map 
   to test if any digit is mapped to multiple different characters (a failure criteria)
   
5. Now we have square A and (possible) square B, with our optimized is-integer-squareroot function from problem 086 
   we test if B is a square number. And if this is the case (and B is bigger than our current candidate) we set B
   as our current result candidate
   
6. After we have done this for all pairs we can return (= print out) our current best candidate.


Used sub programs:
 - fixed_base_pow.b93
 - read_single_word.b93
 - get_palindromic_hash.b93
 - integer-squareroot-2.b93
 - is-squarenumber.b93
 - length_single_word.b93

*/