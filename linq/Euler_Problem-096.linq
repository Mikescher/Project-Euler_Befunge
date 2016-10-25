<Query Kind="Program">
  <Namespace>System.Net</Namespace>
  <Namespace>System.Drawing</Namespace>
  <Namespace>System.Drawing.Imaging</Namespace>
</Query>

/*
Su Doku (Japanese meaning number place) is the name given to a popular puzzle concept.
Its origin is unclear, but credit must be attributed to Leonhard Euler
who invented a similar, and much more difficult, puzzle idea called Latin Squares.
The objective of Su Doku puzzles, however, is to replace the blanks (or zeros)
in a 9 by 9 grid in such that each row, column, and 3 by 3 box contains
each of the digits 1 to 9.
Below is an example of a typical starting puzzle grid and its solution grid.

~~~~~~~~~~~~~~~~~~~~~
0 0 3   0 2 0   6 0 0
9 0 0   3 0 5   0 0 1
0 0 1   8 0 6   4 0 0

0 0 8   1 0 2   9 0 0
7 0 0   0 0 0   0 0 8
0 0 6   7 0 8   2 0 0

0 0 2   6 0 9   5 0 0
8 0 0   2 0 3   0 0 9
0 0 5   0 1 0   3 0 0
~~~~~~~~~~~~~~~~~~~~~

~~~~~~~~~~~~~~~~~~~~~
4 8 3   9 2 1   6 5 7
9 6 7   3 4 5   8 2 1
2 5 1 	8 7 6   4 9 3

5 4 8   1 3 2   9 7 6
7 2 9   5 6 4   1 3 8
1 3 6 	7 9 8   2 4 5

3 7 2   6 8 9   5 1 4
8 1 4   2 5 3   7 6 9
6 9 5 	4 1 7   3 8 2
~~~~~~~~~~~~~~~~~~~~~

A well constructed Su Doku puzzle has a unique solution and can be solved by logic,
although it may be necessary to employ "guess and test" methods in order to eliminate
options (there is much contested opinion over this).
The complexity of the search determines the difficulty of the puzzle;
the example above is considered easy because it can be solved by straight forward
direct deduction.

The 6K text file, sudoku.txt (right click and 'Save Link/Target As...'),
contains fifty different Su Doku puzzles ranging in difficulty,
but all with unique solutions (the first puzzle in the file is the example above).

By solving all fifty puzzles find the sum of the 3-digit numbers found in the top
left corner of each solution grid; for example, 483 is the 3-digit number found in the
top left corner of the solution grid above.

*/

// => 24702

const string URL = @"http://projecteuler.net/project/resources/p096_sudoku.txt";

readonly string PATH = Environment.ExpandEnvironmentVariables(@"%temp%\sudoku.txt");

const int COUNT_S = 0; //0;
const int COUNT_E = 50; //50;

int recursionLevel = 1;
int[,] grid = new int[9, 9];
bool[,] pspace = new bool[3 * 9, 3 * 9]; // possibility space
int[,] rstack = new int[3 * 9, 3 * 9];
int[,] rlatter = new int[9, 9];

readonly bool DUMP_INITIAL_GRID = true;
readonly bool DUMP_INTERMEDIATE_GRIDS = false;
readonly bool DUMP_FINAL_GRIDS = true;
readonly bool DUMP_DVERR_GRIDS = false;
readonly bool DUMP_RECDOWN_GRID = false;
readonly bool DUMP_VALUE_FOUND = true;
readonly bool DUMP_VALUE_ERRSTATE_INFO = true;
readonly bool DUMP_RECURSION_INFO = true;

void Main()
{
	if (! File.Exists(PATH)) File.WriteAllText(PATH, (new WebClient()).DownloadString(URL));

	string[] lines = File.ReadAllLines(PATH);

	int sum = 0;
	for (int i = COUNT_S; i < COUNT_S+COUNT_E; i++)
	{
		("----------------------------- " + i + " -----------------------------").Dump();
		
		recursionLevel = 1;
		grid = new int[9,9];
		pspace = new bool[3 * 9, 3 * 9];
		rstack = new int[3 * 9, 3 * 9];
		rlatter = new int[9,9];
		
		int s = Solve(Get(lines, i));
		sum += s;

		$"    > IM_RESULT := {s}".Dump();
		
		if (s == 0) StateFail();
	}
	sum.Dump("result");
}

