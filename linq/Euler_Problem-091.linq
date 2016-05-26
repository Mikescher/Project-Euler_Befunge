<Query Kind="Program">
  <Namespace>System.Drawing</Namespace>
  <Namespace>System.Drawing.Imaging</Namespace>
</Query>

/*
The points `P(x1, y1)` and `Q(x2, y2)` are plotted at integer co-ordinates and are joined to the origin,
`O(0,0)`, to form `OPQ`.

![img](p091_1.gif)

There are exactly fourteen triangles containing a right angle that can be formed when each co-ordinate 
lies between 0 and 2 inclusive; that is,

~~~
0 <= x1, y1, x2, y2 <= 2.
~~~

![img](p091_2.gif)

Given that `0 <= x1, y1, x2, y2 <= 50`, how many right triangles can be formed?
*/

// angle_Q == angle_P
// result = angle_O + angle_Q

int SIZE = 50;

readonly bool DUMP_TRIANGLES_NM = false;
readonly bool DUMP_TRIANGLES_BF = false;

List<string> result_nm = new List<string>();
List<string> result_bf = new List<string>();

void Main()
{
//*
	Util.AutoScrollResults = true;

	(getAnglesBase() + 2 * getAnglesOuter()).Dump("Result");
	SolutionFast().Dump("Fast");
	BruteForce().Dump("Bruteforce");
	
	result_bf.Except(result_nm).Dump();
/*/
	SolutionFast().Dump();
//*/
}

// Triangles with right angle at O
int getAnglesBase()
{
	// P1 is O
	// P2 lies on left   edge (there are SIZE+1 nodes, one is reserved, SIZE are free)
	// P3 lies on bottom edge (there are SIZE+1 nodes, one is reserved, SIZE are free)

	// => SIZE * SIZE possible (and unique) combinations

	var triangles = 0;

	for (int q_x = 1; q_x <= SIZE; q_x++)
	{
		for (int p_y = 1; p_y <= SIZE; p_y++)
		{
			triangles++;

			DumpTriangle(0, 0, 0, p_y, q_x, 0, DUMP_TRIANGLES_NM);
			AddToResultCache(result_nm, 0, 0, 0, p_y, q_x, 0);
		}
	}

	return triangles;
	//return SIZE * SIZE;
}

// Triangles with right angle at Q
// = same count as for P
int getAnglesOuter()
{
	int triangles = 0;
	
	// triangles with Q on bottom edge
	
	for (int x = 1; x <= SIZE; x++)
	{
		for (int p_y = 1; p_y <= SIZE; p_y++)
		{
			DumpTriangle(0, 0, x, p_y, x, 0, DUMP_TRIANGLES_NM);
			DumpTriangle(0, 0, p_y, x, 0, x, DUMP_TRIANGLES_NM);

			AddToResultCache(result_nm, 0, 0, x, p_y, x, 0 );
			AddToResultCache(result_nm, 0, 0, p_y, x, 0, x );

			triangles++;
		}
	}

	//triangles += SIZE * SIZE;

	for (int q_x = 1; q_x <= SIZE; q_x++)
	{
		for (int q_y = 1; q_y <= SIZE; q_y++)
		{
			// Q(x, y)

			// OQ = Q - O
			
			var oq_x = q_x - 0;
			var oq_y = q_y - 0;
			
			// dir(QP) = rot(OQ, 90)

			var v_qp_x = -oq_y;
			var v_qp_y = oq_x;

			// We search for integer solutions of  P = Q + n * QP
			
			for (int p_y = q_y + 1; p_y <= SIZE; p_y++)
			{
				// p_y = q_y + n * v_qp_y
				// n   = (p_y - q_y) / v_qp_y
				// p_x = q_x + n * v_qp_x
				//     = q_x + ((p_y - q_y) / v_qp_y) * v_qp_x
				//     = q_x + ((p_y - q_y) * v_qp_x / v_qp_y)

				// First test if p_x will be integer
				if (((p_y - q_y) * v_qp_x) % v_qp_y != 0) continue;
				
				var p_x = q_x + (((p_y - q_y) * v_qp_x) / v_qp_y);

				if (p_x < 0) continue;

				var qp_x = q_x - p_x;
				var qp_y = q_y - p_y;

				// test for right angle:   dot_product(q, qp) == 0
				//if (q_x * qp_x + q_y * qp_y != 0) continue;

				DumpTriangle(0, 0, p_x, p_y, q_x, q_y, DUMP_TRIANGLES_NM);
				DumpTriangle(0, 0, p_y, p_x, q_y, q_x, DUMP_TRIANGLES_NM);

				AddToResultCache(result_nm, 0, 0, p_x, p_y, q_x, q_y);
				AddToResultCache(result_nm, 0, 0, p_y, p_x, q_y, q_x);
				
				triangles++;
			}
			
			//
		}
	}
	
	return triangles;
}

