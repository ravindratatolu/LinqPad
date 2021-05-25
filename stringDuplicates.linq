<Query Kind="Program" />

//Duplicates in a string

void Main()
{
	string str = "abbccc";
	var dic = new Dictionary<char,int>();
	foreach(char c in str)
	{
		if(dic.ContainsKey(c))
		{
			dic[c]++;
		}
		else
		{
			dic.Add(c,1);
		}
	}
	dic.Dump();
}

// You can define other methods, fields, classes and namespaces here
