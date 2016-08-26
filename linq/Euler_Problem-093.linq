<Query Kind="Program">
  <Namespace>System.Drawing</Namespace>
</Query>

/*
By using each of the digits from the set, `{1, 2, 3, 4}`, exactly once, 
and making use of the four arithmetic operations (`+`, `−`, `*`, `/`) and brackets/parentheses, 
it is possible to form different positive integer targets.

For example,

~~~
8  =  (4   *  (1   +   3)) /   2
14 =   4   *  (3   +   1   /   2)
19 =   4   *  (2   +   3)  −   1
36 =   3   *   4   *  (2   +   1)
~~~

Note that concatenations of the digits, like `12 + 34`, are not allowed.

Using the set, {1, 2, 3, 4}, it is possible to obtain thirty-one different target numbers 
of which 36 is the maximum, and each of the numbers 1 to 28 can be obtained 
before encountering the first non-expressible number.

Find the set of four distinct digits, `a < b < c < d`, for which the 
longest set of consecutive positive integers, 1 to n, can be obtained, 
giving your answer as a string: abcd.
*/

// {1, 2, 5, 8} --> max:=51

bool[,,,] sets = new bool[10, 10, 10, 10];

bool DOUT = false;

void Main()
{
	Util.AutoScrollResults = true;

	InitSet();

	if (DOUT) DumpSet(false);

	//DumpSetAsImage();

	for (int currentNum = 1; ; currentNum++)
	{
		FilterSet(currentNum);
		if (DOUT) DumpSet(false);
		
		//Util.ClearResults();DumpSetAsImage();Thread.Sleep(100);
		
		if (TryGetWinner()) return;
	}
}

private void InitSet()
{
	for (int s1 = 1;      s1 <  7; s1++)
	for (int s2 = s1 + 1; s2 <  8; s2++)
	for (int s3 = s2 + 1; s3 <  9; s3++)
	for (int s4 = s3 + 1; s4 < 10; s4++)
	{
		sets[s1, s2, s3, s4] = true;
	}
}

private void DumpSetAsImage()
{
	Bitmap b = new Bitmap(100, 100);
	using (var g = Graphics.FromImage(b))
	{
		g.Clear(Color.Beige);
	}
	
	for (int s1 = 0; s1 < 10; s1++)
	for (int s2 = 0; s2 < 10; s2++)
	for (int s3 = 0; s3 < 10; s3++)
	for (int s4 = 0; s4 < 10; s4++)
	{
		if (sets[s1, s2, s3, s4]) b.SetPixel(s1*10+s2, s4*10+s3, Color.Black);
	}
	
	b.Dump();
}

private void DumpSet(bool imd)
{
	int i = 0;

	for (int s1 = 0;      s1 <  7; s1++)
	for (int s2 = s1 + 1; s2 <  8; s2++)
	for (int s3 = s2 + 1; s3 <  9; s3++)
	for (int s4 = s3 + 1; s4 < 10; s4++)
	{
		if (sets[s1, s2, s3, s4]) 
		{
			if (imd) $"{s1}{s2}{s3}{s4}".Dump();
			i++;
		}
	}

	$" count = {i}".Dump();
}

private bool TryGetWinner()
{
	int result = -1;
	
	for (int s1 = 0;      s1 <  7; s1++)
	for (int s2 = s1 + 1; s2 <  8; s2++)
	for (int s3 = s2 + 1; s3 <  9; s3++)
	for (int s4 = s3 + 1; s4 < 10; s4++)
	{
		if (sets[s1, s2, s3, s4]) 
		{
			if (result != -1) return false;
			
			result = ((s1 * 10 + s2) * 10 + s3) * 10 + s4;
		}
	}
	
	result.Dump("RESULT"); // 1258
	
	return true;
}

private void FilterSet(int target)
{
	for (int s1 = 0;      s1 <  7; s1++)
	for (int s2 = s1 + 1; s2 <  8; s2++)
	for (int s3 = s2 + 1; s3 <  9; s3++)
	for (int s4 = s3 + 1; s4 < 10; s4++)
	{
		if (sets[s1, s2, s3, s4]) 
		{
			string path;
			bool test = Test(s1, s2, s3, s4, target, out path);
			
			sets[s1, s2, s3, s4] = test;

			if (DOUT) if (target > 28 && test) $"({s1}{s2}{s3}{s4}) => {path} = {target}".Dump();
			//if (s1==1&&s2==2&&s3==5&&s4==8) $"{path}={target}".Dump()
		}
	}
}