int BruteForce()
{
	int triangles = 0;

	for (int q_x = 0; q_x <= SIZE; q_x++)
	{
		for (int q_y = 0; q_y <= SIZE; q_y++)
		{
			int i_q = q_x * (SIZE + 1) + q_y;

			for (int p_x = 0; p_x <= SIZE; p_x++)
			{
				for (int p_y = 0; p_y <= SIZE; p_y++)
				{
					int i_p = p_x * (SIZE + 1) + p_y;

					if (i_p > i_q && IsRightTriangle(0, 0, q_x, q_y, p_x, p_y))
					{
						DumpTriangle(0, 0, q_x, q_y, p_x, p_y, DUMP_TRIANGLES_BF);
						AddToResultCache(result_bf, 0, 0, q_x, q_y, p_x, p_y);

						triangles++;
					}
				}
			}
		}
	}

	return triangles;
}

void DumpTriangle(int ox, int oy, int px, int py, int qx, int qy, bool dump)
{
	const int W = 64;
	const int H = 64;

	if (!dump) return;

	Bitmap b = new Bitmap(W + 1, H + 1, PixelFormat.Format24bppRgb);

	var scaleX = (W * 1f / SIZE);
	var scaleY = (H * 1f / SIZE);

	using (Graphics g = Graphics.FromImage(b))
	{
		g.ScaleTransform(1, -1);
		g.TranslateTransform(0, -H);
		
		g.Clear(Color.White);
		
		for (int i = 0; i <= SIZE; i++)
		{
			g.DrawLine(Pens.LightGray, 0, i * scaleX, W, i * scaleY);
			g.DrawLine(Pens.LightGray, i * scaleX, 0, i * scaleY, H);
		}

		var poly = new[] 
		{ 
			new PointF(ox*scaleX, oy*scaleY), 
			new PointF(qx*scaleX, qy*scaleY), 
			new PointF(px*scaleX, py*scaleY),
		};

		g.DrawPolygon(Pens.Black, poly);
		g.FillPolygon(new SolidBrush(Color.FromArgb(128, Color.Black)), poly);

	}
	
	b.Dump();
	
}

bool IsRightTriangle(int ox, int oy, int px, int py, int qx, int qy)
{
	if (qx == px && qy == py) return false;
	if (ox == px && oy == py) return false;
	if (qx == ox && qy == oy) return false;

	bool ro = ((px - 0) * (qx - 0) + (py - 0) * (qy - 0)) == 0;
	bool rp = ((px - 0) * (qx - px) + (py - 0) * (qy - py)) == 0;
	bool rq = ((px - qx) * (qx - 0) + (py - qy) * (qy - 0)) == 0;
	
	return ro || rp || rq;
}

void AddToResultCache(List<string> l, int ox, int oy, int px, int py, int qx, int qy)
{
	int i_q = qx * (SIZE + 1) + qy;
	int i_p = px * (SIZE + 1) + py;

	if (i_q > i_p)
	{
		l.Add(string.Format("[{0}|{1}] - [{2}|{3}]", px, py, qx, qy));
	}
	else
	{
		l.Add(string.Format("[{0}|{1}] - [{2}|{3}]", qx, qy, px, py));
	}
	
}

// same as (getAnglesBase() + 2 * getAnglesOuter())
// only optimized (and behaves like befunge program)
int SolutionFast()
{
	int triangles = 0;

	for (int q_x = SIZE; q_x > 0; q_x--)
	for (int q_y = SIZE; q_y > 0; q_y--)
	for (int p_y = q_y + 1;; p_y++)
	{
		if ((p_y - q_y) * q_y > q_x*q_x || p_y > SIZE) break;
		
		if (((p_y - q_y) * q_y) % q_x == 0)
		{
			triangles += (((q_y - p_y) * q_y) % q_x == 0) ? 2 : 0;
		}
	}

	return triangles + 3 * SIZE * SIZE;
}