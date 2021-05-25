<Query Kind="Program" />


//polindrome or not
void Main()
{
	string str ="asfasd";
	for(int i=0, j=str.Length-1; i<j;i++,j--)
	{
		if(str[i]!=str[j])
		{
			"NotPolindrome".Dump();
			break;
		}
	}
}

// You can define other methods, fields, classes and namespaces here