const int SCALE = 2520; // divisible by 1..10

private bool Test(int s1, int s2, int s3, int s4, int target, out string dbg)
{
	string t1 = s1.ToString();
	string t2 = s2.ToString();
	string t3 = s3.ToString();
	string t4 = s4.ToString();

	s1 *= SCALE;
	s2 *= SCALE;
	s3 *= SCALE;
	s4 *= SCALE;

	if (Test(s1 + s2, s3, s4, target, out dbg, "("+t1+"+"+t2+")", t3, t4)) { return true; }
	if (Test(s1 + s3, s2, s4, target, out dbg, "("+t1+"+"+t3+")", t2, t4)) { return true; }
	if (Test(s1 + s4, s2, s3, target, out dbg, "("+t1+"+"+t4+")", t2, t3)) { return true; }
	if (Test(s4, s2 + s1, s3, target, out dbg, t4, "("+t2+"+"+t1+")", t3)) { return true; }
	if (Test(s1, s2 + s3, s4, target, out dbg, t1, "("+t2+"+"+t3+")", t4)) { return true; }
	if (Test(s1, s2 + s4, s3, target, out dbg, t1, "("+t2+"+"+t4+")", t3)) { return true; }
	if (Test(s4, s2, s3 + s1, target, out dbg, t4, t2, "("+t3+"+"+t1+")")) { return true; }
	if (Test(s1, s4, s3 + s2, target, out dbg, t1, t4, "("+t3+"+"+t2+")")) { return true; }
	if (Test(s1, s2, s3 + s4, target, out dbg, t1, t2, "("+t3+"+"+t4+")")) { return true; }
	if (Test(s3, s2, s4 + s1, target, out dbg, t3, t2, "("+t4+"+"+t1+")")) { return true; }
	if (Test(s1, s3, s4 + s2, target, out dbg, t1, t3, "("+t4+"+"+t2+")")) { return true; }
	if (Test(s1, s2, s4 + s3, target, out dbg, t1, t2, "("+t4+"+"+t3+")")) { return true; }
	
												  
	if (Test(s1 - s2, s3, s4, target, out dbg, "("+t1+"-"+t2+")", t3, t4)) { return true; }
	if (Test(s1 - s3, s2, s4, target, out dbg, "("+t1+"-"+t3+")", t2, t4)) { return true; }
	if (Test(s1 - s4, s2, s3, target, out dbg, "("+t1+"-"+t4+")", t2, t3)) { return true; }
	if (Test(s4, s2 - s1, s3, target, out dbg, t1, "("+t2+"-"+t1+")", t3)) { return true; }
	if (Test(s1, s2 - s3, s4, target, out dbg, t1, "("+t2+"-"+t3+")", t4)) { return true; }
	if (Test(s1, s2 - s4, s3, target, out dbg, t1, "("+t2+"-"+t4+")", t3)) { return true; }
	if (Test(s4, s2, s3 - s1, target, out dbg, t4, t2, "("+t3+"-"+t1+")")) { return true; }
	if (Test(s1, s4, s3 - s2, target, out dbg, t1, t4, "("+t3+"-"+t2+")")) { return true; }
	if (Test(s1, s2, s3 - s4, target, out dbg, t1, t2, "("+t3+"-"+t4+")")) { return true; }
	if (Test(s3, s2, s4 - s1, target, out dbg, t3, t2, "("+t4+"-"+t1+")")) { return true; }
	if (Test(s1, s3, s4 - s2, target, out dbg, t1, t3, "("+t4+"-"+t2+")")) { return true; }
	if (Test(s1, s2, s4 - s3, target, out dbg, t1, t2, "("+t4+"-"+t3+")")) { return true; }
	
												  
	if (Test((s1 * s2)/SCALE, s3, s4, target, out dbg, "("+t1+"*"+t2+")", t3, t4)) { return true; }
	if (Test((s1 * s3)/SCALE, s2, s4, target, out dbg, "("+t1+"*"+t3+")", t2, t4)) { return true; }
	if (Test((s1 * s4)/SCALE, s2, s3, target, out dbg, "("+t1+"*"+t4+")", t2, t3)) { return true; }
	if (Test(s4, (s2 * s1)/SCALE, s3, target, out dbg, t1, "("+t2+"*"+t1+")", t3)) { return true; }
	if (Test(s1, (s2 * s3)/SCALE, s4, target, out dbg, t1, "("+t2+"*"+t3+")", t4)) { return true; }
	if (Test(s1, (s2 * s4)/SCALE, s3, target, out dbg, t1, "("+t2+"*"+t4+")", t3)) { return true; }
	if (Test(s4, s2, (s3 * s1)/SCALE, target, out dbg, t4, t2, "("+t3+"*"+t1+")")) { return true; }
	if (Test(s1, s4, (s3 * s2)/SCALE, target, out dbg, t1, t4, "("+t3+"*"+t2+")")) { return true; }
	if (Test(s1, s2, (s3 * s4)/SCALE, target, out dbg, t1, t2, "("+t3+"*"+t4+")")) { return true; }
	if (Test(s3, s2, (s4 * s1)/SCALE, target, out dbg, t3, t2, "("+t4+"*"+t1+")")) { return true; }
	if (Test(s1, s3, (s4 * s2)/SCALE, target, out dbg, t1, t3, "("+t4+"*"+t2+")")) { return true; }
	if (Test(s1, s2, (s4 * s3)/SCALE, target, out dbg, t1, t2, "("+t4+"*"+t3+")")) { return true; }


	if (s2 != 0 && Test(SCALE*s1 / s2, s3, s4, target, out dbg, "("+t1+"/"+t2+")", t3, t4)) { return true; }
	if (s3 != 0 && Test(SCALE*s1 / s3, s2, s4, target, out dbg, "("+t1+"/"+t3+")", t2, t4)) { return true; }
	if (s4 != 0 && Test(SCALE*s1 / s4, s2, s3, target, out dbg, "("+t1+"/"+t4+")", t2, t3)) { return true; }
	if (s1 != 0 && Test(s4, SCALE*s2 / s1, s3, target, out dbg, t1, "("+t2+"/"+t1+")", t3)) { return true; }
	if (s3 != 0 && Test(s1, SCALE*s2 / s3, s4, target, out dbg, t1, "("+t2+"/"+t3+")", t4)) { return true; }
	if (s4 != 0 && Test(s1, SCALE*s2 / s4, s3, target, out dbg, t1, "("+t2+"/"+t4+")", t3)) { return true; }
	if (s1 != 0 && Test(s4, s2, SCALE*s3 / s1, target, out dbg, t4, t2, "("+t3+"/"+t1+")")) { return true; }
	if (s2 != 0 && Test(s1, s4, SCALE*s3 / s2, target, out dbg, t1, t4, "("+t3+"/"+t2+")")) { return true; }
	if (s4 != 0 && Test(s1, s2, SCALE*s3 / s4, target, out dbg, t1, t2, "("+t3+"/"+t4+")")) { return true; }
	if (s1 != 0 && Test(s3, s2, SCALE*s4 / s1, target, out dbg, t3, t2, "("+t4+"/"+t1+")")) { return true; }
	if (s2 != 0 && Test(s1, s3, SCALE*s4 / s2, target, out dbg, t1, t3, "("+t4+"/"+t2+")")) { return true; }
	if (s3 != 0 && Test(s1, s2, SCALE*s4 / s3, target, out dbg, t1, t2, "("+t4+"/"+t3+")")) { return true; }


	dbg = "_";
	return false;
}