public int[,] Get(string[] data, int idx)
{
	int[,] arr = new int[9,9];
	for (int x = 0; x < 9; x++)
	for (int y = 0; y < 9; y++)
	{
		arr[x,y] = data[idx*10+1+y][x] - '0';
	}
	return arr;
}

public int Solve(int[,] src)
{
	// INIT
	
	recursionLevel = 1;
	
	for (int x = 0; x < 9; x++)
	for (int y = 0; y < 9; y++)
	{
		if (src[x,y] != 0)
		{
			SetValueAndHints(x, y, src[x,y], recursionLevel);
		}
	}
	
	if (DUMP_INITIAL_GRID) DumpGrid();
	
	while (! IsSolved())
	{
		loopStart:

		ValidateState();

		if (DUMP_INTERMEDIATE_GRIDS) DumpGrid();
		
		int changes = 0;
		for (int x = 0; x < 9; x++)
		for (int y = 0; y < 9; y++)
		{
			if (grid[x, y] == 0)
			{
				int dv = DetermineValue(x, y);

				if (dv == -1) 
				{
					if (DUMP_RECURSION_INFO) $"Found error in DV [{x}|{y}] (recursion {recursionLevel})".Dump();
					if (DUMP_DVERR_GRIDS) DumpGrid();
					
					RecursionStepUp();
					goto loopStart;
				}
				else if (dv != 0)
				{
					if (DUMP_VALUE_FOUND) $"Value determined [{x}|{y}]:={dv} in recursion {recursionLevel}".Dump();
					
					SetValueAndHints(x, y, dv, recursionLevel);
				
					changes++;
				}
			}
		}

		if (changes == 0)
		{
			RecursionStepDown(0, null, null);
		}
	}
	
	ValidateSolution(src);

	if (DUMP_FINAL_GRIDS) DumpGrid();

	return grid[0,0]*100 + grid[1,0]*10 + grid[2,0];
}

void SetValueAndHints(int cx, int cy, int value, int recDepth)
{
	if (grid[cx,cy] != 0) StateFail();

	grid[cx, cy] = value;
	for (int v = 1; v <= 9; v++)
	{
		SetHint(cx, cy, v, true, recDepth);
	}
	
	InsertHints(cx, cy, value, recDepth);
}

void InsertHints(int cx, int cy, int value, int recDepth)
{
	// this row
	for (int ix = 0; ix < 9; ix++)
	{
		SetHint(ix, cy, value, true, recDepth);
	}

	// this column
	for (int iy = 0; iy < 9; iy++)
	{
		SetHint(cx, iy, value, true, recDepth);
	}

	// this area
	for (int ax = 0; ax < 3; ax++)
	for (int ay = 0; ay < 3; ay++)
	{
		SetHint(3 * (cx / 3) + ax, 3 * (cy / 3) + ay, value, true, recDepth);
	}
}

void SetHint(int cx, int cy, int num, bool value, int recDepth)
{
	int arrx = (cx*3) + ((num-1)%3);
	int arry = (cy*3) + ((num-1)/3);
	
	pspace[arrx, arry] = value;

	if (value)
	{
		if (rstack[arrx, arry] > recDepth) StateFail();
		
		if (rstack[arrx,arry] == 0) rstack[arrx,arry] = recDepth;
	}
	else
	{
		if (rstack[arrx, arry] != recDepth) StateFail();

		rstack[arrx, arry] = 0;
	}
	
}

bool GetHint(int cx, int cy, int num)
{
	return pspace[(cx * 3) + ((num - 1) % 3), (cy * 3) + ((num - 1) / 3)];
}

bool IsSolved()
{
	for (int x = 0; x < 9; x++)
	for (int y = 0; y < 9; y++)
	{
		if (grid[x, y] == 0) return false;
	}
		
	return true;
}

