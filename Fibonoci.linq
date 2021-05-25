<Query Kind="Program" />

//Fibinoci series

void Main()
{
	int range=10;
	for(int i =0; i<11; i++)
	{
	Fib(i).Dump();
	}
}

int Fib(int n)
{
	if(n==0 || n==1)
	{
		return 1;
	}
	return Fib(n-1)+Fib(n-2);
}
// You can define other methods, fields, classes and namespaces here
