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
int solvedCells = 0;
int[,] grid = new int[9, 9];
bool[,] pspace = new bool[3 * 9, 3 * 9]; // possibility space
int[,] rstack = new int[3 * 9, 3 * 9];
int[,] rlatter = new int[9, 9];

const bool DUMP_ANY = true;

readonly bool DUMP_TOP_LEVEL_INFO        = true  && DUMP_ANY;
readonly bool DUMP_INITIAL_GRID          = true  && DUMP_ANY;
readonly bool DUMP_INTERMEDIATE_GRIDS    = false && DUMP_ANY;
readonly bool DUMP_FINAL_GRIDS           = true  && DUMP_ANY;
readonly bool DUMP_DVERR_GRIDS           = false && DUMP_ANY;
readonly bool DUMP_RECDOWN_GRID          = false && DUMP_ANY;
readonly bool DUMP_VALUE_FOUND           = true  && DUMP_ANY;
readonly bool DUMP_VALUE_ERRSTATE_INFO   = true  && DUMP_ANY;
readonly bool DUMP_RECURSION_INFO        = true  && DUMP_ANY;
readonly bool DUMP_ADDITIONAL_ASCII_GRID = false && DUMP_ANY;

int rd = 0;
int ru = 0;

void Main()
{
	if (! File.Exists(PATH)) File.WriteAllText(PATH, (new WebClient()).DownloadString(URL));

	string[] lines = File.ReadAllLines(PATH);

	//==============
	Solve(lines, 25 - 1);
	//==============

	int sum = 0;
	for (int i = COUNT_S; i < COUNT_S+COUNT_E; i++)
	{
		if (DUMP_TOP_LEVEL_INFO) ("----------------------------- " + i + " -----------------------------").Dump();
		
		rd = 0;
		ru = 0;
		
		int currResult;
		sum += (currResult = Solve(lines, i));

		//$"id={i+1} | rd ={rd} | ru={ru}".Dump();

		if (DUMP_TOP_LEVEL_INFO) $"    > IM_RESULT := {currResult}".Dump();
		
		if (currResult == 0) StateFail();
	}
	sum.Dump("result");
	if (sum != 24702) throw new Exception("!= 24702");
}

public int Solve(string[] lines, int puzzle)
{
	recursionLevel = 1;
	solvedCells = 0;
	grid = new int[9, 9];
	pspace = new bool[3 * 9, 3 * 9];
	rstack = new int[3 * 9, 3 * 9];
	rlatter = new int[9, 9];

	return Solve(Get(lines, puzzle));
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
			SetValueAndHints(x, y, src[x,y], 1);
		}
	}
	
	if (DUMP_INITIAL_GRID) DumpGrid();
	
	while (solvedCells != 81)
	{

		ValidateState();

		if (DUMP_INTERMEDIATE_GRIDS) DumpGrid();
		
		int changes = 0;
		for (int ii = 9 * 9 - 1; ii >= 0; ii--)
		{
			int x = ii % 9;
			int y = ii / 9;

			if (grid[x, y] == 0)
			{
				int rv = 0;
				
				int cc = 0;
				for (int v = 9-1; v>=0; v--)
				{
					if (! pspace[(x * 3) + (v % 3), (y * 3) + (v / 3)])
					{
						cc++;
						rv = v+1;
					}
				}
				
				if (cc == 0) 
				{
					if (DUMP_RECURSION_INFO) $"Found error in DV [{x}|{y}] (recursion {recursionLevel})".Dump();
					if (DUMP_DVERR_GRIDS) DumpGrid();

					RecursionStepUp();
					
					goto loopEnd;
				}
				else if (cc == 1)
				{
					if (DUMP_VALUE_FOUND) $"Value determined [{x}|{y}]:={rv} in recursion {recursionLevel}".Dump();
					
					SetValueAndHints(x, y, rv, recursionLevel);
				
					changes++;
				}
			}
		}

		if (changes == 0)
		{
			RecursionStepDown(0);
			goto loopEnd;
		}

	loopEnd: new Action(() => {}).Invoke();
	}
	
	for (int x = 0; x < 9; x++)
	for (int y = 0; y < 9; y++)
	{
		if (grid[x, y] == 0) StateFail();
	}
	
	ValidateSolution(src);

	if (DUMP_FINAL_GRIDS) DumpGrid();

	return grid[0,0]*100 + grid[1,0]*10 + grid[2,0];
}

