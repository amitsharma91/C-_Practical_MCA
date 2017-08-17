/*	Write a program in C# Sharp to create a recursive function to find the factorial of a given number. 

	Expected Output :
	Enter a number: 5 
	The factorial of 5! is 120 
*/
using System;

namespace MyFirstProject
{
	public class Program10
	{
		public long fact(int num){
			if (num == 1)
				return 1;
			else
				return num * fact (--num);
		}

		/*static void Main(string[] str){
			Console.WriteLine ("Enter a Nuber to find Factorial: ");
			int num = Convert.ToInt32 (Console.ReadLine ());

			Program10 obj = new Program10 ();
			Console.WriteLine ("Factorial is: " + obj.fact (num));
		}*/
	}
}