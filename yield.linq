<Query Kind="Program" />

/* Yield keyword in c#
 In a nutshell we can achieve custom stateful iteration using yield keyword.
 1. custom iteratin without using temp collection
 2. statefull iteration
 */

void Main()
{
	//custom iteration example
	IList<int> numbers = new List<int>(){1,2,3,4,5,6,7,8,9};
	Console.WriteLine(ReturnNumbersGraterThanThreeWithTempCollection(numbers));
	Console.WriteLine(ReturnNumbersGratterThanThreeWithOutTempCollection(numbers));
	
	//statful iteration with running total
	CalculateRunningTotal(numbers).Dump();
}

//conventional way. i.e., with temp collection
IEnumerable<int> ReturnNumbersGraterThanThreeWithTempCollection(IList<int> numbers){
	//temp collection
	var temp = new List<int>();
	foreach(var num in numbers)
	{
		if(num >3)
		{
			temp.Add(num);
		}
	}
	return temp;
}
//custom iteration without using temp collection
IEnumerable<int> ReturnNumbersGratterThanThreeWithOutTempCollection(IList<int> numbers)
{
	foreach(int num in numbers){
		if(num > 3){
			yield return num;
		}
	}
}

//stateful iteration example
// the value of running total is retained.
IEnumerable<int> CalculateRunningTotal(IList<int> numbers)
{
	int runningTotal = 0;
	foreach(int num in numbers)
	{
		runningTotal += num;
		yield return runningTotal;
	}
}
