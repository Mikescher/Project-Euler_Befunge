<Query Kind="Program" />

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

bool[,,,] sets = new bool[10, 10, 10, 10];

void Main()
{
	Util.AutoScrollResults = true;

	InitSet();

	DumpSet(false);

	for (int i = 1; ; i++)
	{
		bool r = FilterSet(i);
		DumpSet(false);
		if (! r) return;
	}
}

private void InitSet()
{
	for (int s1 = 1;      s1 < 10; s1++)
	for (int s2 = s1 + 1; s2 < 10; s2++)
	for (int s3 = s2 + 1; s3 < 10; s3++)
	for (int s4 = s3 + 1; s4 < 10; s4++)
	{
		sets[s1, s2, s3, s4] = true;
	}
}

private void DumpSet(bool imd)
{
	int i = 0;

	for (int s1 = 0;      s1 < 10; s1++)
	for (int s2 = s1 + 1; s2 < 10; s2++)
	for (int s3 = s2 + 1; s3 < 10; s3++)
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

private bool FilterSet(int target)
{
	bool found = false;

	for (int s1 = 0;      s1 < 10; s1++)
	for (int s2 = s1 + 1; s2 < 10; s2++)
	for (int s3 = s2 + 1; s3 < 10; s3++)
	for (int s4 = s3 + 1; s4 < 10; s4++)
	{
		if (sets[s1, s2, s3, s4]) 
		{
			string path;
			bool test = Test(s1, s2, s3, s4, target, out path);
			
			sets[s1, s2, s3, s4] = test;

			//if (target > 28 && test) $"({s1}{s2}{s3}{s4}) => {path} = {target}".Dump();
			if (s1==1&&s2==2&&s3==5&&s4==8) $"{path}={target}".Dump();
			
			found |= test;
		}
	}
	
	return found;
}

private bool Test(double s1, double s2, double s3, double s4, double target, out string dbg)
{
	string t1 = s1.ToString();
	string t2 = s2.ToString();
	string t3 = s3.ToString();
	string t4 = s4.ToString();

	if (Test(s1 + s2, s3, s4, target, out dbg, "("+t1+"+"+t2+")", t3, t4)) { return true; }
	if (Test(s1 + s3, s2, s4, target, out dbg, "("+t1+"+"+t3+")", t2, t4)) { return true; }
	if (Test(s1 + s4, s2, s3, target, out dbg, "("+t1+"+"+t4+")", t2, t3)) { return true; }
	if (Test(s1, s2 + s1, s3, target, out dbg, t1, "("+t2+"+"+t1+")", t3)) { return true; }
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
	if (Test(s1, s2 - s1, s3, target, out dbg, t1, "("+t2+"-"+t1+")", t3)) { return true; }
	if (Test(s1, s2 - s3, s4, target, out dbg, t1, "("+t2+"-"+t3+")", t4)) { return true; }
	if (Test(s1, s2 - s4, s3, target, out dbg, t1, "("+t2+"-"+t4+")", t3)) { return true; }
	if (Test(s4, s2, s3 - s1, target, out dbg, t4, t2, "("+t3+"-"+t1+")")) { return true; }
	if (Test(s1, s4, s3 - s2, target, out dbg, t1, t4, "("+t3+"-"+t2+")")) { return true; }
	if (Test(s1, s2, s3 - s4, target, out dbg, t1, t2, "("+t3+"-"+t4+")")) { return true; }
	if (Test(s3, s2, s4 - s1, target, out dbg, t3, t2, "("+t4+"-"+t1+")")) { return true; }
	if (Test(s1, s3, s4 - s2, target, out dbg, t1, t3, "("+t4+"-"+t2+")")) { return true; }
	if (Test(s1, s2, s4 - s3, target, out dbg, t1, t2, "("+t4+"-"+t3+")")) { return true; }
												  
	if (Test(s1 * s2, s3, s4, target, out dbg, "("+t1+"*"+t2+")", t3, t4)) { return true; }
	if (Test(s1 * s3, s2, s4, target, out dbg, "("+t1+"*"+t3+")", t2, t4)) { return true; }
	if (Test(s1 * s4, s2, s3, target, out dbg, "("+t1+"*"+t4+")", t2, t3)) { return true; }
	if (Test(s1, s2 * s1, s3, target, out dbg, t1, "("+t2+"*"+t1+")", t3)) { return true; }
	if (Test(s1, s2 * s3, s4, target, out dbg, t1, "("+t2+"*"+t3+")", t4)) { return true; }
	if (Test(s1, s2 * s4, s3, target, out dbg, t1, "("+t2+"*"+t4+")", t3)) { return true; }
	if (Test(s4, s2, s3 * s1, target, out dbg, t4, t2, "("+t3+"*"+t1+")")) { return true; }
	if (Test(s1, s4, s3 * s2, target, out dbg, t1, t4, "("+t3+"*"+t2+")")) { return true; }
	if (Test(s1, s2, s3 * s4, target, out dbg, t1, t2, "("+t3+"*"+t4+")")) { return true; }
	if (Test(s3, s2, s4 * s1, target, out dbg, t3, t2, "("+t4+"*"+t1+")")) { return true; }
	if (Test(s1, s3, s4 * s2, target, out dbg, t1, t3, "("+t4+"*"+t2+")")) { return true; }
	if (Test(s1, s2, s4 * s3, target, out dbg, t1, t2, "("+t4+"*"+t3+")")) { return true; }

	if (s2 != 0 && Test(s1 / s2, s3, s4, target, out dbg, "("+t1+"/"+t2+")", t3, t4)) { return true; }
	if (s3 != 0 && Test(s1 / s3, s2, s4, target, out dbg, "("+t1+"/"+t3+")", t2, t4)) { return true; }
	if (s4 != 0 && Test(s1 / s4, s2, s3, target, out dbg, "("+t1+"/"+t4+")", t2, t3)) { return true; }
	if (s1 != 0 && Test(s1, s2 / s1, s3, target, out dbg, t1, "("+t2+"/"+t1+")", t3)) { return true; }
	if (s3 != 0 && Test(s1, s2 / s3, s4, target, out dbg, t1, "("+t2+"/"+t3+")", t4)) { return true; }
	if (s4 != 0 && Test(s1, s2 / s4, s3, target, out dbg, t1, "("+t2+"/"+t4+")", t3)) { return true; }
	if (s1 != 0 && Test(s4, s2, s3 / s1, target, out dbg, t4, t2, "("+t3+"/"+t1+")")) { return true; }
	if (s2 != 0 && Test(s1, s4, s3 / s2, target, out dbg, t1, t4, "("+t3+"/"+t2+")")) { return true; }
	if (s4 != 0 && Test(s1, s2, s3 / s4, target, out dbg, t1, t2, "("+t3+"/"+t4+")")) { return true; }
	if (s1 != 0 && Test(s3, s2, s4 / s1, target, out dbg, t3, t2, "("+t4+"/"+t1+")")) { return true; }
	if (s2 != 0 && Test(s1, s3, s4 / s2, target, out dbg, t1, t3, "("+t4+"/"+t2+")")) { return true; }
	if (s3 != 0 && Test(s1, s2, s4 / s3, target, out dbg, t1, t2, "("+t4+"/"+t3+")")) { return true; }

	dbg = "_";
	return false;
}

private bool Test(double s1, double s2, double s3, double target, out string dbg, string t1, string t2, string t3)
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
											  
	if (Test(s1 * s2, s3, target, out dbg, "("+t1+"-"+t2+")", t3)) { return true; }
	if (Test(s1 * s3, s2, target, out dbg, "("+t1+"-"+t3+")", t2)) { return true; }
	if (Test(s3, s2 * s1, target, out dbg, "("+t3+"-"+t2+")", t1)) { return true; }
	if (Test(s1, s2 * s3, target, out dbg, t1, "("+t2+"-"+t3+")")) { return true; }
	if (Test(s2, s3 * s1, target, out dbg, t2, "("+t3+"-"+t1+")")) { return true; }
	if (Test(s1, s3 * s2, target, out dbg, t1, "("+t3+"-"+t2+")")) { return true; }

	if (s2 != 0 && Test(s1 / s2, s3, target, out dbg, t1+"-"+t2, t3)) { return true; }
	if (s3 != 0 && Test(s1 / s3, s2, target, out dbg, t1+"-"+t3, t2)) { return true; }
	if (s1 != 0 && Test(s3, s2 / s1, target, out dbg, t3+"-"+t2, t1)) { return true; }
	if (s3 != 0 && Test(s1, s2 / s3, target, out dbg, t1, t2+"-"+t3)) { return true; }
	if (s1 != 0 && Test(s2, s3 / s1, target, out dbg, t2, t3+"-"+t1)) { return true; }
	if (s2 != 0 && Test(s1, s3 / s2, target, out dbg, t1, t3+"-"+t2)) { return true; }

	dbg = "_";
	return false;
}

private bool Test(double s1, double s2, double target, out string dbg, string t1, string t2)
{
	if (Test(s1 + s2, target, out dbg, t1+"+"+t2)) { return true; }
	if (Test(s2 + s1, target, out dbg, t2+"+"+t1)) { return true; }
										  
	if (Test(s1 - s2, target, out dbg, t1+"-"+t2)) { return true; }
	if (Test(s2 - s1, target, out dbg, t2+"-"+t1)) { return true; }
										  
	if (Test(s1 * s2, target, out dbg, t1+"*"+t2)) { return true; }
	if (Test(s2 * s1, target, out dbg, t2+"*"+t1)) { return true; }

	if (s2 != 0 && Test(s1 / s2, target, out dbg, t1+"/"+t2)) { return true; }
	if (s1 != 0 && Test(s2 / s1, target, out dbg, t2+"/"+t1)) { return true; }

	dbg = "_";
	return false;
}

private bool Test(double s1, double target, out string dbg, string t1)
{
	if (s1 == target && s1 == (int)s1)
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