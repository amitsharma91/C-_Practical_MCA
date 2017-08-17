/*	Write a program in C# Sharp to create a user define function with parameters. 

	Expected Output : 
	Please input a name : John 
	Welcome friend John ! 
	Have a nice day!
*/
using System;

namespace Program2
{
	public class Program2
	{
		public void methodParameter (String name)
		{
			Console.WriteLine ("Welcome friend " + name + "!\nHave a nice day!");
		}

		/*static void Main (string[] args)
		{
			Program2 obj = new Program2 ();
			obj.methodParameter ("Amit");
		}*/
	}
}