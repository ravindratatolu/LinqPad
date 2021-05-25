<Query Kind="Program" />


//String Reverse optimal
void Main()
{
	string str = "Ravindra";
	var op=new char[10];
	for(int i=0,j=str.Length-1; i<j;i++,j--)
	{
		op[i]=str[j];
		op[j]=str[i];
	}
	var s = new String(op);
	s.Dump();
}

// You can define other methods, fields, classes and namespaces here
