<Query Kind="Program" />

void Main()
{
	Console.WriteLine(
	
		Palindroms()
			.Where(p => IsPalindrome(p, 2))
			.Sum()
		
	);
	
	Console.WriteLine(
	
		Palindroms()
			.Where(p => IsPalindrome(p, 2))
		
	);
}

private IEnumerable<int> Palindroms()
{
	for(int i = 999; i > 0; i--)
		yield return createPalindrome(i, 10, false);
	
	for(int i = 999; i > 0; i--)
		yield return createPalindrome(i, 10, true);
}

private int createPalindrome(int input, int b, bool isOdd) {
    int n = input;
    int palin = input;
	
    if (isOdd) n /= b;
 
    while (n > 0) {
        palin = palin * b + (n % b);
        n /= b;
    }
 
    return palin;
}

private bool IsPalindrome(int number, int b){
    int reversed = 0;
    int k = number;
 
    while (k > 0) {
        reversed *=b;
        reversed += k % b;
        k /= b;
    }
    return number == reversed;
}