int DetermineValue(int cx, int cy)
{
	int rv = 0;
	
	int cc = 0;
	for (int v = 1; v <= 9; v++)
	{
		if (! GetHint(cx, cy, v))
		{
			cc++;
			rv = v;
		}
	}
	
	if (cc == 0) return -1;
	if (cc == 1) return rv;
	
	return 0;
}

void DumpGrid()
{
	var F = new Font(FontFamily.GenericSansSerif, 12);

	var PB1 = new Pen(Color.Black, 1);
	var PB2 = new Pen(Color.Black, 2);

	var BT = new SolidBrush(Color.FromArgb(64, 0, 0, 0));
	var BF = new SolidBrush(Color.FromArgb(00, 0, 0, 0));

	var BN1 = Brushes.Black;
	var BN2 = Brushes.DeepPink;

	const int PW = 8;
	const int CW = PW*3+2;
	const int W = CW * 9;
	const int H = CW * 9;

	Bitmap b = new Bitmap(W, H, PixelFormat.Format32bppArgb);
    using (Graphics g = Graphics.FromImage(b))
	{
		g.Clear(Color.Beige);
		g.DrawRectangle(Pens.Black, 0, 0, W - 1, H - 1);
		for (int x = 0; x < 10; x++) g.DrawLine(x%3==0 ? PB2:PB1, x * CW, 0, x * CW, H);
		for (int y = 0; y < 10; y++) g.DrawLine(y%3==0 ? PB2:PB1, 0, y * CW, W, y * CW);

		for (int x = 0; x < 9; x++)
		for (int y = 0; y < 9; y++)
		for (int ix = 0; ix < 3; ix++)
		for (int iy = 0; iy < 3; iy++)
		{
			var brush = GetHint(x,y,1+iy*3+ix)?BT:BF;
			var rx = x*CW + ix*(PW+1);
			var ry = y*CW + iy*(PW+1);
			if (grid[x, y] == 0) g.FillRectangle(brush,rx,ry,PW,PW);
		}

		for (int x = 0; x < 9; x++)
		for (int y = 0; y < 9; y++)
		{
			if (grid[x, y] != 0) g.DrawString(grid[x, y].ToString(), F, rlatter[x,y]>1?BN2:BN1, x * CW + 5, y * CW + 3);
		}
		
	}
	b.Dump();
}

void ValidateSolution(int[,] src)
{
	for (int x = 0; x < 9; x++)
	for (int y = 0; y < 9; y++)
	{
		if (grid[x,y] <= 0 || grid[x,y] > 9) StateFail();
	}
		
	for (int x = 0; x < 9; x++)
	for (int y = 0; y < 9; y++)
	{
		if (src[x,y] != 0 && src[x,y] != grid[x,y]) StateFail();
	}
	
	// cols
	for (int x = 0; x < 9; x++)
	{
		if (Enumerable.Range(0,9).Select(y => grid[x,y]).Distinct().Count() != 9) StateFail();
	}

	// rows
	for (int y = 0; y < 9; y++)
	{
		if (Enumerable.Range(0, 9).Select(x => grid[x, y]).Distinct().Count() != 9) StateFail();
	}

	// areas
	for (int ax = 0; ax < 3; ax++)
	for (int ay = 0; ay < 3; ay++)
	{
		if (Enumerable.Range(0, 9).Select(v => grid[ax*3+(v%3), ay*3+(v/3)]).Distinct().Count() != 9) StateFail();
	}
}

void ValidateState()
{
	for (int x = 0; x < 9; x++)
	for (int y = 0; y < 9; y++)
	{
		if (grid[x,y] < 0 || grid[x,y] > 9) StateFail();
	}
	
	// cols
	for (int x = 0; x < 9; x++)
	{
		var g = Enumerable.Range(0,9).Select(y => grid[x,y]).Where(p=>p!=0).GroupBy(p=>p);
		if (g.Any(p=>p.Count()!=1)) StateFail();
	}

	// rows
	for (int y = 0; y < 9; y++)
	{
		var g = Enumerable.Range(0, 9).Select(x => grid[x, y]).Where(p=>p!=0).GroupBy(p=>p);
		if (g.Any(p=>p.Count()!=1)) StateFail();
	}

	// areas
	for (int ax = 0; ax < 3; ax++)
	for (int ay = 0; ay < 3; ay++)
	{
		var g = Enumerable.Range(0, 9).Select(v => grid[ax*3+(v%3), ay*3+(v/3)]).Where(p=>p!=0).GroupBy(p=>p);
		if (g.Any(p=>p.Count()!=1)) StateFail();
	}
}

