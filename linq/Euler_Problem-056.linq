<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
  <Namespace>System.Drawing</Namespace>
</Query>

void Main()
{
	const int FACTOR = 4;

	Bitmap bmp = new Bitmap(FACTOR*100, FACTOR*100, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
	int c = 0;
	using (Graphics g = Graphics.FromImage(bmp))
	{
		int max = 0;
		
		for (int a = 99; a > 0; a--)
		{
			for (int b = 99; b > 0; b--)
			{
				//if (a*b < 8500) break;
				//			if (a%10 == 0) break;
			
			
				int d = dsum(a, b);
				c++;
				
				if (max < d)
				{
					max = d;
					(a + "^" + b + " => " + d).Dump();	
				}
				
				int gv = (d*256)/1000;
				g.FillRectangle(new SolidBrush(Color.FromArgb(gv, gv, gv)), a*FACTOR, b*FACTOR, FACTOR, FACTOR);
			}
		}
	}
	bmp.Dump();
	c.Dump();
}

int dsum(int a, int b)
{
	int[] arr = new int[200];
	
	arr[199] = 1;
	
	for (; b > 0; b--)
	{
		int mod = 0;
		for (int i = 199; i >= 0; i--)
		{
			int val = arr[i] * a + mod;
			arr[i] = val%10;
			mod = val/10;
		}
	}
	
	int sum = 0;
	for (int i = 199; i >= 0; i--)
	{
		sum += arr[i];
	}
	
	return sum;
}