private bool Test(int s1, int s2, int s3, int target, out string dbg, string t1, string t2, string t3)
{
	if (Test(s1 + s2, s3, target, out dbg, "("+t1+"+"+t2+")", t3)) { return true; }
	if (Test(s1 + s3, s2, target, out dbg, "("+t1+"+"+t3+")", t2)) { return true; }
	if (Test(s3, s2 + s1, target, out dbg, "("+t3+"+"+t2+")", t1)) { return true; }
	if (Test(s1, s2 + s3, target, out dbg, t1, "("+t2+"+"+t3+")")) { return true; }
	if (Test(s2, s3 + s1, target, out dbg, t2, "("+t3+"+"+t1+")")) { return true; }
	if (Test(s1, s3 + s2, target, out dbg, t1, "("+t3+"+"+t2+")")) { return true; }
											  
	if (Test(s1 - s2, s3, target, out dbg, "("+t1+"-"+t2+")", t3)) { return true; }
	if (Test(s1 - s3, s2, target, out dbg, "("+t1+"-"+t3+")", t2)) { return true; }
	if (Test(s3, s2 - s1, target, out dbg, "("+t3+"-"+t2+")", t1)) { return true; }
	if (Test(s1, s2 - s3, target, out dbg, t1, "("+t2+"-"+t3+")")) { return true; }
	if (Test(s2, s3 - s1, target, out dbg, t2, "("+t3+"-"+t1+")")) { return true; }
	if (Test(s1, s3 - s2, target, out dbg, t1, "("+t3+"-"+t2+")")) { return true; }
											  
	if (Test((s1 * s2)/SCALE, s3, target, out dbg, "("+t1+"*"+t2+")", t3)) { return true; }
	if (Test((s1 * s3)/SCALE, s2, target, out dbg, "("+t1+"*"+t3+")", t2)) { return true; }
	if (Test(s3, (s2 * s1)/SCALE, target, out dbg, "("+t3+"*"+t2+")", t1)) { return true; }
	if (Test(s1, (s2 * s3)/SCALE, target, out dbg, t1, "("+t2+"*"+t3+")")) { return true; }
	if (Test(s2, (s3 * s1)/SCALE, target, out dbg, t2, "("+t3+"*"+t1+")")) { return true; }
	if (Test(s1, (s3 * s2)/SCALE, target, out dbg, t1, "("+t3+"*"+t2+")")) { return true; }

	if (s2 != 0 && Test(SCALE*s1 / s2, s3, target, out dbg, t1+"/"+t2, t3)) { return true; }
	if (s3 != 0 && Test(SCALE*s1 / s3, s2, target, out dbg, t1+"/"+t3, t2)) { return true; }
	if (s1 != 0 && Test(s3, SCALE*s2 / s1, target, out dbg, t3+"/"+t2, t1)) { return true; }
	if (s3 != 0 && Test(s1, SCALE*s2 / s3, target, out dbg, t1, t2+"/"+t3)) { return true; }
	if (s1 != 0 && Test(s2, SCALE*s3 / s1, target, out dbg, t2, t3+"/"+t1)) { return true; }
	if (s2 != 0 && Test(s1, SCALE*s3 / s2, target, out dbg, t1, t3+"/"+t2)) { return true; }

	dbg = "_";
	return false;
}

private bool Test(int s1, int s2, int target, out string dbg, string t1, string t2)
{
	if (Test(s1 + s2, target, out dbg, t1+"+"+t2)) { return true; }
	//if (Test(s2 + s1, target, out dbg, t2+"+"+t1)) { return true; }
										  
	if (Test(s1 - s2, target, out dbg, t1+"-"+t2)) { return true; }
	if (Test(s2 - s1, target, out dbg, t2+"-"+t1)) { return true; }
										  
	if (Test((s1 * s2)/SCALE, target, out dbg, t1+"*"+t2)) { return true; }
	//if (Test((s2 * s1)/SCALE, target, out dbg, t2+"*"+t1)) { return true; }

	if (s2 != 0 && Test(SCALE*s1 / s2, target, out dbg, t1+"/"+t2)) { return true; }
	if (s1 != 0 && Test(SCALE*s2 / s1, target, out dbg, t2+"/"+t1)) { return true; }

	dbg = "_";
	return false;
}

private bool Test(int s1, int target, out string dbg, string t1)
{
	if (s1/SCALE == target && s1 % SCALE == 0)
	{
		dbg = t1;
		return true;
	}
	else
	{
		dbg = "_";
		return false;
	}
}