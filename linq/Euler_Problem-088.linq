<Query Kind="Program" />

/*
A natural number, N, that can be written as the sum and product of a given set of 
at least two natural numbers, `{a1, a2, ... , ak}` is called a product-sum number: 
`N = a1 + a2 + ... + ak = a1 * a2 * ... * ak`.

For example, 6 = 1 + 2 + 3 = 1 × 2 × 3.

For a given set of size, k, we shall call 
the smallest N with this property a minimal product-sum number.
The minimal product-sum numbers for sets of size, `k = 2, 3, 4, 5`, and `6` are as follows.

~~~
k=2:  4 = 2 * 2 = 2 + 2
k=3:  6 = 1 * 2 * 3 = 1 + 2 + 3
k=4:  8 = 1 * 1 * 2 * 4 = 1 + 1 + 2 + 4
k=5:  8 = 1 * 1 * 2 * 2 * 2 = 1 + 1 + 2 + 2 + 2
k=6: 12 = 1 * 1 * 1 * 1 * 2 * 6 = 1 + 1 + 1 + 1 + 2 + 6
~~~

Hence for `2<=k<=6`, the sum of all the minimal product-sum numbers is `4+6+8+12 = 30`;
note that 8 is only counted once in the sum.

In fact, as the complete set of minimal product-sum numbers for `2<=k<=12`
is `{4, 6, 8, 12, 15, 16}`, the sum is `61`.

What is the sum of all the minimal product-sum numbers for `2<=k<=12000`?
*/

const int LIMIT =  12 * 1000;
readonly bool DBG = false;

void Main()
{
	//Solution_1();
	Solution_2();
}

void Solution_1()
{
	Enumerable
		.Range(2, LIMIT-1)
		.Select(MinProductSum)
		.Distinct()
		.Sum()
		.Dump();
}

int MinProductSum(int k)
{
	if (k == 1) return 1;
	
	int[] arr = Enumerable.Repeat(1, k+1).ToArray();
	arr[1] = 2;
	int sum = k + 1;
	int prod = 2;
	
	int min = int.MaxValue;

	for (; ;)
	{
		sum++;

		prod /= arr[0];
		arr[0]++;
		prod *= arr[0];
		
		int pos = 0;


		while (prod > sum || prod >= min || sum >= min)
		{
			prod /= arr[pos];
			sum -= arr[pos];
			arr[pos] = arr[pos + 1];
			sum += arr[pos];
			prod *= arr[pos];

			pos++;
			if (pos == k) return min;

			sum++;
			prod /= arr[pos];
			arr[pos]++;
			prod *= arr[pos];
		}
		if (prod == sum)
		{
			if (DBG) ("[+] " + string.Join(" :: ", arr.Take(k).Reverse()) + " = " + sum).Dump();
			min = sum;
		}
	}
}

void Solution_2()
{
	int[] result = Enumerable.Repeat(Int32.MaxValue, LIMIT + 1).ToArray();

	int[] arr = Enumerable.Repeat(1, LIMIT + 2).ToArray();
	arr[1] = 2;

	int len = 2;
	int sum = LIMIT + 1;
	int prod = 2;

	for (; ;)
	{
		sum++;

		prod /= arr[0];
		arr[0]++;
		prod *= arr[0];

		int pos = 0;
		while (prod > sum + (LIMIT - len))
		{
			prod /= arr[pos];
			sum -= arr[pos];
			arr[pos] = arr[pos + 1];
			sum += arr[pos];
			prod *= arr[pos];

			pos++;
			if (pos == LIMIT + 1)
			{
				result.Skip(2).Distinct().Sum().Dump();
				return;
			}

			sum++;
			prod /= arr[pos];
			arr[pos]++;
			prod *= arr[pos];

			len = Math.Max(len, pos);
		}
		if (LIMIT - (sum - prod) > 1 &&  sum >= prod && result[LIMIT - (sum - prod)] > prod)
		{
			if (DBG) string.Format("{0} => {1}", LIMIT - (sum - prod), prod).Dump();
			result[LIMIT - (sum - prod)] = prod;
		}
	}
}

// 7 587 457

/*
Let's say limit is our maximum value of k (`12 000`).

We start with an array of size LIMIT, filled with ones.
Our current sum is `LIMIT` and our current product is `1`.
To kickstart the whole progress we set `arr[1] = 2` (now sum is `LIMIT+1` and product is `2`).
We also remember the amount of changed fields, which are possible not one (initial `2`).

Now we iterate through all the possible array-combinations (with a few tricks to limit the search-space).

 - In each step we increment array[0]. And update the fields sum and product.
   This update is not that complex, sum is incrementing by `1` and
   product is `(product / arr[0]-1) * arr[0]`
 - While `prod > sum + (LIMIT - len)` we reset the current `arr[pos]` to `arr[pos + 1]` 
   and increment arr[pos + 1] 
   (and obviously increment `pos` and update `sum` and `product`)
 - After that we have a valid array valud. We can now test for which value of k this is a result
   (and if is is better than a previous found value)
 - The value of k is `k := LIMIT - (sum - prod)`
   The trick here is that we generate a solution by cutting away a lot of the ones at the end of our array 
   to get a solution where `prod = sum` (cutting ones decreemnts sum but leaves prod unchanged).
 - The condition to cut away only ones is given by our previous condition `prod > sum + (LIMIT - len)`.
 - After we have gone through all the possible values this way we only have calculate the sum of all the unique values
 
Because in the last step the list is almost sorted (not totally sorted but there arent that many cases where result[i] > result[i+1])
we can use a need little algorithm which eliminates duplicates by running through the list 
and doing sum occasional backtracing with an complexity of almost O(N).

I know, the algorithm got a bit complex, but it's pretty fast - even when converted to befunge.

*/