void SetValueAndHints(int cx, int cy, int value, int recDepth)
{
	if (grid[cx,cy] != 0) StateFail();

	grid[cx, cy] = value;
	solvedCells++;
	for (int v = 0; v < 9; v++)
	{
		pspace[(cx*3) + (v%3), (cy*3) + (v/3)] = true;
		if (rstack[(cx*3) + (v%3), (cy*3) + (v/3)] == 0) rstack[(cx*3) + (v%3), (cy*3) + (v/3)] = recDepth;
	}

	// ================ INSERT HINTS ================

	// this row
	for (int ix = 0; ix < 9; ix++)
	{
		    pspace[(ix * 3) + ((value - 1) % 3), (cy * 3) + ((value - 1) / 3)] = true;
		if (rstack[(ix * 3) + ((value - 1) % 3), (cy * 3) + ((value - 1) / 3)] == 0) rstack[(ix * 3) + ((value - 1) % 3), (cy * 3) + ((value - 1) / 3)] = recDepth;
	}

	// this column
	for (int iy = 0; iy < 9; iy++)
	{
		    pspace[(cx * 3) + ((value - 1) % 3), (iy * 3) + ((value - 1) / 3)] = true;
		if (rstack[(cx * 3) + ((value - 1) % 3), (iy * 3) + ((value - 1) / 3)] == 0) rstack[(cx * 3) + ((value - 1) % 3), (iy * 3) + ((value - 1) / 3)] = recDepth;
	}

	// this area
	for (int ax = 0; ax < 3; ax++)
	for (int ay = 0; ay < 3; ay++)
	{
		    pspace[((3 * (cx / 3) + ax) * 3) + ((value - 1) % 3), ((3 * (cy / 3) + ay) * 3) + ((value - 1) / 3)] = true;
		if (rstack[((3 * (cx / 3) + ax) * 3) + ((value - 1) % 3), ((3 * (cy / 3) + ay) * 3) + ((value - 1) / 3)] == 0) rstack[((3 * (cx / 3) + ax) * 3) + ((value - 1) % 3), ((3 * (cy / 3) + ay) * 3) + ((value - 1) / 3)] = recDepth;
	}
}

void RecursionStepDown(int lo)
{
	rd++;
	
	if (DUMP_RECURSION_INFO) $"RECURSION DOWN {recursionLevel} -> {recursionLevel + 1}  // lower_bound={lo}".Dump();
	if (DUMP_RECDOWN_GRID) DumpGrid();

	int bx = 0;
	int by = 0;
	int bv = 0;
	int bvc = 9*9*9*9;

	for (int ii = 9 * 9 - 1; ii >= 0; ii--)
	{
		int fbx = ii % 9;
		int fby = ii / 9;

		if (grid[fbx, fby] == 0)
		{
			int v = 0;
			int vc = 0;
			for (int tv = 1; tv <= 9; tv++)
			{
				if (!pspace[(fbx * 3) + ((tv - 1) % 3), (fby * 3) + ((tv - 1) / 3)])
				{
					vc++;
					if (v == 0 && tv > lo) v = tv;
				}
			}

			if (vc != 0 && bvc > vc)
			{
				bx = fbx;
				by = fby;
				bv = v;
				bvc = vc;
			}
		}
	}
	
	//-------

	if (bv == 0)
	{
		if (DUMP_RECURSION_INFO) $"RECURSION DOWN :: PSpace exhausted".Dump();
		
		RecursionStepUp();
		return;
	}

	if (DUMP_RECURSION_INFO) $"RECURSION SET [{bx}|{by}]:={bv}".Dump();

	if (bv==0) StateFail();


	recursionLevel++;

	if (rlatter[bx,by] != 0) StateFail();
	rlatter[bx,by] = recursionLevel;
	
	SetValueAndHints(bx, by, bv, recursionLevel);
}

