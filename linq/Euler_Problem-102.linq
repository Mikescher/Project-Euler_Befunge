<Query Kind="Program">
  <Namespace>System.Drawing</Namespace>
</Query>

/*

Three distinct points are plotted at random on a Cartesian plane, for which `-1000 <= x,y <= 1000`, such that a triangle is formed.

Consider the following two triangles:

~~~
A(-340,495), B(-153,-910), C(835,-947)

X(-175,41), Y(-421,-714), Z(574,-645)
~~~

It can be verified that triangle ABC contains the origin, whereas triangle XYZ does not.

Using [triangles.txt](https://projecteuler.net/project/resources/p102_triangles.txt), a 27K text file containing the co-ordinates 
of one thousand "random" triangles, find the number of triangles for which the interior contains the origin.

NOTE: The first two examples in the file represent the triangles in the example given above.

*/

// 228

string[] DATA = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "p102_triangles.txt"));

[DebuggerDisplay("{x} | {y}")]
struct Vec2 { public long x; public long y; }

void Main()
{
	int result = 0;
	
	var zero = new Vec2 { x = 0, y = 0 };
	
	foreach (var row in DATA.Select(d => d.Split(',').Select(int.Parse).ToArray()))
	{
		var a = new Vec2 { x = row[0], y = row[1] };
		var b = new Vec2 { x = row[2], y = row[3] };
		var c = new Vec2 { x = row[4], y = row[5] };
		
		if (PointInTriangle_B93(a, b, c)) result++;
		//DrawDump(zero, a, b, c);
		
		if (PointInTriangle(zero, a, b, c) != PointInTriangle_B93(a,b,c)) throw new Exception();
	}
	
	result.Dump();
}

void DrawDump(Vec2 P, Vec2 A, Vec2 B, Vec2 C)
{
	Bitmap b = new Bitmap(2000, 2000);
	using (Graphics g = Graphics.FromImage(b))
	{
		g.Clear(Color.LightGray);
		g.TranslateTransform(1000, 1000);
		
		g.FillPolygon(Brushes.LightCoral, new PointF[] { new PointF(A.x, A.y), new PointF(B.x, B.y), new PointF(C.x, C.y) });
		g.DrawPolygon(new Pen(Color.Black, 4), new PointF[] { new PointF(A.x, A.y), new PointF(B.x, B.y), new PointF(C.x, C.y) });

		g.FillEllipse(Brushes.Magenta, new RectangleF(P.x - 16, P.y - 16, 32, 32));
		g.DrawLine(Pens.Red, -1000, P.y, +1000, P.y);
		g.DrawLine(Pens.Red, P.x, -1000, P.x, +1000);
		
	}
	
	new Bitmap(b, 250, 250).Dump();
}

// http://blackpawn.com/texts/polonginpoly/
bool PointInTriangle(Vec2 P, Vec2 A, Vec2 B, Vec2 C)
{
	var v0 = sub(C, A);
	var v1 = sub(B, A);
	var v2 = sub(P, A);
	
	// Compute dot products
	var dot00 = dot(v0, v0);
	var dot01 = dot(v0, v1);
	var dot02 = dot(v0, v2);
	var dot11 = dot(v1, v1);
	var dot12 = dot(v1, v2);
	
	// Compute barycentric coordinates
	var invDenom = 1.0 / (dot00 * dot11 - dot01 * dot01);
	
	var u = (dot11 * dot02 - dot01 * dot12) * invDenom;
	var v = (dot00 * dot12 - dot01 * dot02) * invDenom;
	
	// Check if polong is in triangle
	return (u >= 0) && (v >= 0) && (u + v < 1);
}

long dot(Vec2 a, Vec2 b) => a.x * b.x + a.y * b.y;
Vec2 sub(Vec2 a, Vec2 b) => new Vec2 { x = a.x - b.x, y = a.y - b.y };


bool PointInTriangle_B93(Vec2 A, Vec2 B, Vec2 C)
{
	var dot00 = (C.x-A.x)*(C.x-A.x) + (C.y-A.y)*(C.y-A.y);
	var dot01 = (C.x-A.x)*(B.x-A.x) + (C.y-A.y)*(B.y-A.y);
	var dot02 = (C.x-A.x)*(A.x)     + (C.y-A.y)*(A.y);
	var dot11 = (B.x-A.x)*(B.x-A.x) + (B.y-A.y)*(B.y-A.y);
	var dot12 = (B.x-A.x)*(A.x)     + (B.y-A.y)*(A.y);

	var d1 = dot01 * dot12 - dot11 * dot02;
	if (d1 < 0) return false;

	var d2 = dot01 * dot02 - dot00 * dot12;
	if (d2 < 0) return false;

	var d3 = dot00 * dot11 - dot01 * dot01;
	if (d1 + d2 >= d3) return false;

	return true;
}