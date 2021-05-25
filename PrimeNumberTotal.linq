<Query Kind="Program" />

void Main()
{
	int[] numbers = {1,2,3,4,5};
	PrimeNumberTotal(numbers).Dump();
}

int PrimeNumberTotal(int[] num)
{
	int total=0;
	for(int i=0; i<=num.Length-1;i++)
	{
		if(i%2 == 0)
		{
			total+=i;
		}
	}
	return total;
}

//Given an array of ints, write a C# method to total all the values that are even numbers.
