/*	Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another. 

	Expected Output :
	Input Base number: 3 
	Input the Exponent : 2 
	So, the number 3 ^ (to the power) 2 = 9
*/
using System;

namespace MyFirstProject
{
	public class Program6
	{
		public int power (int b, int e)
		{
			int n = 0, xp = 1;
			while (n < e) {
				xp = xp * b;
				n++;
			}
			return xp;
		}

		/*static void Main (string[] args)
		{
			Console.WriteLine ("Enter Base: ");
			int b = Convert.ToInt32 (Console.ReadLine ());

			Console.WriteLine ("Enter Exponent: ");
			int e = Convert.ToInt32 (Console.ReadLine ());

			Program6 obj = new Program6 ();

			Console.WriteLine (b + " ^ " + e + ": " + obj.power (b, e));

		}*/
	}
}