Tuple<int, int, int> FindBestRecursionStep(int lonum)
{
	int bx=0;
	int by=0;
	int bv=0;
	int bvc=999;
	
	for (int x = 0; x < 9; x++)
	for (int y = 0; y < 9; y++)
	{
		if (grid[x,y] == 0)
		{
			int v = 0;
			int vc = 0;
			for (int tv = 1; tv <= 9; tv++)
			{
				if (!GetHint(x, y, tv))
				{
					if (v==0 && tv > lonum) v = tv;
					vc++;
				}
			}
			
			//if (v==0 && vc > 0) StateFail();
			
			if (vc != 0 && vc < bvc)
			{
				bx  = x;
				by  = y;
				bv  = v;
				bvc = vc;
			}
		}
	}
	
	return Tuple.Create(bx,by,bv);
}

void RecursionStepDown(int lo, int? tx, int? ty)
{
	if (DUMP_RECURSION_INFO) $"RECURSION DOWN {recursionLevel} -> {recursionLevel + 1}  // lower_bound={lo}".Dump();
	if (DUMP_RECDOWN_GRID) DumpGrid();
	
	var best = FindBestRecursionStep(lo);
	var bx = best.Item1;
	var by = best.Item2;
	var bv = best.Item3;

	if (bv == 0)
	{
		if (DUMP_RECURSION_INFO) $"RECURSION DOWN :: PSpace exhausted".Dump();
		RecursionStepUp();
		return;
	}

	if (DUMP_RECURSION_INFO) $"RECURSION SET [{bx}|{by}]:={bv}".Dump();

	if (bv==0) StateFail();
	if (tx != null && tx != bx) StateFail();
	if (ty != null && ty != by) StateFail();


	recursionLevel++;

	if (rlatter[bx,by] != 0) StateFail();
	rlatter[bx,by] = recursionLevel;
	
	SetValueAndHints(bx, by, bv, recursionLevel);
}

void RecursionStepUp()
{
	if (recursionLevel == 1) StateFail();
	
	if (DUMP_RECURSION_INFO) $"RECURSION UP {recursionLevel} -> {recursionLevel - 1}".Dump();
	
	// find step
	int latterstepV = -1;
	int latterstepX = -1;
	int latterstepY = -1;
	for (int gx = 0; gx < 9; gx++)
	for (int gy = 0; gy < 9; gy++)
	{
		if (rlatter[gx, gy] == recursionLevel)
		{
			latterstepV = grid[gx, gy];
			latterstepX = gx;
			latterstepY = gy;
		}
	}
	
	if (latterstepV<=0) StateFail();
	
	// undo
	for (int px = 0; px < 3*9; px++)
	for (int py = 0; py < 3*9; py++)
	{
		if (rstack[px, py] > recursionLevel) StateFail();
		if (rstack[px, py] == recursionLevel)
		{
			rstack[px,py] = 0;
			pspace[px,py] = false;
			if (grid[px/3,py/3]!=0)grid[px/3,py/3] = 0;
		}
	}

	recursionLevel--;

	rlatter[latterstepX, latterstepY] = 0;
	grid[latterstepX, latterstepY] = 0;

	// back down
	RecursionStepDown(latterstepV, latterstepX, latterstepY);
}

void StateFail()
{
	if (DUMP_VALUE_ERRSTATE_INFO)
	{
		"Internal Solver state error".Dump();
		new StackTrace().ToString().Dump();
		DumpGrid();
	}
	Debugger.Break();
	throw new Exception("FATAL");
}