<Query Kind="Program" />

void Main()
{
	Console.WriteLine(Enumerable.Range(2, 355000).Where(IsP5Equals).Sum());
	Console.WriteLine(Enumerable.Range(2, 355000).Where(IsP5Equals));
}

bool IsP5Equals(int i)
{
	int sumOfPowers = 0;
    int number = i;
    while (number > 0) {
        int d = number % 10;
        number /= 10;
 
        int temp = d;
        for(int j = 1; j < 5; j++){
            temp *= d;
        }
        sumOfPowers += temp;
    }
	
	return sumOfPowers == i;
}
