<Query Kind="Program" />

void Main()
{
	List<int> pents = new List<int>();

	for (int k = 1; ; k++)
	{
		int pjk = k * (3 * k - 1) / 2;
		
		foreach (var pj in pents)
		{
			int pk = pjk - pj;
			if (pents.Contains(pk) & pents.Contains(pk - pj)) 
			{
				Console.Out.WriteLine();
				Console.Out.WriteLine();
				Console.Out.WriteLine(String.Format("P_k = P({0}) = {1}", 0, pk));
				Console.Out.WriteLine(String.Format("P_j = P({0}) = {1}", 0, pj));
				Console.Out.WriteLine();
				Console.Out.WriteLine(String.Format("D = {0}", pk - pj));
				
				return;
			}
		}
		
		if (k % 500 == 0)Console.Out.WriteLine("still running: " + k);
		pents.Add(pjk);
	}
}

// Define other methods and classes here
