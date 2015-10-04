<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

const int NMAX = 100;

void Main()
{
	Enumerable
		.Range(1, NMAX)
		.SelectMany(pn => Enumerable.Range(1, pn)
							.Select(pr => NCR(pn,pr))
							.Where(p => p > 1000000))
		.Count()
		.Dump();
		
	Enumerable
		.Range(1, NMAX)
		.SelectMany(pn => Enumerable.Range(1, pn)
							.Select(pr => NCR2(pn,pr))
							.Where(p => p > 1000000))
		.Count()
		.Dump();
		
	Enumerable
		.Range(1, NMAX)
		.SelectMany(pn => Enumerable.Range(1, pn)
							.Where(pr => NCR3(pn,pr)))
		.Count()
		.Dump();
		
	NCR4().Dump();
		
	NCR5().Dump();
		
	NCR6().Dump();
}

BigInteger NCR(long n, long r)
{
	BigInteger top = 1;
	for(long i = r+1; i <= n; i++) top *= i;
	
	BigInteger bot = 1;
	for(long i=2; i <= (n-r); i++) bot *= i;
	
	return top/bot;
}

BigInteger NCR2(long n, long r)
{
	long itop = r+1;
	long ibot=2;

	BigInteger result = 1;
	
	for(; itop <= n; itop++) 
	{
		long num = itop;
		
		while(num % ibot == 0 && ibot <= (n-r))
			num /= ibot++;
		
		result *= num;
	}
	
	for(; ibot <= (n-r); ibot++) result /= ibot;
	
	return result;
}

bool NCR3(long n, long r)
{
	long itop = r+1;
	long ibot = 2;

	BigInteger result = 1;
	
	for(; itop <= n; itop++) 
	{
		long num = itop;
		
		while(num % ibot == 0 && ibot <= (n-r))
			num /= ibot++;
		
		result *= num;
		
		while(result % ibot == 0 && ibot <= (n-r))
			result /= ibot++;
		
		if (ibot > (n-r) && result > 1000000)
			return true;
	}
	
	for(; ibot <= (n-r); ibot++) result /= ibot;
	
	return result > 1000000;
}

int NCR4()
{
	int count = 0;

	int[] matrix = Enumerable.Repeat(1, NMAX).ToArray();
	int[] tmp_matrix = Enumerable.Repeat(1, NMAX).ToArray();
	
	for(int row=2; row <= NMAX; row++)
	{
		for(int col=1; col < row; col++)
		{
			tmp_matrix[col] = matrix[col] + matrix[col - 1];
			
			if (tmp_matrix[col] > 1000000 || matrix[col]==0 || matrix[col - 1]==0)
			{
				count++;
				tmp_matrix[col] = 0;
			}
		}
		
		int[] swap = matrix;
		matrix = tmp_matrix;
		tmp_matrix = swap;
	}
	
	return count;
}

int NCR5()
{
	int count = 0;

	int[] matrix1 = Enumerable.Repeat(1, NMAX/2 + 1).ToArray();
	int[] matrix2 = Enumerable.Repeat(1, NMAX/2 + 1).ToArray();
	
	for(int row=2; row <= NMAX; row++)
	{
		for(int col=1; col <= row/2; col++)
		{
			if (2*col==row)
			{
				matrix2[col] = matrix1[col - 1]*2;
				
				if (matrix2[col] > 1000000 || matrix1[col - 1]==0)
				{
					count += 1;
					matrix2[col] = 0;
				}
			}
			else
			{
				matrix2[col] = matrix1[col] + matrix1[col - 1];
				
				if (matrix2[col] > 1000000 || matrix1[col] == 0 || matrix1[col - 1] == 0)
				{
					count += 2;
					matrix2[col] = 0;
				}
			}
		}
		
		int[] swap = matrix1;
		matrix1 = matrix2;
		matrix2 = swap;
	}
	
	return count;
}

int NCR6()
{
	int count = 0;
	
	int[][] matrix = 
	{
		Enumerable.Repeat(999, NMAX/2 + 1).ToArray(), 
		Enumerable.Repeat(999, NMAX/2 + 1).ToArray()
	};
	
	matrix[0][0] = 1;
	matrix[1][0] = 1;
	
	for(int row=2; row <= NMAX; row++)
		for(int col=row/2; col > 0; col--)
		{
			if (2*col == row)
				matrix[row % 2][col] = matrix[(row + 1) % 2][col - 1] * 2;
			else
				matrix[row % 2][col] = matrix[(row + 1) % 2][col] + matrix[(row + 1) % 2][col - 1];
			
				
			if (matrix[row % 2][col] > 1000000 || matrix[(row + 1) % 2][col] == 0 || matrix[(row + 1) % 2][col - 1] == 0)
			{
				count += (2 * col == row) ? 1 : 2;
				matrix[row % 2][col] = 0;
			}
		}
	
	return count;
}