void RecursionStepUp()
{
	ru++;
	
	if (recursionLevel == 1) StateFail();
	
	// find step
	int latterstepV = -1;
	int latterstepX = -1;
	int latterstepY = -1;
	for (int ii = 9*9-1; ii >= 0; ii--)
	{
		int gx = ii%9;
		int gy = ii/9;
		
		if (rlatter[gx, gy] == recursionLevel)
		{
			latterstepV = grid[gx, gy];
			latterstepX = gx;
			latterstepY = gy;
		}
	}

	if (DUMP_RECURSION_INFO) $"RECURSION UP {recursionLevel} -> {recursionLevel - 1}".Dump();


	if (latterstepV<=0) StateFail();
	
	// undo
	for (int ii = 3*9*3*9 - 1; ii >= 0; ii--)
	{
		int px = ii % (3*9);
		int py = ii / (3*9);
		
		if (rstack[px, py] > recursionLevel) StateFail();
		if (rstack[px, py] == recursionLevel)
		{
			rstack[px,py] = 0;
			pspace[px,py] = false;
			if (grid[px / 3, py / 3] != 0)
			{
				if (DUMP_RECURSION_INFO) $"RECURSION UNSET [{px / 3}|{py / 3}]:=(old={grid[px / 3, py / 3]})".Dump();
				grid[px / 3, py / 3] = 0;
				solvedCells--; 
			}
		}
	}

	recursionLevel--;

	rlatter[latterstepX, latterstepY] = 0;
	
	if (grid[latterstepX, latterstepY] != 0) StateFail();

	// back down
	RecursionStepDown(latterstepV);
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
	const int CW = PW * 3 + 2;
	const int W = CW * 9;
	const int H = CW * 9;

	Bitmap b = new Bitmap(W, H, PixelFormat.Format32bppArgb);
	using (Graphics g = Graphics.FromImage(b))
	{
		g.Clear(Color.Beige);
		g.DrawRectangle(Pens.Black, 0, 0, W - 1, H - 1);
		for (int x = 0; x < 10; x++) g.DrawLine(x % 3 == 0 ? PB2 : PB1, x * CW, 0, x * CW, H);
		for (int y = 0; y < 10; y++) g.DrawLine(y % 3 == 0 ? PB2 : PB1, 0, y * CW, W, y * CW);

		for (int x = 0; x < 9; x++)
			for (int y = 0; y < 9; y++)
				for (int ix = 0; ix < 3; ix++)
					for (int iy = 0; iy < 3; iy++)
					{
						var brush = pspace[(x * 3) + (((1 + iy * 3 + ix) - 1) % 3), (y * 3) + (((1 + iy * 3 + ix) - 1) / 3)] ? BT : BF;
						var rx = x * CW + ix * (PW + 1);
						var ry = y * CW + iy * (PW + 1);
						if (grid[x, y] == 0) g.FillRectangle(brush, rx, ry, PW, PW);
					}

		for (int x = 0; x < 9; x++)
			for (int y = 0; y < 9; y++)
			{
				if (grid[x, y] != 0) g.DrawString(grid[x, y].ToString(), F, rlatter[x, y] > 1 ? BN2 : BN1, x * CW + 5, y * CW + 3);
			}

	}
	b.Dump();


	if (DUMP_ADDITIONAL_ASCII_GRID)
	{
		StringBuilder buildr = new StringBuilder();

		buildr.Clear();
		for (int iy = 0; iy < 9 * 3; iy++)
		{
			for (int ix = 0; ix < 9 * 3; ix++)
			{
				buildr.Append(pspace[ix, iy] ? 'X' : ' ');
			}
			buildr.Append("\r\n");
		}
		buildr.ToString().Dump("PSPACE");


		buildr.Clear();
		for (int iy = 0; iy < 9; iy++)
		{
			for (int ix = 0; ix < 9; ix++)
			{
				buildr.Append(grid[ix, iy]>0 ? (""+grid[ix, iy]) : "0");
			}
			buildr.Append("\r\n");
		}
		buildr.ToString().Dump("GRID");
	}

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