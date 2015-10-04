<Query Kind="Program" />

void Main()
{
	permutations(7).Select(IntArrToNum).First(IsPrime).Dump();
	
	permutations(4).Select(IntArrToNum).Where(IsPrime).Dump();
	permutations(3).Select(IntArrToStr).Dump();
	Enumerable.Range(2, 33).Where(IsPrime).Dump();
}

IEnumerable<int[]> permutations(int len)
{
	int i = 1;
	int j;
	int[] a = Enumerable.Range(0, len).Select(_p => _p+1).ToArray();
	int[] p = Enumerable.Repeat(0, len).ToArray();
	
	yield return a;
			
	while (i < a.Length)
	{
	
		if (p[i] < i) 
		{
			if (i%2 == 1) 
				j = p[i];
			else 
				j = 0;
				
			swap(ref a, j, i);
			yield return a;
			
			p[i]++;
			i = 1;
		} 
		else 
		{
			p[i] = 0;
			i++;
		}
	}
}

void swap(ref int[] a, int idx1, int idx2)
{
	var t = a[idx1];
	
	a[idx1] = a[idx2];
	a[idx2] = t;
}

string IntArrToStr(int[] a)
{
 	return a.Reverse().Select((p) => p + "").Aggregate((a1, a2) => a1+a2);
}

int IntArrToNum(int[] a)
{
	return a.Select((p, i) => p * Math.Pow(10, i)).Select(p => (int)p).Sum();
}
 
bool IsPrime(int candidate)
{
	if (candidate > 2 && (candidate % 2) == 0) return false;
	for (int i = 3; (i * i) <= candidate; i += 2)
	{
	    if ((candidate % i) == 0) return false;
	}
	
	return true;
}
